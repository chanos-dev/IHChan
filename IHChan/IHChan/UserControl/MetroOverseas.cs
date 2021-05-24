using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using LiveCharts.WinForms;
using System.Windows.Media;
using IHChan.APIs;
using System.Threading;
using IHChan.Model;
using IHChan.Converter;
using System.IO;

namespace IHChan.UserControl
{
    /// <summary>
    /// 21.05.22 Issuse : MetroGrid Style이 적용이 안됨
    /// </summary>
    internal partial class MetroOverseas : BaseMetroUserControl
    {
        #region inner class
        // 국가 코드
        internal class ISO3166
        {
            private const string CsvPath = @"World/ISO3166.csv";

            internal string EName { get; set; }

            internal string KName { get; set; }

            internal string Code { get; set; }

            public ISO3166()
            {

            }

            public static List<ISO3166> GetISOCodeData()
            {
                var datas = new List<ISO3166>();

                // 한글 - euc-kr 인코딩
                using (var sr = new StreamReader(CsvPath, Encoding.GetEncoding("euc-kr")))
                {
                    while (!sr.EndOfStream)
                    {
                        string data = sr.ReadLine();
                        var splitData = data.Split(',');

                        datas.Add(new ISO3166()
                        {
                            EName = splitData[0],
                            KName = splitData[1],
                            Code = splitData[2],
                        });
                    }
                }

                return datas;
            }
        }
        #endregion

        private object _thislock { get; set; } = new object();

        private readonly string WorldPath = @"World/World.xml";
        private GeoMap GeoMap { get; set; }

        private List<InformationOfCovidOverseasJson> OverseasData { get; set; }

        private List<ISO3166> ISO3166s { get; set; }

        private string SelectedDate { get; set; } = $"{DateTime.Now:d}";

        private BackgroundWorker Worker { get; set; }

        public MetroOverseas()
        {
            InitializeComponent();
            InitializeControl();
            InitializeBaseControl(this);
            InitializeGrid();
            InitializeMap();

            CovidRefresh();
        }

        private void InitializeGrid()
        {
            // header font
            mgr_covidList.ColumnHeadersDefaultCellStyle.Font = new Font("Aria", 12);

            // cell font
            mgr_covidList.DefaultCellStyle.Font = new Font("Aria", 12);

            mgr_covidList.MultiSelect = false;

            mgr_covidList.AllowUserToAddRows = false;

            mgr_covidList.AllowUserToDeleteRows = false;

            mgr_covidList.AllowUserToResizeColumns = false;

            mgr_covidList.AllowUserToOrderColumns = true;
        }

        private void InitializeControl()
        {
            DirectControls = new List<IMetroControl>();

            DirectControls.Add(mgr_covidList);

            ISO3166s = ISO3166.GetISOCodeData();

            Worker = new BackgroundWorker();

            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void InitializeMap()
        { 
            GeoMap = new GeoMap();

            GeoMap.Source = WorldPath;

            // move, zoom in and zoom out
            GeoMap.EnableZoomingAndPanning = true;

            // show a value of heatmap on the Geomap.
            GeoMap.Hoverable = true; 

            GeoMap.DefaultLandFill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 242, 242));

            GeoMap.Base.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(128, 128, 128));

            mpnl_map.Controls.Add(GeoMap);
            GeoMap.Dock = DockStyle.Fill;            

            GeoMap.LandStroke = new SolidColorBrush(Colors.Black);

            GeoMap.GradientStopCollection = new GradientStopCollection()
            {
                new GradientStop(System.Windows.Media.Color.FromRgb(250,233,233), 0.00),
                new GradientStop(System.Windows.Media.Color.FromRgb(234,207,207), 0.25),
                new GradientStop(System.Windows.Media.Color.FromRgb(191,132,132), 0.55),
                new GradientStop(System.Windows.Media.Color.FromRgb(158,76,76), 0.75),
                new GradientStop(System.Windows.Media.Color.FromRgb(113,0,0), 1.00),
            };

            GeoMap.LandClick += GeoMap_LandClick;
        }

        private void GeoMap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            MessageBox.Show("Test");
        }

        // RunWorkerCompleted Method is UI Thread
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is List<InformationOfCovidOverseasJson> overseas)
            {
                lock (_thislock)
                {
                    try
                    {
                        OverseasData = overseas;
                        var mapValues = new Dictionary<string, double>();

                        var todayOverseas = OverseasData.Where(sea => $"{sea.CreateDt:d}" == SelectedDate);

                        if (todayOverseas.Count() == 0)
                            return;

                        mps_process.Maximum = todayOverseas.Count();

                        foreach (var oversea in todayOverseas)
                        {
                            mgr_covidList.Rows.Add(oversea.NationNm, oversea.NatDefCnt);

                            // find iso code
                            var iso = ISO3166s.Where(ISO3166 =>
                            {
                                return ISO3166.KName == oversea.NationNm;
                            }).FirstOrDefault();

                            if (iso != null)
                            {
                                mapValues.Add(iso.Code, oversea.NatDefCnt);
                            }

                            ++mps_process.Value;
                        }

                        if (mapValues.Count != 0)
                            GeoMap.HeatMap = mapValues;

                        mgr_covidList.Sort(mgr_covidList.Columns["col_count"], ListSortDirection.Descending);

                        mgr_covidList.FirstDisplayedScrollingRowIndex = 1;
                        mgr_covidList.FirstDisplayedScrollingRowIndex = 0;                        
                    }
                    finally
                    {
                        mps_process.Visible = false;
                    }
                }
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = CovidController.Instance.GetOverseasCovidState(SelectedDate, SelectedDate);
        }

        private void mdt_date_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = $"{mdt_date.Value:d}";
            CovidRefresh();
        }

        private void mbtn_refresh_Click(object sender, EventArgs e) => CovidRefresh();

        private void CovidRefresh()
        {
            // refresh overseas covid
            if (!Worker.IsBusy)
            {
                // clear
                mps_process.Value = 0;
                mps_process.Visible = true;
                mgr_covidList.Rows.Clear();

                Worker.RunWorkerAsync();
            }
        }
    } 
}
