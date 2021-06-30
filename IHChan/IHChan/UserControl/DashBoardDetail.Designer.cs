namespace IHChan.UserControl
{
    partial class DashBoardDetail
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
            this.mlb_Title = new MetroFramework.Controls.MetroLabel();
            this.mlk_link = new MetroFramework.Controls.MetroLink();
            this.mlb_defcnt = new MetroFramework.Controls.MetroLabel();
            this.mlb_isolclear = new MetroFramework.Controls.MetroLabel();
            this.mlb_death = new MetroFramework.Controls.MetroLabel();
            this.mlb_isoing = new MetroFramework.Controls.MetroLabel();
            this.mlb_rate = new MetroFramework.Controls.MetroLabel();
            this.mlb_defcntvalue = new MetroFramework.Controls.MetroLabel();
            this.mlb_isolclearvalue = new MetroFramework.Controls.MetroLabel();
            this.mlb_deathvalue = new MetroFramework.Controls.MetroLabel();
            this.mlb_isoingvalue = new MetroFramework.Controls.MetroLabel();
            this.mlb_ratevalue = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlb_Title
            // 
            this.mlb_Title.AutoSize = true;
            this.mlb_Title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_Title.Location = new System.Drawing.Point(20, 20);
            this.mlb_Title.Name = "mlb_Title";
            this.mlb_Title.Size = new System.Drawing.Size(48, 25);
            this.mlb_Title.TabIndex = 0;
            this.mlb_Title.Text = "합계";
            // 
            // mlk_link
            // 
            this.mlk_link.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mlk_link.Location = new System.Drawing.Point(74, 20);
            this.mlk_link.Name = "mlk_link";
            this.mlk_link.Size = new System.Drawing.Size(124, 25);
            this.mlk_link.TabIndex = 1;
            this.mlk_link.Text = "(정보사이트)";
            this.mlk_link.UseSelectable = true;
            this.mlk_link.Click += new System.EventHandler(this.mlk_link_Click);
            // 
            // mlb_defcnt
            // 
            this.mlb_defcnt.AutoSize = true;
            this.mlb_defcnt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_defcnt.Location = new System.Drawing.Point(20, 50);
            this.mlb_defcnt.Name = "mlb_defcnt";
            this.mlb_defcnt.Size = new System.Drawing.Size(75, 25);
            this.mlb_defcnt.Style = MetroFramework.MetroColorStyle.Green;
            this.mlb_defcnt.TabIndex = 2;
            this.mlb_defcnt.Text = "확진자 :";
            // 
            // mlb_isolclear
            // 
            this.mlb_isolclear.AutoSize = true;
            this.mlb_isolclear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_isolclear.Location = new System.Drawing.Point(20, 80);
            this.mlb_isolclear.Name = "mlb_isolclear";
            this.mlb_isolclear.Size = new System.Drawing.Size(93, 25);
            this.mlb_isolclear.TabIndex = 3;
            this.mlb_isolclear.Text = "격리해제 :";
            // 
            // mlb_death
            // 
            this.mlb_death.AutoSize = true;
            this.mlb_death.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_death.Location = new System.Drawing.Point(20, 110);
            this.mlb_death.Name = "mlb_death";
            this.mlb_death.Size = new System.Drawing.Size(80, 25);
            this.mlb_death.TabIndex = 4;
            this.mlb_death.Text = "사망자 : ";
            // 
            // mlb_isoing
            // 
            this.mlb_isoing.AutoSize = true;
            this.mlb_isoing.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_isoing.Location = new System.Drawing.Point(20, 140);
            this.mlb_isoing.Name = "mlb_isoing";
            this.mlb_isoing.Size = new System.Drawing.Size(85, 25);
            this.mlb_isoing.TabIndex = 5;
            this.mlb_isoing.Text = "격리 중 : ";
            // 
            // mlb_rate
            // 
            this.mlb_rate.AutoSize = true;
            this.mlb_rate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_rate.Location = new System.Drawing.Point(20, 170);
            this.mlb_rate.Name = "mlb_rate";
            this.mlb_rate.Size = new System.Drawing.Size(80, 25);
            this.mlb_rate.TabIndex = 6;
            this.mlb_rate.Text = "발생률 : ";
            // 
            // mlb_defcntvalue
            // 
            this.mlb_defcntvalue.AutoSize = true;
            this.mlb_defcntvalue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_defcntvalue.Location = new System.Drawing.Point(101, 50);
            this.mlb_defcntvalue.Name = "mlb_defcntvalue";
            this.mlb_defcntvalue.Size = new System.Drawing.Size(19, 25);
            this.mlb_defcntvalue.TabIndex = 7;
            this.mlb_defcntvalue.Text = "-";
            // 
            // mlb_isolclearvalue
            // 
            this.mlb_isolclearvalue.AutoSize = true;
            this.mlb_isolclearvalue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_isolclearvalue.Location = new System.Drawing.Point(119, 80);
            this.mlb_isolclearvalue.Name = "mlb_isolclearvalue";
            this.mlb_isolclearvalue.Size = new System.Drawing.Size(19, 25);
            this.mlb_isolclearvalue.TabIndex = 8;
            this.mlb_isolclearvalue.Text = "-";
            // 
            // mlb_deathvalue
            // 
            this.mlb_deathvalue.AutoSize = true;
            this.mlb_deathvalue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_deathvalue.Location = new System.Drawing.Point(106, 110);
            this.mlb_deathvalue.Name = "mlb_deathvalue";
            this.mlb_deathvalue.Size = new System.Drawing.Size(19, 25);
            this.mlb_deathvalue.TabIndex = 9;
            this.mlb_deathvalue.Text = "-";
            // 
            // mlb_isoingvalue
            // 
            this.mlb_isoingvalue.AutoSize = true;
            this.mlb_isoingvalue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_isoingvalue.Location = new System.Drawing.Point(111, 140);
            this.mlb_isoingvalue.Name = "mlb_isoingvalue";
            this.mlb_isoingvalue.Size = new System.Drawing.Size(19, 25);
            this.mlb_isoingvalue.TabIndex = 10;
            this.mlb_isoingvalue.Text = "-";
            // 
            // mlb_ratevalue
            // 
            this.mlb_ratevalue.AutoSize = true;
            this.mlb_ratevalue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_ratevalue.Location = new System.Drawing.Point(106, 170);
            this.mlb_ratevalue.Name = "mlb_ratevalue";
            this.mlb_ratevalue.Size = new System.Drawing.Size(19, 25);
            this.mlb_ratevalue.TabIndex = 11;
            this.mlb_ratevalue.Text = "-";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlb_ratevalue);
            this.Controls.Add(this.mlb_isoingvalue);
            this.Controls.Add(this.mlb_deathvalue);
            this.Controls.Add(this.mlb_isolclearvalue);
            this.Controls.Add(this.mlb_defcntvalue);
            this.Controls.Add(this.mlb_rate);
            this.Controls.Add(this.mlb_isoing);
            this.Controls.Add(this.mlb_death);
            this.Controls.Add(this.mlb_isolclear);
            this.Controls.Add(this.mlb_defcnt);
            this.Controls.Add(this.mlk_link);
            this.Controls.Add(this.mlb_Title);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(292, 214);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlb_Title;
        private MetroFramework.Controls.MetroLink mlk_link;
        private MetroFramework.Controls.MetroLabel mlb_defcnt;
        private MetroFramework.Controls.MetroLabel mlb_isolclear;
        private MetroFramework.Controls.MetroLabel mlb_death;
        private MetroFramework.Controls.MetroLabel mlb_isoing;
        private MetroFramework.Controls.MetroLabel mlb_rate;
        private MetroFramework.Controls.MetroLabel mlb_defcntvalue;
        private MetroFramework.Controls.MetroLabel mlb_isolclearvalue;
        private MetroFramework.Controls.MetroLabel mlb_deathvalue;
        private MetroFramework.Controls.MetroLabel mlb_isoingvalue;
        private MetroFramework.Controls.MetroLabel mlb_ratevalue;
    }
}
