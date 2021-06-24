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

namespace IHChan.UserControl
{
    internal partial class MetroHomeCountry : BaseMetroUserControl
    {
        private mfrm_main Main { get; set; }

        public MetroHomeCountry(mfrm_main main)
        {
            this.Main = main;
            this.Main.NoramlControlColorSetHandler += InitializeGraph;

            InitializeComponent();
            InitializeBaseControl(this);
            InitializeGraph();
        }

        private void InitializeGraph()
        {
            ChangeGraghColor(cg_def);
            ChangeGraghColor(cg_death);
            ChangeGraghColor(cg_isollng);
            ChangeGraghColor(cg_isolclear);
        }

        private void ChangeGraghColor(CircleGraph graph)
        {
            graph.TextColor = ColorSet.GetMetroColorToSystemColor(Main.Style);
            graph.ForeCircleColor = ColorSet.GetMetroColorToSystemColor(Main.Style);
        }
    }
}
