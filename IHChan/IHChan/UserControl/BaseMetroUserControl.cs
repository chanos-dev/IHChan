using IHChan.Interface;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHChan.UserControl
{
    internal class BaseMetroUserControl : MetroUserControl, ISetting
    {
        protected List<IMetroControl> MetroControls { get; set; }

        public MetroStyleManager Manager { get; set; }

        protected BaseMetroUserControl()
        {
            MetroControls = new List<IMetroControl>();
        }

        public void Set()
        {
            foreach(var control in MetroControls)
            {
                control.StyleManager = Manager;
            }
        }

        protected void InitializeControl(Control parent)
        {
            if (parent is IMetroControl metro)
            {                
                MetroControls.Add(metro);
                SettingMetroControl(parent);
            }
        }

        private void SettingMetroControl(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is IMetroControl metro)
                {
                    metro.UseSelectable = false;
                    MetroControls.Add(metro);
                }

                SettingMetroControl(control);
            }
        }
    }
}
