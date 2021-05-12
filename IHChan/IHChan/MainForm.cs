using IHChan.APIs;
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

            ms_Manager.Theme = MetroFramework.MetroThemeStyle.Dark;
            ms_Manager.Style = MetroFramework.MetroColorStyle.Orange;
        }
    }
}
