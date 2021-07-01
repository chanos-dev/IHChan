namespace IHChan.UserControl
{
    partial class DashBoardVaccine
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
            this.mlb_title = new MetroFramework.Controls.MetroLabel();
            this.mlb_firstvactitle = new MetroFramework.Controls.MetroLabel();
            this.mlb_secondvactitle = new MetroFramework.Controls.MetroLabel();
            this.mlb_totalrate = new MetroFramework.Controls.MetroLabel();
            this.mlb_secondvac = new MetroFramework.Controls.MetroLabel();
            this.mlb_firstvac = new MetroFramework.Controls.MetroLabel();
            this.mpnl_logo = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mlb_title
            // 
            this.mlb_title.AutoSize = true;
            this.mlb_title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_title.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_title.Location = new System.Drawing.Point(20, 20);
            this.mlb_title.Name = "mlb_title";
            this.mlb_title.Size = new System.Drawing.Size(122, 25);
            this.mlb_title.TabIndex = 14;
            this.mlb_title.Text = "전국 1차 접종";
            // 
            // mlb_firstvactitle
            // 
            this.mlb_firstvactitle.AutoSize = true;
            this.mlb_firstvactitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_firstvactitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_firstvactitle.Location = new System.Drawing.Point(20, 54);
            this.mlb_firstvactitle.Name = "mlb_firstvactitle";
            this.mlb_firstvactitle.Size = new System.Drawing.Size(48, 25);
            this.mlb_firstvactitle.TabIndex = 15;
            this.mlb_firstvactitle.Text = "누적";
            // 
            // mlb_secondvactitle
            // 
            this.mlb_secondvactitle.AutoSize = true;
            this.mlb_secondvactitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_secondvactitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_secondvactitle.Location = new System.Drawing.Point(20, 89);
            this.mlb_secondvactitle.Name = "mlb_secondvactitle";
            this.mlb_secondvactitle.Size = new System.Drawing.Size(48, 25);
            this.mlb_secondvactitle.TabIndex = 16;
            this.mlb_secondvactitle.Text = "신규";
            // 
            // mlb_totalrate
            // 
            this.mlb_totalrate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_totalrate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_totalrate.Location = new System.Drawing.Point(141, 20);
            this.mlb_totalrate.Name = "mlb_totalrate";
            this.mlb_totalrate.Size = new System.Drawing.Size(116, 25);
            this.mlb_totalrate.TabIndex = 18;
            this.mlb_totalrate.Text = "100.0%";
            this.mlb_totalrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlb_secondvac
            // 
            this.mlb_secondvac.AutoSize = true;
            this.mlb_secondvac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_secondvac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_secondvac.Location = new System.Drawing.Point(74, 89);
            this.mlb_secondvac.Name = "mlb_secondvac";
            this.mlb_secondvac.Size = new System.Drawing.Size(42, 25);
            this.mlb_secondvac.TabIndex = 20;
            this.mlb_secondvac.Text = "- 명";
            // 
            // mlb_firstvac
            // 
            this.mlb_firstvac.AutoSize = true;
            this.mlb_firstvac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_firstvac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_firstvac.Location = new System.Drawing.Point(74, 54);
            this.mlb_firstvac.Name = "mlb_firstvac";
            this.mlb_firstvac.Size = new System.Drawing.Size(42, 25);
            this.mlb_firstvac.TabIndex = 19;
            this.mlb_firstvac.Text = "- 명";
            // 
            // mpnl_logo
            // 
            this.mpnl_logo.BackgroundImage = global::IHChan.Properties.Resources.vaccine;
            this.mpnl_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpnl_logo.HorizontalScrollbarBarColor = true;
            this.mpnl_logo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_logo.HorizontalScrollbarSize = 10;
            this.mpnl_logo.Location = new System.Drawing.Point(211, 68);
            this.mpnl_logo.Name = "mpnl_logo";
            this.mpnl_logo.Size = new System.Drawing.Size(46, 46);
            this.mpnl_logo.TabIndex = 17;
            this.mpnl_logo.VerticalScrollbarBarColor = true;
            this.mpnl_logo.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_logo.VerticalScrollbarSize = 10;
            // 
            // DashBoardVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlb_secondvac);
            this.Controls.Add(this.mlb_firstvac);
            this.Controls.Add(this.mlb_totalrate);
            this.Controls.Add(this.mpnl_logo);
            this.Controls.Add(this.mlb_secondvactitle);
            this.Controls.Add(this.mlb_firstvactitle);
            this.Controls.Add(this.mlb_title);
            this.Name = "DashBoardVaccine";
            this.Size = new System.Drawing.Size(295, 137);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlb_title;
        private MetroFramework.Controls.MetroLabel mlb_firstvactitle;
        private MetroFramework.Controls.MetroLabel mlb_secondvactitle;
        private MetroFramework.Controls.MetroPanel mpnl_logo;
        private MetroFramework.Controls.MetroLabel mlb_totalrate;
        private MetroFramework.Controls.MetroLabel mlb_secondvac;
        private MetroFramework.Controls.MetroLabel mlb_firstvac;
    }
}
