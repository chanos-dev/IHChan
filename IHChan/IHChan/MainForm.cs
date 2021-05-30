using IHChan.APIs;
using IHChan.Interface;
using IHChan.Options;
using IHChan.UserControl;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
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
    public partial class mfrm_main : MetroForm, IRefresh
    {
        /// <summary>
        /// 홈
        /// </summary>
        private MetroHome MetroHome { get; set; }

        /// <summary>
        /// 국내
        /// </summary>
        private MetroHomeCountry MetroHomeCountry { get; set; }

        /// <summary>
        /// 해외
        /// </summary>
        private MetroOverseas MetroOverseas { get; set; }

        /// <summary>
        /// 설정
        /// </summary>
        private MetroSetting MetroSetting { get; set; }

        private UserControlType CurrentType { get; set; }

        public delegate void NoramlControlColorSet();
        public event NoramlControlColorSet NoramlControlColorSetHandler;

        public mfrm_main()
        {
            InitializeComponent();
            InitializeControl();
            InitializeUserControl();
        }

        private void InitializeUserControl()
        { 
            MetroHome = new MetroHome();

            MetroHomeCountry = new MetroHomeCountry();

            MetroOverseas = new MetroOverseas(this);

            MetroSetting = new MetroSetting();

            Option.Instance.UnitForms.AddRange(new ISetting[] { MetroHome, MetroHomeCountry, MetroOverseas, MetroSetting }); 

            foreach(var form in Option.Instance.UnitForms)
            {
                form.Manager = ms_Manager;
                form.Set();
                form.DirectSet(); 
            }
        }

        public void StyleRefresh()
        {
            ms_Manager.Theme = Option.Instance.GetStringToEnumValue<MetroThemeStyle>(Option.Instance.ThemeStyle);
            ms_Manager.Style = Option.Instance.GetStringToEnumValue<MetroColorStyle>(Option.Instance.ColorStyle);

            NoramlControlColorSetHandler?.Invoke();
        }

        private void InitializeControl()
        {
            mtile_home.UseSelectable = false;
            mtile_homecountry.UseSelectable = false;
            mtile_overseas.UseSelectable = false;
            mtile_setting.UseSelectable = false; 

            // max버튼 비활성화 
            this.MaximizeBox = false;

            this.StyleManager = ms_Manager;
            ms_Manager.Owner = this;

            Option.Instance.Forms.Add(this); 

            // 최초 실행
            StyleRefresh();

            // default
            ChangeUserControl(UserControlType.Home);
        } 

        private void ChangeUserControl(UserControlType type)
        {
            CurrentType = type;

            mpnl_main.Controls.Clear();

            switch(type)
            {
                case UserControlType.Home:
                    mpnl_main.Controls.Add(MetroHome);
                    break;
                case UserControlType.HomeCountry:
                    mpnl_main.Controls.Add(MetroHomeCountry);
                    break;
                case UserControlType.Overseas:
                    mpnl_main.Controls.Add(MetroOverseas);
                    break;
                case UserControlType.Setting:
                    mpnl_main.Controls.Add(MetroSetting);
                    break;
            }
        }

        private void MoveStick(int x) => mtile_stick.Location = new Point(x, mtile_stick.Location.Y);

        private void mtile_Click(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                // 설정창에서 벗어날 때
                if (CurrentType == UserControlType.Setting &&
                    control.Name != nameof(mtile_setting))
                MetroSetting.Cancel();

                switch(control.Name)
                {
                    case nameof(mtile_home):
                        ChangeUserControl(UserControlType.Home);                        
                        break;
                    case nameof(mtile_homecountry):
                        ChangeUserControl(UserControlType.HomeCountry);
                        break;
                    case nameof(mtile_overseas):
                        ChangeUserControl(UserControlType.Overseas);
                        break;
                    case nameof(mtile_setting):
                        ChangeUserControl(UserControlType.Setting);
                        break;
                }

                MoveStick(control.Location.X);
            }
        } 
    }
}
