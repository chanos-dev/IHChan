using IHChan.APIs;
using IHChan.Options;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDLChan
{
    public partial class frm_Main : MetroForm
    {       
        public frm_Main()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            this.StyleManager = ms_Manager;
            ms_Manager.Owner = this;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var covid = new CovidAPI();
            //covid.Get1();

            ms_Manager.Theme = Option.Instance.GetStringToEnumValue<MetroThemeStyle>(Option.Instance.ThemeStyle);
            ms_Manager.Style = Option.Instance.GetStringToEnumValue<MetroColorStyle>(Option.Instance.ColorStyle);
        }
    }
}
