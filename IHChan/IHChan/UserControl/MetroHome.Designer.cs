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
            this.mpnl_overseas = new MetroFramework.Controls.MetroPanel();
            this.mpnl_overseas1 = new MetroFramework.Controls.MetroPanel();
            this.mpnl_home = new MetroFramework.Controls.MetroPanel();
            this.mpnl_home1 = new MetroFramework.Controls.MetroPanel();
            this.mpnl_main.SuspendLayout();
            this.mpnl_overseas.SuspendLayout();
            this.mpnl_home.SuspendLayout();
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
            this.mpnl_main.Controls.Add(this.mpnl_overseas);
            this.mpnl_main.Controls.Add(this.mpnl_home);
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
            // mpnl_overseas
            // 
            this.mpnl_overseas.Controls.Add(this.mpnl_overseas1);
            this.mpnl_overseas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_overseas.HorizontalScrollbarBarColor = true;
            this.mpnl_overseas.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_overseas.HorizontalScrollbarSize = 10;
            this.mpnl_overseas.Location = new System.Drawing.Point(0, 361);
            this.mpnl_overseas.Name = "mpnl_overseas";
            this.mpnl_overseas.Size = new System.Drawing.Size(1305, 361);
            this.mpnl_overseas.TabIndex = 3;
            this.mpnl_overseas.VerticalScrollbarBarColor = true;
            this.mpnl_overseas.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_overseas.VerticalScrollbarSize = 10;
            // 
            // mpnl_overseas1
            // 
            this.mpnl_overseas1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnl_overseas1.HorizontalScrollbarBarColor = true;
            this.mpnl_overseas1.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_overseas1.HorizontalScrollbarSize = 10;
            this.mpnl_overseas1.Location = new System.Drawing.Point(0, 0);
            this.mpnl_overseas1.Name = "mpnl_overseas1";
            this.mpnl_overseas1.Size = new System.Drawing.Size(1305, 100);
            this.mpnl_overseas1.TabIndex = 3;
            this.mpnl_overseas1.VerticalScrollbarBarColor = true;
            this.mpnl_overseas1.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_overseas1.VerticalScrollbarSize = 10;
            // 
            // mpnl_home
            // 
            this.mpnl_home.Controls.Add(this.mpnl_home1);
            this.mpnl_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnl_home.HorizontalScrollbarBarColor = true;
            this.mpnl_home.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_home.HorizontalScrollbarSize = 10;
            this.mpnl_home.Location = new System.Drawing.Point(0, 0);
            this.mpnl_home.Name = "mpnl_home";
            this.mpnl_home.Size = new System.Drawing.Size(1305, 361);
            this.mpnl_home.TabIndex = 2;
            this.mpnl_home.VerticalScrollbarBarColor = true;
            this.mpnl_home.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_home.VerticalScrollbarSize = 10;
            // 
            // mpnl_home1
            // 
            this.mpnl_home1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnl_home1.HorizontalScrollbarBarColor = true;
            this.mpnl_home1.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_home1.HorizontalScrollbarSize = 10;
            this.mpnl_home1.Location = new System.Drawing.Point(0, 0);
            this.mpnl_home1.Name = "mpnl_home1";
            this.mpnl_home1.Size = new System.Drawing.Size(1305, 100);
            this.mpnl_home1.TabIndex = 2;
            this.mpnl_home1.VerticalScrollbarBarColor = true;
            this.mpnl_home1.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_home1.VerticalScrollbarSize = 10;
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
            this.mpnl_overseas.ResumeLayout(false);
            this.mpnl_home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_temp;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private MetroFramework.Controls.MetroPanel mpnl_overseas;
        private MetroFramework.Controls.MetroPanel mpnl_home;
        private MetroFramework.Controls.MetroPanel mpnl_overseas1;
        private MetroFramework.Controls.MetroPanel mpnl_home1;
    }
}
