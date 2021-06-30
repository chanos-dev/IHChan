namespace IHChan.UserControl
{
    partial class MetroHome
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mpnl_temp = new MetroFramework.Controls.MetroPanel();
            this.mpnl_main = new MetroFramework.Controls.MetroPanel();
            this.mpnl_right = new MetroFramework.Controls.MetroPanel();
            this.mpnl_oversea = new MetroFramework.Controls.MetroPanel();
            this.mpnl_home = new MetroFramework.Controls.MetroPanel();
            this.db_overseaisoling = new IHChan.UserControl.DashBoard();
            this.db_overseadeath = new IHChan.UserControl.DashBoard();
            this.db_overseaisolclear = new IHChan.UserControl.DashBoard();
            this.mlb_overseas = new MetroFramework.Controls.MetroLabel();
            this.db_overseadef = new IHChan.UserControl.DashBoard();
            this.db_homeisoling = new IHChan.UserControl.DashBoard();
            this.db_homedeath = new IHChan.UserControl.DashBoard();
            this.db_homeisolclear = new IHChan.UserControl.DashBoard();
            this.mlb_homecountry = new MetroFramework.Controls.MetroLabel();
            this.db_homedef = new IHChan.UserControl.DashBoard();
            this.mpnl_left = new MetroFramework.Controls.MetroPanel();
            this.mpnl_vaccine = new MetroFramework.Controls.MetroPanel();
            this.mlb_vaccine = new MetroFramework.Controls.MetroLabel();
            this.mpnl_date = new MetroFramework.Controls.MetroPanel();
            this.mlb_date = new MetroFramework.Controls.MetroLabel();
            this.mpnl_main.SuspendLayout();
            this.mpnl_right.SuspendLayout();
            this.mpnl_left.SuspendLayout();
            this.mpnl_vaccine.SuspendLayout();
            this.mpnl_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnl_temp
            // 
            this.mpnl_temp.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnl_temp.HorizontalScrollbarBarColor = true;
            this.mpnl_temp.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_temp.HorizontalScrollbarSize = 10;
            this.mpnl_temp.Location = new System.Drawing.Point(0, 0);
            this.mpnl_temp.Name = "mpnl_temp";
            this.mpnl_temp.Size = new System.Drawing.Size(1305, 15);
            this.mpnl_temp.TabIndex = 6;
            this.mpnl_temp.VerticalScrollbarBarColor = true;
            this.mpnl_temp.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp.VerticalScrollbarSize = 10;
            // 
            // mpnl_main
            // 
            this.mpnl_main.Controls.Add(this.mpnl_right);
            this.mpnl_main.Controls.Add(this.mpnl_left);
            this.mpnl_main.Controls.Add(this.mpnl_date);
            this.mpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_main.HorizontalScrollbarBarColor = true;
            this.mpnl_main.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_main.HorizontalScrollbarSize = 10;
            this.mpnl_main.Location = new System.Drawing.Point(0, 15);
            this.mpnl_main.Name = "mpnl_main";
            this.mpnl_main.Size = new System.Drawing.Size(1305, 722);
            this.mpnl_main.TabIndex = 7;
            this.mpnl_main.VerticalScrollbarBarColor = true;
            this.mpnl_main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_main.VerticalScrollbarSize = 10;
            // 
            // mpnl_right
            // 
            this.mpnl_right.Controls.Add(this.mpnl_oversea);
            this.mpnl_right.Controls.Add(this.mpnl_home);
            this.mpnl_right.Controls.Add(this.db_overseaisoling);
            this.mpnl_right.Controls.Add(this.db_overseadeath);
            this.mpnl_right.Controls.Add(this.db_overseaisolclear);
            this.mpnl_right.Controls.Add(this.mlb_overseas);
            this.mpnl_right.Controls.Add(this.db_overseadef);
            this.mpnl_right.Controls.Add(this.db_homeisoling);
            this.mpnl_right.Controls.Add(this.db_homedeath);
            this.mpnl_right.Controls.Add(this.db_homeisolclear);
            this.mpnl_right.Controls.Add(this.mlb_homecountry);
            this.mpnl_right.Controls.Add(this.db_homedef);
            this.mpnl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_right.HorizontalScrollbarBarColor = true;
            this.mpnl_right.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_right.HorizontalScrollbarSize = 10;
            this.mpnl_right.Location = new System.Drawing.Point(646, 30);
            this.mpnl_right.Name = "mpnl_right";
            this.mpnl_right.Size = new System.Drawing.Size(659, 692);
            this.mpnl_right.TabIndex = 9;
            this.mpnl_right.VerticalScrollbarBarColor = true;
            this.mpnl_right.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_right.VerticalScrollbarSize = 10;
            // 
            // mpnl_oversea
            // 
            this.mpnl_oversea.BackgroundImage = global::IHChan.Properties.Resources.oversea;
            this.mpnl_oversea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpnl_oversea.HorizontalScrollbarBarColor = true;
            this.mpnl_oversea.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_oversea.HorizontalScrollbarSize = 10;
            this.mpnl_oversea.Location = new System.Drawing.Point(419, 113);
            this.mpnl_oversea.Name = "mpnl_oversea";
            this.mpnl_oversea.Size = new System.Drawing.Size(26, 26);
            this.mpnl_oversea.TabIndex = 17;
            this.mpnl_oversea.VerticalScrollbarBarColor = true;
            this.mpnl_oversea.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_oversea.VerticalScrollbarSize = 10;
            // 
            // mpnl_home
            // 
            this.mpnl_home.BackgroundImage = global::IHChan.Properties.Resources.home;
            this.mpnl_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpnl_home.HorizontalScrollbarBarColor = true;
            this.mpnl_home.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_home.HorizontalScrollbarSize = 10;
            this.mpnl_home.Location = new System.Drawing.Point(101, 113);
            this.mpnl_home.Name = "mpnl_home";
            this.mpnl_home.Size = new System.Drawing.Size(26, 26);
            this.mpnl_home.TabIndex = 16;
            this.mpnl_home.VerticalScrollbarBarColor = true;
            this.mpnl_home.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_home.VerticalScrollbarSize = 10;
            // 
            // db_overseaisoling
            // 
            this.db_overseaisoling.Location = new System.Drawing.Point(374, 423);
            this.db_overseaisoling.Name = "db_overseaisoling";
            this.db_overseaisoling.Size = new System.Drawing.Size(267, 88);
            this.db_overseaisoling.TabIndex = 11;
            this.db_overseaisoling.UseSelectable = true;
            this.db_overseaisoling.Value = "- 명";
            // 
            // db_overseadeath
            // 
            this.db_overseadeath.Location = new System.Drawing.Point(374, 329);
            this.db_overseadeath.Name = "db_overseadeath";
            this.db_overseadeath.Size = new System.Drawing.Size(267, 88);
            this.db_overseadeath.TabIndex = 10;
            this.db_overseadeath.UseSelectable = true;
            this.db_overseadeath.Value = "- 명";
            // 
            // db_overseaisolclear
            // 
            this.db_overseaisolclear.Location = new System.Drawing.Point(374, 235);
            this.db_overseaisolclear.Name = "db_overseaisolclear";
            this.db_overseaisolclear.Size = new System.Drawing.Size(267, 88);
            this.db_overseaisolclear.TabIndex = 9;
            this.db_overseaisolclear.UseSelectable = true;
            this.db_overseaisolclear.Value = "- 명";
            // 
            // mlb_overseas
            // 
            this.mlb_overseas.AutoSize = true;
            this.mlb_overseas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_overseas.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_overseas.Location = new System.Drawing.Point(374, 113);
            this.mlb_overseas.Name = "mlb_overseas";
            this.mlb_overseas.Size = new System.Drawing.Size(48, 25);
            this.mlb_overseas.TabIndex = 8;
            this.mlb_overseas.Text = "해외";
            // 
            // db_overseadef
            // 
            this.db_overseadef.Location = new System.Drawing.Point(374, 141);
            this.db_overseadef.Name = "db_overseadef";
            this.db_overseadef.Size = new System.Drawing.Size(267, 88);
            this.db_overseadef.TabIndex = 7;
            this.db_overseadef.UseSelectable = true;
            this.db_overseadef.Value = "- 명";
            // 
            // db_homeisoling
            // 
            this.db_homeisoling.Location = new System.Drawing.Point(56, 423);
            this.db_homeisoling.Name = "db_homeisoling";
            this.db_homeisoling.Size = new System.Drawing.Size(267, 88);
            this.db_homeisoling.TabIndex = 6;
            this.db_homeisoling.UseSelectable = true;
            this.db_homeisoling.Value = "- 명";
            // 
            // db_homedeath
            // 
            this.db_homedeath.Location = new System.Drawing.Point(56, 329);
            this.db_homedeath.Name = "db_homedeath";
            this.db_homedeath.Size = new System.Drawing.Size(267, 88);
            this.db_homedeath.TabIndex = 5;
            this.db_homedeath.UseSelectable = true;
            this.db_homedeath.Value = "- 명";
            // 
            // db_homeisolclear
            // 
            this.db_homeisolclear.Location = new System.Drawing.Point(56, 235);
            this.db_homeisolclear.Name = "db_homeisolclear";
            this.db_homeisolclear.Size = new System.Drawing.Size(267, 88);
            this.db_homeisolclear.TabIndex = 4;
            this.db_homeisolclear.UseSelectable = true;
            this.db_homeisolclear.Value = "- 명";
            // 
            // mlb_homecountry
            // 
            this.mlb_homecountry.AutoSize = true;
            this.mlb_homecountry.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_homecountry.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_homecountry.Location = new System.Drawing.Point(56, 113);
            this.mlb_homecountry.Name = "mlb_homecountry";
            this.mlb_homecountry.Size = new System.Drawing.Size(48, 25);
            this.mlb_homecountry.TabIndex = 3;
            this.mlb_homecountry.Text = "국내";
            // 
            // db_homedef
            // 
            this.db_homedef.Location = new System.Drawing.Point(56, 141);
            this.db_homedef.Name = "db_homedef";
            this.db_homedef.Size = new System.Drawing.Size(267, 88);
            this.db_homedef.TabIndex = 2;
            this.db_homedef.UseSelectable = true;
            this.db_homedef.Value = "- 명";
            // 
            // mpnl_left
            // 
            this.mpnl_left.Controls.Add(this.mpnl_vaccine);
            this.mpnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpnl_left.HorizontalScrollbarBarColor = true;
            this.mpnl_left.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_left.HorizontalScrollbarSize = 10;
            this.mpnl_left.Location = new System.Drawing.Point(0, 30);
            this.mpnl_left.Name = "mpnl_left";
            this.mpnl_left.Size = new System.Drawing.Size(646, 692);
            this.mpnl_left.TabIndex = 8;
            this.mpnl_left.VerticalScrollbarBarColor = true;
            this.mpnl_left.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_left.VerticalScrollbarSize = 10;
            // 
            // mpnl_vaccine
            // 
            this.mpnl_vaccine.Controls.Add(this.mlb_vaccine);
            this.mpnl_vaccine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mpnl_vaccine.HorizontalScrollbarBarColor = true;
            this.mpnl_vaccine.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_vaccine.HorizontalScrollbarSize = 10;
            this.mpnl_vaccine.Location = new System.Drawing.Point(0, 662);
            this.mpnl_vaccine.Name = "mpnl_vaccine";
            this.mpnl_vaccine.Size = new System.Drawing.Size(646, 30);
            this.mpnl_vaccine.TabIndex = 8;
            this.mpnl_vaccine.VerticalScrollbarBarColor = true;
            this.mpnl_vaccine.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_vaccine.VerticalScrollbarSize = 10;
            // 
            // mlb_vaccine
            // 
            this.mlb_vaccine.AutoSize = true;
            this.mlb_vaccine.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_vaccine.Location = new System.Drawing.Point(3, 2);
            this.mlb_vaccine.Name = "mlb_vaccine";
            this.mlb_vaccine.Size = new System.Drawing.Size(297, 25);
            this.mlb_vaccine.TabIndex = 2;
            this.mlb_vaccine.Text = "국내현황 2021.06.30. 00:00 집계 기준";
            // 
            // mpnl_date
            // 
            this.mpnl_date.Controls.Add(this.mlb_date);
            this.mpnl_date.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnl_date.HorizontalScrollbarBarColor = true;
            this.mpnl_date.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_date.HorizontalScrollbarSize = 10;
            this.mpnl_date.Location = new System.Drawing.Point(0, 0);
            this.mpnl_date.Name = "mpnl_date";
            this.mpnl_date.Size = new System.Drawing.Size(1305, 30);
            this.mpnl_date.TabIndex = 7;
            this.mpnl_date.VerticalScrollbarBarColor = true;
            this.mpnl_date.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_date.VerticalScrollbarSize = 10;
            // 
            // mlb_date
            // 
            this.mlb_date.AutoSize = true;
            this.mlb_date.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_date.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_date.Location = new System.Drawing.Point(3, 2);
            this.mlb_date.Name = "mlb_date";
            this.mlb_date.Size = new System.Drawing.Size(78, 25);
            this.mlb_date.TabIndex = 2;
            this.mlb_date.Text = "Today : ";
            // 
            // MetroHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_main);
            this.Controls.Add(this.mpnl_temp);
            this.Name = "MetroHome";
            this.Size = new System.Drawing.Size(1305, 737);
            this.mpnl_main.ResumeLayout(false);
            this.mpnl_right.ResumeLayout(false);
            this.mpnl_right.PerformLayout();
            this.mpnl_left.ResumeLayout(false);
            this.mpnl_vaccine.ResumeLayout(false);
            this.mpnl_vaccine.PerformLayout();
            this.mpnl_date.ResumeLayout(false);
            this.mpnl_date.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_temp;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private MetroFramework.Controls.MetroPanel mpnl_date;
        private MetroFramework.Controls.MetroLabel mlb_date;
        private MetroFramework.Controls.MetroPanel mpnl_left;
        private MetroFramework.Controls.MetroPanel mpnl_right;
        private MetroFramework.Controls.MetroPanel mpnl_vaccine;
        private MetroFramework.Controls.MetroLabel mlb_vaccine;
        private DashBoard db_homeisoling;
        private DashBoard db_homedeath;
        private DashBoard db_homeisolclear;
        private MetroFramework.Controls.MetroLabel mlb_homecountry;
        private DashBoard db_homedef;
        private DashBoard db_overseaisoling;
        private DashBoard db_overseadeath;
        private DashBoard db_overseaisolclear;
        private MetroFramework.Controls.MetroLabel mlb_overseas;
        private DashBoard db_overseadef;
        private MetroFramework.Controls.MetroPanel mpnl_home;
        private MetroFramework.Controls.MetroPanel mpnl_oversea;
    }
}
