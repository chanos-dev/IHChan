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
using IHChan.Environment;
using IDLChan;
using IHChan.APIs;
using IHChan.Model;
using IHChan.Extentions;
using MetroFramework;
using Type = IHChan.Model.Type;
using IHChan.Attributes;

namespace IHChan.UserControl
{
    internal partial class MetroHomeCountry : BaseMetroUserControl
    { 
        private object _thislock { get; set; } = new object();
        private string SelectedDate { get; set; } = $"{DateTime.Now:d}";

        private CovidContent TotalCovidContent { get; set; }

        private mfrm_main Main { get; set; }
        private BackgroundWorker Worker { get; set; }
        private CircleGraph[] CircleGraphs { get; set; }
        private List<InformationOfCovidSidoJson> SidosData { get; set; }

        public MetroHomeCountry(mfrm_main main)
        {
            this.Main = main;
            this.Main.NoramlControlColorSetHandler += InitializeGraph;

            InitializeComponent();
            InitializeBaseControl(this);
            CircleGraphs = new[] { cg_def, cg_death, cg_isollng, cg_isolclear };
            InitializeGraph();
            InitializeControl();

            CovidRefresh();
        }

        private void InitializeControl()
        {
            TotalCovidContent = new CovidContent();

            Worker = new BackgroundWorker();

            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            mcb_location.Items.AddRange(Enum.GetNames(typeof(Sido)));            

            mcb_location.SelectedIndex = 0;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is List<InformationOfCovidSidoJson> sidos)
            {
                SidosData = sidos.OrderBy(sido => sido.DefCnt).ToList();

                // set total data
                var totals = SidosData.Where(sido =>
                {
                    return sido.Gubun == nameof(Sido.합계);
                });

                foreach (var total in totals)
                {
                    if ($"{total.CreateDt:d}" == SelectedDate)
                    {
                        TotalCovidContent.InitializeData(total, Type.Current);
                    }
                    else
                    {
                        TotalCovidContent.InitializeData(total, Type.Previous);
                    }
                }
                

                SetContentOnDashBoard();
            }
        }

        private void SetContentOnDashBoard()
        {
            // no data
            if (!SidosData.IsAny())
                return;

            var selectedSido = SidosData.Where(sido => sido.Gubun == mcb_location.Text).Select(sido =>
            {
                return new { Date = $"{sido.CreateDt:d}", Sido = sido };
            });

            // get difference values
            var content = new CovidContent();

            foreach (var sido in selectedSido)
            {
                if (sido.Date == SelectedDate)
                {
                    content.InitializeData(sido.Sido, Type.Current);
                }
                else
                {
                    content.InitializeData(sido.Sido, Type.Previous);
                }
            }

            // todo - refactoring
            // set graph
            cg_def.CircleTextIn = $"{content:DEF}";
            cg_death.CircleTextIn = $"{content:DEATH}";
            cg_isollng.CircleTextIn = $"{content:ISOLING}";
            cg_isolclear.CircleTextIn = $"{content:ISOLCLEAR}";

            ClearCircleProperty(cg_def);
            cg_def.MaxValue = TotalCovidContent.DefCnt.Value;
            cg_def.Value = content.DefCnt.Value;

            ClearCircleProperty(cg_death);
            cg_death.MaxValue = TotalCovidContent.DeathCnt.Value;
            cg_death.Value = content.DeathCnt.Value;

            ClearCircleProperty(cg_isollng);
            cg_isollng.MaxValue = TotalCovidContent.IsolIngCnt.Value;
            cg_isollng.Value = content.IsolIngCnt.Value;

            ClearCircleProperty(cg_isolclear);
            cg_isolclear.MaxValue = TotalCovidContent.IsolClearCnt.Value;
            cg_isolclear.Value = content.IsolClearCnt.Value;

            // set total dashboard
            db_total.Title = nameof(Sido.합계);

            db_total.DefCnt = $"{TotalCovidContent:DEF}";
            db_total.DeathCnt = $"{TotalCovidContent:DEATH}";
            db_total.Isoling = $"{TotalCovidContent:ISOLING}";
            db_total.IsolClear = $"{TotalCovidContent:ISOLCLEAR}";
            db_total.Rate = $"{TotalCovidContent:RATE}";

            // set selected location dashboard            
            db_location.DefCnt = cg_def.CircleTextIn;
            db_location.DeathCnt = cg_death.CircleTextIn;
            db_location.Isoling = cg_isollng.CircleTextIn;
            db_location.IsolClear = cg_isolclear.CircleTextIn;
            db_location.Rate = $"{content:RATE}";
        }

        private void ClearCircleProperty(CircleGraph graph)
        {
            graph.Value = 0;
            graph.MaxValue = 100;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = CovidController.Instance.GetSidoCovidState(SelectedDate, SelectedDate);
        }

        private void InitializeGraph()
        {
            //ChangeGraghColor(CircleGraphs); 

            // todo - refactoring
            cg_def.TextColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Orange);
            cg_def.ForeCircleColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Orange);

            cg_death.TextColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Red);
            cg_death.ForeCircleColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Red);

            cg_isollng.TextColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Blue);
            cg_isollng.ForeCircleColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Blue);

            cg_isolclear.TextColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Green);
            cg_isolclear.ForeCircleColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Green);
        }

        private void ChangeGraghColor(CircleGraph[] graphs)
        {
            foreach(var graph in graphs)
            {
                graph.TextColor = ColorSet.GetMetroColorToSystemColor(Main.Style);
                graph.ForeCircleColor = ColorSet.GetMetroColorToSystemColor(Main.Style);
            }            
        }

        private void mdt_date_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = $"{mdt_date.Value:d}";
            CovidRefresh();
        }

        private void CovidRefresh()
        {
            // refresh overseas covid
            if (!Worker.IsBusy)
            {
                // clear all graph
                ClearGraph(CircleGraphs);

                Worker.RunWorkerAsync();
            }
        }

        private void ClearGraph(CircleGraph[] graphs)
        {
            foreach (var graph in graphs)
            {
                graph.CircleTextIn = "-";
            }
        }

        private void mcb_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetContentOnDashBoard();
            // set url
            SetDashBoardURL();
        }

        private void SetDashBoardURL()
        {
            db_total.URL = CovidLocationAttribute.GetSidoAttributeValue(Sido.합계);

            // dashboard 지역 타이틀은 여기서.
            db_location.Title = mcb_location.Text;
            db_location.URL = string.Empty;

            if (Enum.TryParse(mcb_location.Text, out Sido result))
            {
                db_location.URL = CovidLocationAttribute.GetSidoAttributeValue(result);
            }
        }
    }
}
