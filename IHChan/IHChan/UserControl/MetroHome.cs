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
        }

        private void InitializeControl()
        {
            mlb_date.Text = $"Today : {TodayDate}";

            mlb_vaccine.Text = $"국내현황 {TodayDate}. 00:00 집계 기준";
        }
    }
}
