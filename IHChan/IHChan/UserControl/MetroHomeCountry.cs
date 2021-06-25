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

namespace IHChan.UserControl
{
    internal partial class MetroHomeCountry : BaseMetroUserControl
    {
        private struct CovidData
        {
            public int Value;
            public int PrevValue;

            public int DiffValue
            {
                get
                {
                    if (Value == 0)
                        return 0;

                    return Value - PrevValue;
                }
            }
        }

        private object _thislock { get; set; } = new object();
        private string SelectedDate { get; set; } = $"{DateTime.Now:d}";

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
        }

        private void InitializeControl()
        {
            Worker = new BackgroundWorker();

            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            // todo - refactoring
            mcb_location.Items.AddRange(new[]
            {
                "합계",
                "서울",
                "부산",
                "대구",
                "인천",
                "광주",
                "대전",
                "울산",
                "세종",
                "경기",
                "강원",
                "충북",
                "충남",
                "전북",
                "전남",
                "경북",
                "경남",
                "제주",
                "검역",
            });

            mcb_location.SelectedIndex = 0;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is List<InformationOfCovidSidoJson> sidos)
            {
                SidosData = sidos.OrderBy(sido => sido.DefCnt).ToList();

                var selectedSido = SidosData.Where(sido => sido.Gubun == mcb_location.Text).Select(sido =>
                {
                    return new { Date = $"{sido.CreateDt:d}", Sido = sido };
                });

                // text = 153,155명 +610명
                // get difference values
                // DefCnt  
                var defCnt = new CovidData();

                // DeathCnt
                var deathCnt = new CovidData();
                
                // IsollngCnt
                var isolIngCnt = new CovidData();

                // IsolClearCnt
                var isolClearCnt = new CovidData();
                
                // todo - refactoring
                foreach (var sido in selectedSido)
                {
                    if (sido.Date == SelectedDate)
                    {
                        defCnt.Value = sido.Sido.DefCnt.ConvertToInt();
                        deathCnt.Value = sido.Sido.DeathCnt.ConvertToInt();
                        isolIngCnt.Value = sido.Sido.IsolIngCnt.ConvertToInt();
                        isolClearCnt.Value = sido.Sido.IsolClearCnt.ConvertToInt();
                    }
                    else
                    {
                        defCnt.PrevValue = sido.Sido.DefCnt.ConvertToInt();
                        deathCnt.PrevValue = sido.Sido.DeathCnt.ConvertToInt();
                        isolIngCnt.PrevValue = sido.Sido.IsolIngCnt.ConvertToInt();
                        isolClearCnt.PrevValue = sido.Sido.IsolClearCnt.ConvertToInt();
                    }
                }

                cg_def.CircleTextIn = $"{defCnt.Value:#,##0}명 +{defCnt.DiffValue}명";
                cg_death.CircleTextIn = $"{deathCnt.Value:#,##0}명 +{deathCnt.DiffValue}명";
                cg_isollng.CircleTextIn = $"{isolIngCnt.Value:#,##0}명 +{isolIngCnt.DiffValue}명";
                cg_isolclear.CircleTextIn = $"{isolClearCnt.Value:#,##0}명 +{isolClearCnt.DiffValue}명";

                ClearCircleProperty(cg_def);
                cg_def.MaxValue = defCnt.Value;
                cg_def.Value = defCnt.Value;

                ClearCircleProperty(cg_death);
                cg_death.MaxValue = defCnt.Value;
                cg_death.Value = deathCnt.Value;

                ClearCircleProperty(cg_isollng);
                cg_isollng.MaxValue = defCnt.Value;
                cg_isollng.Value = isolIngCnt.Value;

                ClearCircleProperty(cg_isolclear);
                cg_isolclear.MaxValue = defCnt.Value;
                cg_isolclear.Value = isolClearCnt.Value;
            }
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

        private void mcb_location_SelectedIndexChanged(object sender, EventArgs e) => CovidRefresh();
    }
}
