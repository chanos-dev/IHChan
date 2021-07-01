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

namespace IHChan.UserControl
{
    internal partial class MetroHome : BaseMetroUserControl
    {
        private string TodayDate => $"{DateTime.Now:d}";

        private BackgroundWorker Worker { get; set; }

        public MetroHome() : base()
        {
            InitializeComponent();
            InitializeBaseControl(this);
            InitializeControl();

            InitializeDashboard();
        }

        private void InitializeDashboard()
        {
            db_homedef.Type = CovidType.DefCnt;
            db_homeisolclear.Type = CovidType.IsolClear;
            db_homedeath.Type = CovidType.Death;
            db_homeisoling.Type = CovidType.IsolIng;

            db_overseadef.Type = CovidType.DefCnt;
            db_overseaisolclear.Type = CovidType.IsolClear;
            db_overseadeath.Type = CovidType.Death;
            db_overseaisoling.Type = CovidType.IsolIng;

            dbv_first.Type = VaccineType.First | VaccineType.All;
            dbv_second.Type = VaccineType.Second | VaccineType.All;

            dbv_firstsido.Type = VaccineType.First;
            dbv_secondsido.Type = VaccineType.Second;

            mcb_location.Items.AddRange(Enum.GetNames(typeof(Sido)));

            // delete sido.검역
            mcb_location.Items.RemoveAt(mcb_location.Items.Count-1);

            mcb_location.SelectedIndex = 1;
        }

        private void InitializeControl()
        {
            mlb_date.Text = $"Today : {TodayDate}";

            mlb_vaccine.Text = $"국내현황 {TodayDate}. 00:00 집계 기준";
        }
    }
}
