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
using IHChan.Attributes;
using System.Reflection;
using MetroFramework;

namespace IHChan.UserControl
{
    public partial class DashBoardVaccine : MetroUserControl
    {
        #region Fields

        private string _title = "접종";

        private string _firstVaccine = "- 명";

        private string _secondVaccine = "- 명";

        private string _rate = "0.0%";

        #endregion

        #region Properties
        [Category("DashBoard Properties")]
        public string Title
        {
            get => _title;
        }


        [Category("DashBoard Properties")]
        public VaccineType Type
        {
            set
            {
                _title = value.ToString();

                InitializeControl(value);

                mlb_title.Text = _title;
                this.Refresh();
            }
        }

        [Category("DashBoard Properties")]
        public string FirstValue
        {
            get => _firstVaccine;
            set
            {
                _firstVaccine = value;
                mlb_firstvac.Text = value;
                this.Refresh();
            }
        }

        [Category("DashBoard Properties")]
        public string SecondValue
        {
            get => _secondVaccine;
            set
            {
                _secondVaccine = value;
                mlb_secondvac.Text = value;
                this.Refresh();
            }
        }

        [Category("DashBoard Properties")]
        public string Rate
        {
            get => _rate;
            set
            {
                _rate = value;
                mlb_totalrate.Text = value;
                this.Refresh();
            }
        }

        #endregion

        #region Constructor
        public DashBoardVaccine()
        {
            InitializeComponent();
            InitializeLabel();
        }

        private void InitializeLabel()
        {
            var labels = new[] { mlb_firstvactitle, mlb_firstvac, mlb_secondvactitle, mlb_secondvac, mlb_totalrate };

            foreach (var label in labels)
            {
                label.UseCustomForeColor = true;
                label.ForeColor = Color.Gray;
            }

            mlb_totalrate.ForeColor = ColorSet.GetMetroColorToSystemColor(MetroColorStyle.Blue);
        }

        private void InitializeControl(VaccineType type)
        {
            mpnl_logo.BackgroundImage?.Dispose();
            mpnl_logo.BackgroundImage = null; 

            string title = string.Empty;

            if (type.HasFlag(VaccineType.All))
            {
                var allAttr = typeof(VaccineType).GetMember(VaccineType.All.ToString()).FirstOrDefault().GetCustomAttribute<PropertyKRNameAttribute>();

                if (allAttr != null)
                    title += $"{allAttr.Name} ";

                type ^= VaccineType.All;
            }

            // set image
            switch (type)
            {
                case VaccineType.First:
                    mpnl_logo.BackgroundImage = Properties.Resources.vaccine;
                    break;
                case VaccineType.Second:
                    mpnl_logo.BackgroundImage = Properties.Resources.vaccine2;
                    break;
            }

            var attr = typeof(VaccineType).GetMember(type.ToString()).FirstOrDefault().GetCustomAttribute<PropertyKRNameAttribute>();

            if (attr != null)
                title += attr.Name;

            _title = title;
        }
        #endregion
    }
}
