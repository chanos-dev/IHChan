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
using MetroFramework;
using IHChan.Options;

namespace IHChan.UserControl
{
    internal partial class MetroSetting : BaseMetroUserControl
    { 
        public MetroSetting()
        {
            InitializeComponent();
            InitializeControl(this);
            InitializeComboboxTheme();
            InitializeComboboxColor();
        }

        private void InitializeComboboxColor()
        {
            mcb_color.Items.Clear();

            string[] colorStyles = new[] {
                nameof(MetroColorStyle.Black),
                nameof(MetroColorStyle.White),
                nameof(MetroColorStyle.Silver),
                nameof(MetroColorStyle.Blue),
                nameof(MetroColorStyle.Green),
                nameof(MetroColorStyle.Lime),
                nameof(MetroColorStyle.Teal),
                nameof(MetroColorStyle.Orange),
                nameof(MetroColorStyle.Brown),
                nameof(MetroColorStyle.Pink),
                nameof(MetroColorStyle.Magenta),
                nameof(MetroColorStyle.Purple),
                nameof(MetroColorStyle.Red),
                nameof(MetroColorStyle.Yellow),
            }; 

            mcb_color.Items.AddRange(colorStyles);

            mcb_color.SelectedItem = Option.Instance.ColorStyle;
        }

        private void InitializeComboboxTheme()
        {
            mcb_theme.Items.Clear();

            string[] themeStyles = new[] { nameof(MetroThemeStyle.Light), nameof(MetroThemeStyle.Dark) };

            mcb_theme.Items.AddRange(themeStyles);

            mcb_theme.SelectedItem = Option.Instance.ThemeStyle;
        }

        private void mcb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Manager is null)
                return;

            Manager.Theme = (MetroThemeStyle)mcb_theme.SelectedIndex+1;            
        } 

        private void mcb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Manager is null)
                return;

            Manager.Style = (MetroColorStyle)mcb_color.SelectedIndex + 1;
        }

        private void mbtn_OK_Click(object sender, EventArgs e)
        {
            Option.Instance.ThemeStyle = mcb_theme.Text;
            Option.Instance.ColorStyle = mcb_color.Text;            
        }

        private void mbtn_cancel_Click(object sender, EventArgs e)
        {
            Manager.Theme = Option.Instance.GetStringToEnumValue<MetroThemeStyle>(Option.Instance.ThemeStyle);
            Manager.Style = Option.Instance.GetStringToEnumValue<MetroColorStyle>(Option.Instance.ColorStyle);

            mcb_theme.Text = Option.Instance.ThemeStyle;
            mcb_color.Text = Option.Instance.ColorStyle;
        }

        public void Cancel() => mbtn_cancel_Click(mbtn_cancel, null);
    }
}
