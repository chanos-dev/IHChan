namespace IHChan.UserControl
{
    partial class MetroHomeCountry
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
            this.mpnl_bottom = new MetroFramework.Controls.MetroPanel();
            this.db_location = new IHChan.UserControl.DashBoard();
            this.db_total = new IHChan.UserControl.DashBoard();
            this.mcb_location = new MetroFramework.Controls.MetroComboBox();
            this.mlb_location = new MetroFramework.Controls.MetroLabel();
            this.mlb_isolclearcnt = new MetroFramework.Controls.MetroLabel();
            this.mlb_isollngcnt = new MetroFramework.Controls.MetroLabel();
            this.mlb_deathcnt = new MetroFramework.Controls.MetroLabel();
            this.mlb_defcnt = new MetroFramework.Controls.MetroLabel();
            this.cg_isolclear = new IHChan.UserControl.CircleGraph();
            this.cg_death = new IHChan.UserControl.CircleGraph();
            this.cg_isollng = new IHChan.UserControl.CircleGraph();
            this.mdt_date = new MetroFramework.Controls.MetroDateTime();
            this.cg_def = new IHChan.UserControl.CircleGraph();
            this.mpnl_main.SuspendLayout();
            this.mpnl_bottom.SuspendLayout();
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
            this.mpnl_main.Controls.Add(this.mpnl_bottom);
            this.mpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_main.HorizontalScrollbarBarColor = true;
            this.mpnl_main.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_main.HorizontalScrollbarSize = 10;
            this.mpnl_main.Location = new System.Drawing.Point(0, 15);
            this.mpnl_main.Name = "mpnl_main";
            this.mpnl_main.Size = new System.Drawing.Size(1305, 722);
            this.mpnl_main.TabIndex = 8;
            this.mpnl_main.VerticalScrollbarBarColor = true;
            this.mpnl_main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_main.VerticalScrollbarSize = 10;
            // 
            // mpnl_bottom
            // 
            this.mpnl_bottom.Controls.Add(this.db_location);
            this.mpnl_bottom.Controls.Add(this.db_total);
            this.mpnl_bottom.Controls.Add(this.mcb_location);
            this.mpnl_bottom.Controls.Add(this.mlb_location);
            this.mpnl_bottom.Controls.Add(this.mlb_isolclearcnt);
            this.mpnl_bottom.Controls.Add(this.mlb_isollngcnt);
            this.mpnl_bottom.Controls.Add(this.mlb_deathcnt);
            this.mpnl_bottom.Controls.Add(this.mlb_defcnt);
            this.mpnl_bottom.Controls.Add(this.cg_isolclear);
            this.mpnl_bottom.Controls.Add(this.cg_death);
            this.mpnl_bottom.Controls.Add(this.cg_isollng);
            this.mpnl_bottom.Controls.Add(this.mdt_date);
            this.mpnl_bottom.Controls.Add(this.cg_def);
            this.mpnl_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_bottom.HorizontalScrollbarBarColor = true;
            this.mpnl_bottom.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_bottom.HorizontalScrollbarSize = 10;
            this.mpnl_bottom.Location = new System.Drawing.Point(0, 0);
            this.mpnl_bottom.Name = "mpnl_bottom";
            this.mpnl_bottom.Size = new System.Drawing.Size(1305, 722);
            this.mpnl_bottom.TabIndex = 2;
            this.mpnl_bottom.VerticalScrollbarBarColor = true;
            this.mpnl_bottom.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_bottom.VerticalScrollbarSize = 10;
            // 
            // db_location
            // 
            this.db_location.DeathCnt = "-";
            this.db_location.DefCnt = "-";
            this.db_location.IsolClear = "-";
            this.db_location.Isoling = "-";
            this.db_location.Location = new System.Drawing.Point(682, 458);
            this.db_location.Name = "db_location";
            this.db_location.Rate = "-";
            this.db_location.Size = new System.Drawing.Size(292, 214);
            this.db_location.TabIndex = 20;
            this.db_location.Title = "합계";
            this.db_location.URL = null;
            this.db_location.UseSelectable = true;
            // 
            // db_total
            // 
            this.db_total.DeathCnt = "-";
            this.db_total.DefCnt = "-";
            this.db_total.IsolClear = "-";
            this.db_total.Isoling = "-";
            this.db_total.Location = new System.Drawing.Point(62, 458);
            this.db_total.Name = "db_total";
            this.db_total.Rate = "-";
            this.db_total.Size = new System.Drawing.Size(292, 214);
            this.db_total.TabIndex = 19;
            this.db_total.Title = "합계";
            this.db_total.URL = null;
            this.db_total.UseSelectable = true;
            // 
            // mcb_location
            // 
            this.mcb_location.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcb_location.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.mcb_location.FormattingEnabled = true;
            this.mcb_location.ItemHeight = 29;
            this.mcb_location.Location = new System.Drawing.Point(1067, 0);
            this.mcb_location.Name = "mcb_location";
            this.mcb_location.Size = new System.Drawing.Size(238, 35);
            this.mcb_location.TabIndex = 18;
            this.mcb_location.UseSelectable = true;
            this.mcb_location.SelectedIndexChanged += new System.EventHandler(this.mcb_location_SelectedIndexChanged);
            // 
            // mlb_location
            // 
            this.mlb_location.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_location.Location = new System.Drawing.Point(1009, 6);
            this.mlb_location.Name = "mlb_location";
            this.mlb_location.Size = new System.Drawing.Size(55, 23);
            this.mlb_location.TabIndex = 17;
            this.mlb_location.Text = "지역";
            this.mlb_location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlb_isolclearcnt
            // 
            this.mlb_isolclearcnt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_isolclearcnt.Location = new System.Drawing.Point(372, 78);
            this.mlb_isolclearcnt.Name = "mlb_isolclearcnt";
            this.mlb_isolclearcnt.Size = new System.Drawing.Size(250, 23);
            this.mlb_isolclearcnt.TabIndex = 16;
            this.mlb_isolclearcnt.Text = "격리 해제 수";
            this.mlb_isolclearcnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlb_isollngcnt
            // 
            this.mlb_isollngcnt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_isollngcnt.Location = new System.Drawing.Point(992, 78);
            this.mlb_isollngcnt.Name = "mlb_isollngcnt";
            this.mlb_isollngcnt.Size = new System.Drawing.Size(250, 23);
            this.mlb_isollngcnt.TabIndex = 15;
            this.mlb_isollngcnt.Text = "격리 중 환자 수";
            this.mlb_isollngcnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlb_deathcnt
            // 
            this.mlb_deathcnt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_deathcnt.Location = new System.Drawing.Point(682, 78);
            this.mlb_deathcnt.Name = "mlb_deathcnt";
            this.mlb_deathcnt.Size = new System.Drawing.Size(250, 23);
            this.mlb_deathcnt.TabIndex = 14;
            this.mlb_deathcnt.Text = "사망자 수";
            this.mlb_deathcnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlb_defcnt
            // 
            this.mlb_defcnt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_defcnt.Location = new System.Drawing.Point(62, 78);
            this.mlb_defcnt.Name = "mlb_defcnt";
            this.mlb_defcnt.Size = new System.Drawing.Size(250, 23);
            this.mlb_defcnt.TabIndex = 13;
            this.mlb_defcnt.Text = "확진자 수";
            this.mlb_defcnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cg_isolclear
            // 
            this.cg_isolclear.Alignment = System.Drawing.StringAlignment.Center;
            this.cg_isolclear.BackCircleColor = System.Drawing.Color.Gray;
            this.cg_isolclear.CirCleText = "";
            this.cg_isolclear.CircleTextIn = "-";
            this.cg_isolclear.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.cg_isolclear.ForeCircleColor = System.Drawing.Color.Green;
            this.cg_isolclear.HalfCircle = false;
            this.cg_isolclear.InCircleRate = 0.8D;
            this.cg_isolclear.Location = new System.Drawing.Point(372, 113);
            this.cg_isolclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cg_isolclear.MaxValue = 100;
            this.cg_isolclear.Name = "cg_isolclear";
            this.cg_isolclear.Size = new System.Drawing.Size(250, 250);
            this.cg_isolclear.TabIndex = 12;
            this.cg_isolclear.TextColor = System.Drawing.Color.Black;
            this.cg_isolclear.UseSelectable = true;
            this.cg_isolclear.Value = 0;
            // 
            // cg_death
            // 
            this.cg_death.Alignment = System.Drawing.StringAlignment.Center;
            this.cg_death.BackCircleColor = System.Drawing.Color.Gray;
            this.cg_death.CirCleText = "";
            this.cg_death.CircleTextIn = "-";
            this.cg_death.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.cg_death.ForeCircleColor = System.Drawing.Color.Green;
            this.cg_death.HalfCircle = false;
            this.cg_death.InCircleRate = 0.8D;
            this.cg_death.Location = new System.Drawing.Point(682, 113);
            this.cg_death.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cg_death.MaxValue = 100;
            this.cg_death.Name = "cg_death";
            this.cg_death.Size = new System.Drawing.Size(250, 250);
            this.cg_death.TabIndex = 11;
            this.cg_death.TextColor = System.Drawing.Color.Black;
            this.cg_death.UseSelectable = true;
            this.cg_death.Value = 0;
            // 
            // cg_isollng
            // 
            this.cg_isollng.Alignment = System.Drawing.StringAlignment.Center;
            this.cg_isollng.BackCircleColor = System.Drawing.Color.Gray;
            this.cg_isollng.CirCleText = "";
            this.cg_isollng.CircleTextIn = "-";
            this.cg_isollng.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.cg_isollng.ForeCircleColor = System.Drawing.Color.Green;
            this.cg_isollng.HalfCircle = false;
            this.cg_isollng.InCircleRate = 0.8D;
            this.cg_isollng.Location = new System.Drawing.Point(992, 113);
            this.cg_isollng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cg_isollng.MaxValue = 100;
            this.cg_isollng.Name = "cg_isollng";
            this.cg_isollng.Size = new System.Drawing.Size(250, 250);
            this.cg_isollng.TabIndex = 10;
            this.cg_isollng.TextColor = System.Drawing.Color.Black;
            this.cg_isollng.UseSelectable = true;
            this.cg_isollng.Value = 0;
            // 
            // mdt_date
            // 
            this.mdt_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.mdt_date.Location = new System.Drawing.Point(0, 0);
            this.mdt_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdt_date.Name = "mdt_date";
            this.mdt_date.Size = new System.Drawing.Size(241, 29);
            this.mdt_date.TabIndex = 9;
            this.mdt_date.ValueChanged += new System.EventHandler(this.mdt_date_ValueChanged);
            // 
            // cg_def
            // 
            this.cg_def.Alignment = System.Drawing.StringAlignment.Center;
            this.cg_def.BackCircleColor = System.Drawing.Color.Gray;
            this.cg_def.CirCleText = "";
            this.cg_def.CircleTextIn = "-";
            this.cg_def.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.cg_def.ForeCircleColor = System.Drawing.Color.Green;
            this.cg_def.HalfCircle = false;
            this.cg_def.InCircleRate = 0.8D;
            this.cg_def.Location = new System.Drawing.Point(62, 113);
            this.cg_def.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cg_def.MaxValue = 100;
            this.cg_def.Name = "cg_def";
            this.cg_def.Size = new System.Drawing.Size(250, 250);
            this.cg_def.TabIndex = 2;
            this.cg_def.TextColor = System.Drawing.Color.Black;
            this.cg_def.UseSelectable = true;
            this.cg_def.Value = 0;
            // 
            // MetroHomeCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_main);
            this.Controls.Add(this.mpnl_temp);
            this.Name = "MetroHomeCountry";
            this.Size = new System.Drawing.Size(1305, 737);
            this.mpnl_main.ResumeLayout(false);
            this.mpnl_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel mpnl_temp;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private MetroFramework.Controls.MetroPanel mpnl_bottom;
        private CircleGraph cg_def;
        private MetroFramework.Controls.MetroDateTime mdt_date;
        private CircleGraph cg_isollng;
        private CircleGraph cg_isolclear;
        private CircleGraph cg_death;
        private MetroFramework.Controls.MetroLabel mlb_deathcnt;
        private MetroFramework.Controls.MetroLabel mlb_defcnt;
        private MetroFramework.Controls.MetroLabel mlb_isolclearcnt;
        private MetroFramework.Controls.MetroLabel mlb_isollngcnt;
        private MetroFramework.Controls.MetroComboBox mcb_location;
        private MetroFramework.Controls.MetroLabel mlb_location;
        private DashBoard db_location;
        private DashBoard db_total;
    }
}
