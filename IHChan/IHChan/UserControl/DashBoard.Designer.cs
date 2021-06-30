namespace IHChan.UserControl
{
    partial class DashBoard
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
            this.mlb_value = new MetroFramework.Controls.MetroLabel();
            this.mlb_title = new MetroFramework.Controls.MetroLabel();
            this.mpnl_logo = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mlb_value
            // 
            this.mlb_value.AutoSize = true;
            this.mlb_value.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_value.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_value.Location = new System.Drawing.Point(20, 20);
            this.mlb_value.Name = "mlb_value";
            this.mlb_value.Size = new System.Drawing.Size(95, 25);
            this.mlb_value.TabIndex = 13;
            this.mlb_value.Text = "COVID-19";
            // 
            // mlb_title
            // 
            this.mlb_title.AutoSize = true;
            this.mlb_title.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlb_title.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_title.Location = new System.Drawing.Point(20, 54);
            this.mlb_title.Name = "mlb_title";
            this.mlb_title.Size = new System.Drawing.Size(63, 15);
            this.mlb_title.TabIndex = 14;
            this.mlb_title.Text = "COVID-19";
            // 
            // mpnl_logo
            // 
            this.mpnl_logo.BackgroundImage = global::IHChan.Properties.Resources.mankinds;
            this.mpnl_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpnl_logo.HorizontalScrollbarBarColor = true;
            this.mpnl_logo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_logo.HorizontalScrollbarSize = 10;
            this.mpnl_logo.Location = new System.Drawing.Point(208, 22);
            this.mpnl_logo.Name = "mpnl_logo";
            this.mpnl_logo.Size = new System.Drawing.Size(46, 46);
            this.mpnl_logo.TabIndex = 15;
            this.mpnl_logo.VerticalScrollbarBarColor = true;
            this.mpnl_logo.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_logo.VerticalScrollbarSize = 10;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_logo);
            this.Controls.Add(this.mlb_title);
            this.Controls.Add(this.mlb_value);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(267, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlb_value;
        private MetroFramework.Controls.MetroLabel mlb_title;
        private MetroFramework.Controls.MetroPanel mpnl_logo;
    }
}
