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
using IHChan.Options;
using IDLChan;
using IHChan.Environment;

namespace IHChan.UserControl
{
    enum ColType
    {
        Nation = 0,
        NatDefCnt,
        NatDeathCnt,
        NatDeathRate,
    }
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

        private mfrm_main Main { get; set; }
        private GeoMap GeoMap { get; set; }
        private List<InformationOfCovidOverseasJson> OverseasData { get; set; }
        private List<ISO3166> ISO3166s { get; set; }
        private string SelectedDate { get; set; } = $"{DateTime.Now:d}";
        private BackgroundWorker Worker { get; set; }

        private int MaxDefCnt { get; set; } = default(int);

        public MetroOverseas(mfrm_main main)
        {
            this.Main = main;
            this.Main.NoramlControlColorSetHandler += InitializeGraph;

            InitializeComponent();
            InitializeControl();
            InitializeBaseControl(this);
            InitializeGrid();
            InitializeMap();
            InitializeGraph();

            CovidRefresh();
        }

        private void InitializeGraph()
        {
            ChangeGraghColor(cg_total);
            ChangeGraghColor(cg_death);
            ChangeGraghColor(cg_deathrate);            
        }

        private void ChangeGraghColor(CircleGraph graph)
        {
            graph.TextColor = ColorSet.GetMetroColorToSystemColor(Main.Style);
            graph.ForeCircleColor = ColorSet.GetMetroColorToSystemColor(Main.Style);
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

            mgr_covidList.ScrollBars = ScrollBars.Horizontal;
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

        // RunWorkerCompleted Method is UI Thread
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Result is List<InformationOfCovidOverseasJson> overseas)
                {
                    lock (_thislock)
                    {
                        OverseasData = overseas;
                        var mapValues = new Dictionary<string, double>();

                        var todayOverseas = OverseasData.Where(sea => $"{sea.CreateDt:d}" == SelectedDate);

                        if (todayOverseas.Count() == 0)
                        {
                            return;
                        }

                        mps_process.Maximum = todayOverseas.Count();

                        MaxDefCnt = (int)todayOverseas.Max(cnt => cnt.NatDefCnt);

                        foreach (var oversea in todayOverseas)
                        {  

                            // find iso code
                            var iso = ISO3166s.Where(ISO3166 =>
                            {
                                return ISO3166.KName == oversea.NationNm;
                            }).FirstOrDefault();

                            if (iso != null)
                            {
                                mgr_covidList.Rows.Add(oversea.NationNm, oversea.NatDefCnt, oversea.NatDeathCnt, oversea.NatDeathRate, iso.Code);
                                mapValues.Add(iso.Code, oversea.NatDefCnt);
                            }

                            ++mps_process.Value;
                        }

                        if (mapValues.Count != 0)
                        {
                            GeoMap.HeatMap = mapValues;
                        }

                        // grid scroll bar position
                        mgr_covidList.FirstDisplayedScrollingRowIndex = 1;
                        mgr_covidList.FirstDisplayedScrollingRowIndex = 0; 

                        mgr_covidList.Sort(mgr_covidList.Columns["col_count"], ListSortDirection.Descending);
                        mgr_covidList.Rows[0].Selected = true;
                        mgr_covidList_CellClick(null, null);
                    }
                } 
            }
            finally
            {
                mps_process.Visible = false;                
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

        private void mgr_covidList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mgr_covidList.Rows.Count < 1)
            {
                return;
            }

            for(int idx = 0; idx < mgr_covidList.ColumnCount; idx++)
            { 
                SetGraph((ColType)idx, mgr_covidList.SelectedCells[idx].Value);
            }            
        }

        private void GeoMap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            var nation = arg2.Id;

            // todo - refactoring
            for (int idxr = 0; idxr < mgr_covidList.RowCount; idxr++)
            {
                if (mgr_covidList.Rows[idxr].Cells["col_nation"].Value.ToString() == nation)
                {
                    for (int idxc = 0; idxc < mgr_covidList.ColumnCount; idxc++)
                    {
                        SetGraph((ColType)idxc, mgr_covidList.Rows[idxr].Cells[idxc].Value);
                    }

                    mgr_covidList.FirstDisplayedScrollingRowIndex = idxr;
                    mgr_covidList.Rows[idxr].Selected = true;
                    break;
                }
            }
        } 

        private void SetGraph(ColType type, object value)
        {
            switch (type)
            { 
                // 확진자 수
                case ColType.NatDefCnt:
                    if (value is double def)
                    {
                        ClearCircleProperty(cg_total);
                        cg_total.MaxValue = MaxDefCnt;
                        cg_total.Value = (int)def;
                        cg_total.CirCleText = $"{cg_total.Value:#,##0} / {cg_total.MaxValue:#,##0}";
                    }
                    break;
                // 사망자 수
                case ColType.NatDeathCnt:
                    if (value is double death)
                    {
                        ClearCircleProperty(cg_death);
                        cg_death.MaxValue = cg_total.Value;
                        cg_death.Value = (int)death;
                        cg_death.CirCleText = $"{cg_death.Value:#,##0} / {cg_death.MaxValue:#,##0}";
                    }
                    break;
                // 사망자 비율
                case ColType.NatDeathRate:
                    if (value is double rate)
                    {
                        ClearCircleProperty(cg_deathrate);
                        cg_deathrate.MaxValue = 100;
                        cg_deathrate.Value = (int)Math.Round(rate);
                        cg_deathrate.CirCleText = $"{Math.Round(rate,2)} / {cg_deathrate.MaxValue}";
                    }
                    break;
                default:
                    break;
            }
        }

        private void ClearCircleProperty(CircleGraph graph)
        {
            graph.Value = 0;
            graph.MaxValue = 100;
        } 
    } 
}
