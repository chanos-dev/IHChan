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
            this.mpnl_date = new MetroFramework.Controls.MetroPanel();
            this.mlb_date = new MetroFramework.Controls.MetroLabel();
            this.mpnl_left = new MetroFramework.Controls.MetroPanel();
            this.mpnl_right = new MetroFramework.Controls.MetroPanel(); 
            this.mpnl_main.SuspendLayout();
            this.mpnl_date.SuspendLayout();
            this.mpnl_right.SuspendLayout();
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
            // mpnl_left
            // 
            this.mpnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpnl_left.HorizontalScrollbarBarColor = true;
            this.mpnl_left.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_left.HorizontalScrollbarSize = 10;
            this.mpnl_left.Location = new System.Drawing.Point(0, 30);
            this.mpnl_left.Name = "mpnl_left";
            this.mpnl_left.Size = new System.Drawing.Size(652, 692);
            this.mpnl_left.TabIndex = 8;
            this.mpnl_left.VerticalScrollbarBarColor = true;
            this.mpnl_left.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_left.VerticalScrollbarSize = 10;
            // 
            // mpnl_right
            //  
            this.mpnl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_right.HorizontalScrollbarBarColor = true;
            this.mpnl_right.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_right.HorizontalScrollbarSize = 10;
            this.mpnl_right.Location = new System.Drawing.Point(652, 30);
            this.mpnl_right.Name = "mpnl_right";
            this.mpnl_right.Size = new System.Drawing.Size(653, 692);
            this.mpnl_right.TabIndex = 9;
            this.mpnl_right.VerticalScrollbarBarColor = true;
            this.mpnl_right.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_right.VerticalScrollbarSize = 10; 
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
            this.mpnl_date.ResumeLayout(false);
            this.mpnl_date.PerformLayout();
            this.mpnl_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_temp;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private MetroFramework.Controls.MetroPanel mpnl_date;
        private MetroFramework.Controls.MetroLabel mlb_date;
        private MetroFramework.Controls.MetroPanel mpnl_left;
        private MetroFramework.Controls.MetroPanel mpnl_right; 
    }
}
