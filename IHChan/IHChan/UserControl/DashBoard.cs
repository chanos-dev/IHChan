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
using IHChan.Environment;
using MetroFramework;

namespace IHChan.UserControl
{
    internal partial class DashBoard : MetroUserControl
    {
        #region Fields

        private string _value = "- 명";

        private string _title = "타이틀";

        #endregion

        #region Properties

        [Category("DashBoard Properties")]
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                mlb_value.Text = value;
                this.Refresh();
            }
        }

        [Category("DashBoard Properties")]
        public string Title
        {
            get => _title;
            //set
            //{
            //    _title = value;
            //    mlb_title.Text = _title;
            //    this.Refresh();
            //}
        }

        [Category("DashBoard Properties")]
        public CovidType Type
        {
            set
            {
                _title = value.ToString();

                InitializeControl(value);

                mlb_title.Text = _title;
                this.Refresh();
            }
        }

        #endregion

        #region Constructor
        public DashBoard()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void InitializeControl(CovidType type)
        {
            mpnl_logo.BackgroundImage?.Dispose();
            mpnl_logo.BackgroundImage = null;

            switch (type)
            {
                case CovidType.DefCnt:
                    mlb_value.UseCustomForeColor = true;
                    mlb_value.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Orange);

                    // set image                    
                    mpnl_logo.BackgroundImage = Properties.Resources.mankinds;
                    break;
                case CovidType.IsolClear:
                    mlb_value.UseCustomForeColor = true;
                    mlb_value.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Green);

                    // set image                    
                    mpnl_logo.BackgroundImage = Properties.Resources.shield;
                    break;
                case CovidType.Death:
                    mlb_value.UseCustomForeColor = true;
                    mlb_value.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Red);

                    // set image                    
                    mpnl_logo.BackgroundImage = Properties.Resources.rip;
                    break;
                case CovidType.IsolIng:
                    mlb_value.UseCustomForeColor = true;
                    mlb_value.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Blue);

                    // set image                    
                    mpnl_logo.BackgroundImage = Properties.Resources.cure;
                    break;
            }
        }
    #endregion
    }
}
