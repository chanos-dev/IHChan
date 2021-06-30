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
using System.Drawing.Drawing2D;
using IHChan.Options;
using MetroFramework;
using System.Reflection;
using System.Diagnostics;
using IHChan.Environment;

namespace IHChan.UserControl
{
    internal partial class DashBoardDetail : MetroUserControl
    {
        #region Fields 
        // 타이틀
        private string _title = "합계";

        // 지역 사이트
        private string _url;

        // 확진자
        private string _defcnt = "-";

        // 사망자
        private string _deathcnt = "-";

        // 격리 해제
        private string _isolclear = "-";

        // 격리 중
        private string _isoling = "-";

        // 발생률
        private string _rate = "-";

        #endregion


        #region Properties 
        [Category("DashBoardDetail Properties")]
        public string Title
        {
            get => _title;
            set
            { 
                _title = value;
                mlb_Title.Text = Title;
                this.Refresh();
            }
        }

        [Category("DashBoardDetail Properties")]
        public string URL
        {
            get => _url;
            set
            { 
                _url = value;
                this.Refresh();
            }
        }

        [Category("DashBoardDetail Properties")]
        public string DefCnt
        {
            get => _defcnt;
            set
            {
                _defcnt = value;
                mlb_defcntvalue.Text = _defcnt;

                this.Refresh();
            }
        }

        [Category("DashBoardDetail Properties")]
        public string DeathCnt
        {
            get => _deathcnt;
            set
            {
                _deathcnt = value;
                mlb_deathvalue.Text = _deathcnt;

                this.Refresh();
            }
        }


        [Category("DashBoardDetail Properties")]
        public string IsolClear
        {
            get => _isolclear;
            set
            {
                _isolclear = value;
                mlb_isolclearvalue.Text = _isolclear;

                this.Refresh();
            }
        }

        [Category("DashBoardDetail Properties")]
        public string Isoling
        {
            get => _isoling;
            set
            {
                _isoling = value;
                mlb_isoingvalue.Text = _isoling;

                this.Refresh();
            }
        }

        [Category("DashBoardDetail Properties")]
        public string Rate
        {
            get => _rate;
            set
            { 
                _rate = value;
                mlb_ratevalue.Text = _rate;

                this.Refresh();
            }
        }

        #endregion

        #region Constructor
        public DashBoardDetail()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            mlb_defcntvalue.UseCustomForeColor = true;
            mlb_defcntvalue.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Orange);
            mlb_defcntvalue.FontWeight = MetroLabelWeight.Bold;

            mlb_isolclearvalue.UseCustomForeColor = true;
            mlb_isolclearvalue.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Green);
            mlb_isolclearvalue.FontWeight = MetroLabelWeight.Bold;

            mlb_deathvalue.UseCustomForeColor = true;
            mlb_deathvalue.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Red);
            mlb_deathvalue.FontWeight = MetroLabelWeight.Bold;

            mlb_isoingvalue.UseCustomForeColor = true;
            mlb_isoingvalue.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Blue);
            mlb_isoingvalue.FontWeight = MetroLabelWeight.Bold;

            mlb_ratevalue.UseCustomForeColor = true;
            mlb_ratevalue.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Purple);
            mlb_ratevalue.FontWeight = MetroLabelWeight.Bold;
        }

        #endregion

        private void mlk_link_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(URL))
                return;

            Process.Start(URL);
        }
    }
}
