namespace IDLChan
{
    partial class mfrm_main
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mfrm_main));
            this.ms_Manager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mpnl_header = new MetroFramework.Controls.MetroPanel();
            this.mtile_setting = new MetroFramework.Controls.MetroTile();
            this.mpnl_temp3 = new MetroFramework.Controls.MetroPanel();
            this.mtile_overseas = new MetroFramework.Controls.MetroTile();
            this.mpnl_temp2 = new MetroFramework.Controls.MetroPanel();
            this.mtile_homecountry = new MetroFramework.Controls.MetroTile();
            this.mpnl_temp1 = new MetroFramework.Controls.MetroPanel();
            this.mtile_home = new MetroFramework.Controls.MetroTile();
            this.mpnl_logomain = new MetroFramework.Controls.MetroPanel();
            this.mlb_title = new MetroFramework.Controls.MetroLabel();
            this.mpnl_logo = new MetroFramework.Controls.MetroPanel();
            this.mpnl_main = new MetroFramework.Controls.MetroPanel();
            this.mpnl_mainstick = new MetroFramework.Controls.MetroPanel();
            this.mtile_stick = new MetroFramework.Controls.MetroTile();
            this.mpnl_temp = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ms_Manager)).BeginInit();
            this.mpnl_header.SuspendLayout();
            this.mpnl_logomain.SuspendLayout();
            this.mpnl_mainstick.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Manager
            // 
            this.ms_Manager.Owner = null;
            // 
            // mpnl_header
            // 
            this.mpnl_header.Controls.Add(this.mtile_setting);
            this.mpnl_header.Controls.Add(this.mpnl_temp3);
            this.mpnl_header.Controls.Add(this.mtile_overseas);
            this.mpnl_header.Controls.Add(this.mpnl_temp2);
            this.mpnl_header.Controls.Add(this.mtile_homecountry);
            this.mpnl_header.Controls.Add(this.mpnl_temp1);
            this.mpnl_header.Controls.Add(this.mtile_home);
            this.mpnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnl_header.HorizontalScrollbarBarColor = true;
            this.mpnl_header.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_header.HorizontalScrollbarSize = 10;
            this.mpnl_header.Location = new System.Drawing.Point(20, 60);
            this.mpnl_header.Name = "mpnl_header";
            this.mpnl_header.Size = new System.Drawing.Size(1305, 50);
            this.mpnl_header.TabIndex = 4;
            this.mpnl_header.VerticalScrollbarBarColor = true;
            this.mpnl_header.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_header.VerticalScrollbarSize = 10;
            // 
            // mtile_setting
            // 
            this.mtile_setting.ActiveControl = null;
            this.mtile_setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.mtile_setting.Location = new System.Drawing.Point(636, 0);
            this.mtile_setting.Name = "mtile_setting";
            this.mtile_setting.Size = new System.Drawing.Size(192, 50);
            this.mtile_setting.TabIndex = 8;
            this.mtile_setting.Text = "설정";
            this.mtile_setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtile_setting.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtile_setting.UseSelectable = true;
            this.mtile_setting.Click += new System.EventHandler(this.mtile_Click);
            // 
            // mpnl_temp3
            // 
            this.mpnl_temp3.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpnl_temp3.HorizontalScrollbarBarColor = true;
            this.mpnl_temp3.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_temp3.HorizontalScrollbarSize = 10;
            this.mpnl_temp3.Location = new System.Drawing.Point(616, 0);
            this.mpnl_temp3.Name = "mpnl_temp3";
            this.mpnl_temp3.Size = new System.Drawing.Size(20, 50);
            this.mpnl_temp3.TabIndex = 7;
            this.mpnl_temp3.VerticalScrollbarBarColor = true;
            this.mpnl_temp3.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp3.VerticalScrollbarSize = 10;
            // 
            // mtile_overseas
            // 
            this.mtile_overseas.ActiveControl = null;
            this.mtile_overseas.Dock = System.Windows.Forms.DockStyle.Left;
            this.mtile_overseas.Location = new System.Drawing.Point(424, 0);
            this.mtile_overseas.Name = "mtile_overseas";
            this.mtile_overseas.Size = new System.Drawing.Size(192, 50);
            this.mtile_overseas.TabIndex = 6;
            this.mtile_overseas.Text = "해외";
            this.mtile_overseas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtile_overseas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtile_overseas.UseSelectable = true;
            this.mtile_overseas.Click += new System.EventHandler(this.mtile_Click);
            // 
            // mpnl_temp2
            // 
            this.mpnl_temp2.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpnl_temp2.HorizontalScrollbarBarColor = true;
            this.mpnl_temp2.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_temp2.HorizontalScrollbarSize = 10;
            this.mpnl_temp2.Location = new System.Drawing.Point(404, 0);
            this.mpnl_temp2.Name = "mpnl_temp2";
            this.mpnl_temp2.Size = new System.Drawing.Size(20, 50);
            this.mpnl_temp2.TabIndex = 5;
            this.mpnl_temp2.VerticalScrollbarBarColor = true;
            this.mpnl_temp2.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp2.VerticalScrollbarSize = 10;
            // 
            // mtile_homecountry
            // 
            this.mtile_homecountry.ActiveControl = null;
            this.mtile_homecountry.Dock = System.Windows.Forms.DockStyle.Left;
            this.mtile_homecountry.Location = new System.Drawing.Point(212, 0);
            this.mtile_homecountry.Name = "mtile_homecountry";
            this.mtile_homecountry.Size = new System.Drawing.Size(192, 50);
            this.mtile_homecountry.TabIndex = 4;
            this.mtile_homecountry.Text = "국내";
            this.mtile_homecountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtile_homecountry.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtile_homecountry.UseSelectable = true;
            this.mtile_homecountry.Click += new System.EventHandler(this.mtile_Click);
            // 
            // mpnl_temp1
            // 
            this.mpnl_temp1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpnl_temp1.HorizontalScrollbarBarColor = true;
            this.mpnl_temp1.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_temp1.HorizontalScrollbarSize = 10;
            this.mpnl_temp1.Location = new System.Drawing.Point(192, 0);
            this.mpnl_temp1.Name = "mpnl_temp1";
            this.mpnl_temp1.Size = new System.Drawing.Size(20, 50);
            this.mpnl_temp1.TabIndex = 3;
            this.mpnl_temp1.VerticalScrollbarBarColor = true;
            this.mpnl_temp1.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp1.VerticalScrollbarSize = 10;
            // 
            // mtile_home
            // 
            this.mtile_home.ActiveControl = null;
            this.mtile_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.mtile_home.Location = new System.Drawing.Point(0, 0);
            this.mtile_home.Name = "mtile_home";
            this.mtile_home.Size = new System.Drawing.Size(192, 50);
            this.mtile_home.TabIndex = 2;
            this.mtile_home.Text = "홈";
            this.mtile_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtile_home.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtile_home.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtile_home.UseSelectable = true;
            this.mtile_home.Click += new System.EventHandler(this.mtile_Click);
            // 
            // mpnl_logomain
            // 
            this.mpnl_logomain.Controls.Add(this.mlb_title);
            this.mpnl_logomain.Controls.Add(this.mpnl_logo);
            this.mpnl_logomain.HorizontalScrollbarBarColor = true;
            this.mpnl_logomain.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_logomain.HorizontalScrollbarSize = 10;
            this.mpnl_logomain.Location = new System.Drawing.Point(20, 10);
            this.mpnl_logomain.Name = "mpnl_logomain";
            this.mpnl_logomain.Size = new System.Drawing.Size(192, 46);
            this.mpnl_logomain.TabIndex = 11;
            this.mpnl_logomain.VerticalScrollbarBarColor = true;
            this.mpnl_logomain.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_logomain.VerticalScrollbarSize = 10;
            // 
            // mlb_title
            // 
            this.mlb_title.AutoSize = true;
            this.mlb_title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_title.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_title.Location = new System.Drawing.Point(52, 12);
            this.mlb_title.Name = "mlb_title";
            this.mlb_title.Size = new System.Drawing.Size(95, 25);
            this.mlb_title.TabIndex = 12;
            this.mlb_title.Text = "COVID-19";
            // 
            // mpnl_logo
            // 
            this.mpnl_logo.BackgroundImage = global::IHChan.Properties.Resources.coronavirus;
            this.mpnl_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpnl_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpnl_logo.HorizontalScrollbarBarColor = true;
            this.mpnl_logo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_logo.HorizontalScrollbarSize = 10;
            this.mpnl_logo.Location = new System.Drawing.Point(0, 0);
            this.mpnl_logo.Name = "mpnl_logo";
            this.mpnl_logo.Size = new System.Drawing.Size(46, 46);
            this.mpnl_logo.TabIndex = 11;
            this.mpnl_logo.VerticalScrollbarBarColor = true;
            this.mpnl_logo.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_logo.VerticalScrollbarSize = 10;
            // 
            // mpnl_main
            // 
            this.mpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_main.HorizontalScrollbarBarColor = true;
            this.mpnl_main.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_main.HorizontalScrollbarSize = 10;
            this.mpnl_main.Location = new System.Drawing.Point(20, 115);
            this.mpnl_main.Name = "mpnl_main";
            this.mpnl_main.Size = new System.Drawing.Size(1305, 747);
            this.mpnl_main.TabIndex = 12;
            this.mpnl_main.VerticalScrollbarBarColor = true;
            this.mpnl_main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_main.VerticalScrollbarSize = 10;
            // 
            // mpnl_mainstick
            // 
            this.mpnl_mainstick.Controls.Add(this.mtile_stick);
            this.mpnl_mainstick.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnl_mainstick.HorizontalScrollbarBarColor = true;
            this.mpnl_mainstick.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_mainstick.HorizontalScrollbarSize = 10;
            this.mpnl_mainstick.Location = new System.Drawing.Point(20, 110);
            this.mpnl_mainstick.Name = "mpnl_mainstick";
            this.mpnl_mainstick.Size = new System.Drawing.Size(1305, 5);
            this.mpnl_mainstick.TabIndex = 13;
            this.mpnl_mainstick.VerticalScrollbarBarColor = true;
            this.mpnl_mainstick.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_mainstick.VerticalScrollbarSize = 10;
            // 
            // mtile_stick
            // 
            this.mtile_stick.ActiveControl = null;
            this.mtile_stick.Enabled = false;
            this.mtile_stick.Location = new System.Drawing.Point(0, 0);
            this.mtile_stick.Name = "mtile_stick";
            this.mtile_stick.Size = new System.Drawing.Size(192, 5);
            this.mtile_stick.TabIndex = 2;
            this.mtile_stick.UseSelectable = true;
            // 
            // mpnl_temp
            // 
            this.mpnl_temp.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnl_temp.HorizontalScrollbarBarColor = true;
            this.mpnl_temp.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_temp.HorizontalScrollbarSize = 10;
            this.mpnl_temp.Location = new System.Drawing.Point(20, 115);
            this.mpnl_temp.Name = "mpnl_temp";
            this.mpnl_temp.Size = new System.Drawing.Size(1305, 5);
            this.mpnl_temp.TabIndex = 14;
            this.mpnl_temp.VerticalScrollbarBarColor = true;
            this.mpnl_temp.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp.VerticalScrollbarSize = 10;
            // 
            // mfrm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 882);
            this.Controls.Add(this.mpnl_main);
            this.Controls.Add(this.mpnl_mainstick);
            this.Controls.Add(this.mpnl_temp);
            this.Controls.Add(this.mpnl_logomain);
            this.Controls.Add(this.mpnl_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mfrm_main";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.ms_Manager)).EndInit();
            this.mpnl_header.ResumeLayout(false);
            this.mpnl_logomain.ResumeLayout(false);
            this.mpnl_logomain.PerformLayout();
            this.mpnl_mainstick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager ms_Manager;
        private MetroFramework.Controls.MetroPanel mpnl_header;
        private MetroFramework.Controls.MetroTile mtile_home;
        private MetroFramework.Controls.MetroTile mtile_homecountry;
        private MetroFramework.Controls.MetroPanel mpnl_temp1;
        private MetroFramework.Controls.MetroTile mtile_setting;
        private MetroFramework.Controls.MetroPanel mpnl_temp3;
        private MetroFramework.Controls.MetroTile mtile_overseas;
        private MetroFramework.Controls.MetroPanel mpnl_temp2;
        private MetroFramework.Controls.MetroPanel mpnl_logomain;
        private MetroFramework.Controls.MetroPanel mpnl_logo;
        private MetroFramework.Controls.MetroLabel mlb_title;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private MetroFramework.Controls.MetroPanel mpnl_mainstick;
        private MetroFramework.Controls.MetroTile mtile_stick;
        private MetroFramework.Controls.MetroPanel mpnl_temp;
    }
}

