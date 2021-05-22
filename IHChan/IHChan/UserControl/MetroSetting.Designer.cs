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
            this.mbtn_cancel = new MetroFramework.Controls.MetroButton();
            this.mbtn_OK = new MetroFramework.Controls.MetroButton();
            this.mlb_color = new MetroFramework.Controls.MetroLabel();
            this.mcb_color = new MetroFramework.Controls.MetroComboBox();
            this.mlb_theme = new MetroFramework.Controls.MetroLabel();
            this.mcb_theme = new MetroFramework.Controls.MetroComboBox();
            this.mlb_key = new MetroFramework.Controls.MetroLabel();
            this.mtb_key = new MetroFramework.Controls.MetroTextBox();
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
            this.mpnl_temp.Size = new System.Drawing.Size(1305, 15);
            this.mpnl_temp.TabIndex = 2;
            this.mpnl_temp.VerticalScrollbarBarColor = true;
            this.mpnl_temp.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp.VerticalScrollbarSize = 10;
            // 
            // mpnl_main
            // 
            this.mpnl_main.Controls.Add(this.mtb_key);
            this.mpnl_main.Controls.Add(this.mlb_key);
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
            this.mpnl_main.Size = new System.Drawing.Size(1305, 737);
            this.mpnl_main.TabIndex = 3;
            this.mpnl_main.VerticalScrollbarBarColor = true;
            this.mpnl_main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_main.VerticalScrollbarSize = 10;
            // 
            // mbtn_cancel
            // 
            this.mbtn_cancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtn_cancel.Location = new System.Drawing.Point(1158, 671);
            this.mbtn_cancel.Name = "mbtn_cancel";
            this.mbtn_cancel.Size = new System.Drawing.Size(135, 54);
            this.mbtn_cancel.TabIndex = 7;
            this.mbtn_cancel.Text = "취소";
            this.mbtn_cancel.UseSelectable = true;
            this.mbtn_cancel.UseStyleColors = true;
            this.mbtn_cancel.Click += new System.EventHandler(this.mbtn_cancel_Click);
            // 
            // mbtn_OK
            // 
            this.mbtn_OK.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtn_OK.Location = new System.Drawing.Point(1007, 671);
            this.mbtn_OK.Name = "mbtn_OK";
            this.mbtn_OK.Size = new System.Drawing.Size(135, 54);
            this.mbtn_OK.TabIndex = 6;
            this.mbtn_OK.Text = "적용";
            this.mbtn_OK.UseSelectable = true;
            this.mbtn_OK.UseStyleColors = true;
            this.mbtn_OK.Click += new System.EventHandler(this.mbtn_OK_Click);
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
            // mlb_key
            // 
            this.mlb_key.AutoSize = true;
            this.mlb_key.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_key.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlb_key.Location = new System.Drawing.Point(3, 143);
            this.mlb_key.Name = "mlb_key";
            this.mlb_key.Size = new System.Drawing.Size(54, 25);
            this.mlb_key.TabIndex = 8;
            this.mlb_key.Text = "Key : ";
            // 
            // mtb_key
            // 
            // 
            // 
            // 
            this.mtb_key.CustomButton.Font = new System.Drawing.Font("굴림", 9F);
            this.mtb_key.CustomButton.Image = null;
            this.mtb_key.CustomButton.Location = new System.Drawing.Point(1119, 2);
            this.mtb_key.CustomButton.Name = "";
            this.mtb_key.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.mtb_key.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_key.CustomButton.TabIndex = 1;
            this.mtb_key.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_key.CustomButton.UseSelectable = true;
            this.mtb_key.CustomButton.Visible = false;
            this.mtb_key.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtb_key.Lines = new string[0];
            this.mtb_key.Location = new System.Drawing.Point(88, 144);
            this.mtb_key.MaxLength = 32767;
            this.mtb_key.Name = "mtb_key";
            this.mtb_key.PasswordChar = '\0';
            this.mtb_key.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_key.SelectedText = "";
            this.mtb_key.SelectionLength = 0;
            this.mtb_key.SelectionStart = 0;
            this.mtb_key.ShortcutsEnabled = true;
            this.mtb_key.Size = new System.Drawing.Size(1151, 29);
            this.mtb_key.TabIndex = 9;
            this.mtb_key.UseSelectable = true;
            this.mtb_key.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_key.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetroSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_main);
            this.Controls.Add(this.mpnl_temp);
            this.Name = "MetroSetting";
            this.Size = new System.Drawing.Size(1305, 752);
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
        private MetroFramework.Controls.MetroLabel mlb_key;
        private MetroFramework.Controls.MetroTextBox mtb_key;
    }
}
