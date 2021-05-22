using IHChan.Interface;
using MetroFramework;
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

        protected List<IMetroControl> DirectControls { get; set; }

        private MetroThemeStyle _baseThemeStyle;
        public MetroThemeStyle BaseThemeStyle
        {
            get => _baseThemeStyle;
            set
            {
                Manager.Theme = value;
                DirectSet();
            }
        }

        private MetroColorStyle _baseColorStyle;
        public MetroColorStyle BaseColorStyle
        {
            get => _baseColorStyle;
            set
            {
                Manager.Style = value;
                DirectSet();
            }
        }


        public MetroStyleManager Manager { get; set; }

        protected BaseMetroUserControl()
        {
            MetroControls = new List<IMetroControl>();            
        }

        public void Set()
        {
            foreach(var control in MetroControls)
            {
                control.UseSelectable = false; 
                control.StyleManager = Manager; 
            }
        }

        public void DirectSet()
        {
            if (DirectControls is null)
                return; 

            foreach(var control in DirectControls)
            {
                control.Theme = Manager.Theme;
                control.Style = Manager.Style;
            }
        }

        protected void InitializeBaseControl(Control parent)
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
                    MetroControls.Add(metro);
                }

                SettingMetroControl(control);
            }
        }
    }
}
