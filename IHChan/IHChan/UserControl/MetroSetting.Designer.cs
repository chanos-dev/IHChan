namespace IHChan.UserControl
{
    partial class MetroSetting
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
            this.mlb_theme = new MetroFramework.Controls.MetroLabel();
            this.mcb_theme = new MetroFramework.Controls.MetroComboBox();
            this.mlb_color = new MetroFramework.Controls.MetroLabel();
            this.mcb_color = new MetroFramework.Controls.MetroComboBox();
            this.mbtn_OK = new MetroFramework.Controls.MetroButton();
            this.mbtn_cancel = new MetroFramework.Controls.MetroButton();
            this.mpnl_main.SuspendLayout();
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
            this.mpnl_temp.Size = new System.Drawing.Size(1251, 15);
            this.mpnl_temp.TabIndex = 2;
            this.mpnl_temp.VerticalScrollbarBarColor = true;
            this.mpnl_temp.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp.VerticalScrollbarSize = 10;
            // 
            // mpnl_main
            // 
            this.mpnl_main.Controls.Add(this.mbtn_cancel);
            this.mpnl_main.Controls.Add(this.mbtn_OK);
            this.mpnl_main.Controls.Add(this.mlb_color);
            this.mpnl_main.Controls.Add(this.mcb_color);
            this.mpnl_main.Controls.Add(this.mlb_theme);
            this.mpnl_main.Controls.Add(this.mcb_theme);
            this.mpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_main.HorizontalScrollbarBarColor = true;
            this.mpnl_main.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_main.HorizontalScrollbarSize = 10;
            this.mpnl_main.Location = new System.Drawing.Point(0, 15);
            this.mpnl_main.Name = "mpnl_main";
            this.mpnl_main.Size = new System.Drawing.Size(1251, 655);
            this.mpnl_main.TabIndex = 3;
            this.mpnl_main.VerticalScrollbarBarColor = true;
            this.mpnl_main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_main.VerticalScrollbarSize = 10;
            // 
            // mlb_theme
            // 
            this.mlb_theme.AutoSize = true;
            this.mlb_theme.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_theme.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlb_theme.Location = new System.Drawing.Point(3, 3);
            this.mlb_theme.Name = "mlb_theme";
            this.mlb_theme.Size = new System.Drawing.Size(79, 25);
            this.mlb_theme.TabIndex = 3;
            this.mlb_theme.Text = "Theme : ";
            // 
            // mcb_theme
            // 
            this.mcb_theme.FormattingEnabled = true;
            this.mcb_theme.ItemHeight = 23;
            this.mcb_theme.Location = new System.Drawing.Point(88, 3);
            this.mcb_theme.Name = "mcb_theme";
            this.mcb_theme.Size = new System.Drawing.Size(170, 29);
            this.mcb_theme.TabIndex = 2;
            this.mcb_theme.UseSelectable = true;
            this.mcb_theme.SelectedIndexChanged += new System.EventHandler(this.mcb_theme_SelectedIndexChanged);
            // 
            // mlb_color
            // 
            this.mlb_color.AutoSize = true;
            this.mlb_color.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_color.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlb_color.Location = new System.Drawing.Point(3, 73);
            this.mlb_color.Name = "mlb_color";
            this.mlb_color.Size = new System.Drawing.Size(69, 25);
            this.mlb_color.TabIndex = 5;
            this.mlb_color.Text = "Color : ";
            // 
            // mcb_color
            // 
            this.mcb_color.FormattingEnabled = true;
            this.mcb_color.ItemHeight = 23;
            this.mcb_color.Location = new System.Drawing.Point(88, 73);
            this.mcb_color.Name = "mcb_color";
            this.mcb_color.Size = new System.Drawing.Size(170, 29);
            this.mcb_color.TabIndex = 4;
            this.mcb_color.UseSelectable = true;
            this.mcb_color.SelectedIndexChanged += new System.EventHandler(this.mcb_color_SelectedIndexChanged);
            // 
            // mbtn_OK
            // 
            this.mbtn_OK.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtn_OK.Location = new System.Drawing.Point(953, 598);
            this.mbtn_OK.Name = "mbtn_OK";
            this.mbtn_OK.Size = new System.Drawing.Size(135, 54);
            this.mbtn_OK.TabIndex = 6;
            this.mbtn_OK.Text = "적용";
            this.mbtn_OK.UseSelectable = true;
            this.mbtn_OK.UseStyleColors = true;
            this.mbtn_OK.Click += new System.EventHandler(this.mbtn_OK_Click);
            // 
            // mbtn_cancel
            // 
            this.mbtn_cancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtn_cancel.Location = new System.Drawing.Point(1104, 598);
            this.mbtn_cancel.Name = "mbtn_cancel";
            this.mbtn_cancel.Size = new System.Drawing.Size(135, 54);
            this.mbtn_cancel.TabIndex = 7;
            this.mbtn_cancel.Text = "취소";
            this.mbtn_cancel.UseSelectable = true;
            this.mbtn_cancel.UseStyleColors = true;
            this.mbtn_cancel.Click += new System.EventHandler(this.mbtn_cancel_Click);
            // 
            // MetroSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_main);
            this.Controls.Add(this.mpnl_temp);
            this.Name = "MetroSetting";
            this.Size = new System.Drawing.Size(1251, 670);
            this.mpnl_main.ResumeLayout(false);
            this.mpnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_temp;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private MetroFramework.Controls.MetroLabel mlb_theme;
        private MetroFramework.Controls.MetroComboBox mcb_theme;
        private MetroFramework.Controls.MetroLabel mlb_color;
        private MetroFramework.Controls.MetroComboBox mcb_color;
        private MetroFramework.Controls.MetroButton mbtn_OK;
        private MetroFramework.Controls.MetroButton mbtn_cancel;
    }
}
