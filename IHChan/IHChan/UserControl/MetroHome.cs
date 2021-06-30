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

namespace IHChan.UserControl
{
    internal partial class MetroHome : BaseMetroUserControl
    {
        public MetroHome() : base()
        {
            InitializeComponent();
            InitializeBaseControl(this);
            InitializeControl();
        }

        private void InitializeControl()
        {
            this.mlb_date.Text = $"Today : {DateTime.Now:d}";
        }
    }
}
