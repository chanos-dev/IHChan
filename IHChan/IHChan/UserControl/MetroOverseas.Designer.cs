namespace IHChan.UserControl
{
    partial class MetroOverseas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mpnl_list = new MetroFramework.Controls.MetroPanel();
            this.mgr_covidList = new MetroFramework.Controls.MetroGrid();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdt_date = new MetroFramework.Controls.MetroDateTime();
            this.mpnl_temp2 = new MetroFramework.Controls.MetroPanel();
            this.mpnl_state = new MetroFramework.Controls.MetroPanel();
            this.mpnl_map = new MetroFramework.Controls.MetroPanel();
            this.mpnl_temp = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mpnl_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgr_covidList)).BeginInit();
            this.mpnl_state.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnl_list
            // 
            this.mpnl_list.Controls.Add(this.mgr_covidList);
            this.mpnl_list.Controls.Add(this.mdt_date);
            this.mpnl_list.Controls.Add(this.mpnl_temp2);
            this.mpnl_list.Dock = System.Windows.Forms.DockStyle.Right;
            this.mpnl_list.HorizontalScrollbarBarColor = true;
            this.mpnl_list.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_list.HorizontalScrollbarSize = 10;
            this.mpnl_list.Location = new System.Drawing.Point(1035, 15);
            this.mpnl_list.Name = "mpnl_list";
            this.mpnl_list.Size = new System.Drawing.Size(270, 722);
            this.mpnl_list.TabIndex = 0;
            this.mpnl_list.VerticalScrollbarBarColor = true;
            this.mpnl_list.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_list.VerticalScrollbarSize = 10;
            // 
            // mgr_covidList
            // 
            this.mgr_covidList.AllowUserToAddRows = false;
            this.mgr_covidList.AllowUserToDeleteRows = false;
            this.mgr_covidList.AllowUserToOrderColumns = true;
            this.mgr_covidList.AllowUserToResizeColumns = false;
            this.mgr_covidList.AllowUserToResizeRows = false;
            this.mgr_covidList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgr_covidList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgr_covidList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgr_covidList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgr_covidList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.mgr_covidList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgr_covidList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_count});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgr_covidList.DefaultCellStyle = dataGridViewCellStyle7;
            this.mgr_covidList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgr_covidList.EnableHeadersVisualStyles = false;
            this.mgr_covidList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgr_covidList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgr_covidList.Location = new System.Drawing.Point(10, 29);
            this.mgr_covidList.MultiSelect = false;
            this.mgr_covidList.Name = "mgr_covidList";
            this.mgr_covidList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgr_covidList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.mgr_covidList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgr_covidList.RowTemplate.Height = 23;
            this.mgr_covidList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgr_covidList.Size = new System.Drawing.Size(260, 693);
            this.mgr_covidList.TabIndex = 8;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "국가명";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_count
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.col_count.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_count.HeaderText = "확진자 수";
            this.col_count.Name = "col_count";
            this.col_count.ReadOnly = true;
            // 
            // mdt_date
            // 
            this.mdt_date.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdt_date.Location = new System.Drawing.Point(10, 0);
            this.mdt_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdt_date.Name = "mdt_date";
            this.mdt_date.Size = new System.Drawing.Size(260, 29);
            this.mdt_date.TabIndex = 7;
            this.mdt_date.ValueChanged += new System.EventHandler(this.mdt_date_ValueChanged);
            // 
            // mpnl_temp2
            // 
            this.mpnl_temp2.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpnl_temp2.HorizontalScrollbarBarColor = true;
            this.mpnl_temp2.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_temp2.HorizontalScrollbarSize = 10;
            this.mpnl_temp2.Location = new System.Drawing.Point(0, 0);
            this.mpnl_temp2.Name = "mpnl_temp2";
            this.mpnl_temp2.Size = new System.Drawing.Size(10, 722);
            this.mpnl_temp2.TabIndex = 6;
            this.mpnl_temp2.VerticalScrollbarBarColor = true;
            this.mpnl_temp2.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp2.VerticalScrollbarSize = 10;
            // 
            // mpnl_state
            // 
            this.mpnl_state.Controls.Add(this.metroLabel1);
            this.mpnl_state.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mpnl_state.HorizontalScrollbarBarColor = true;
            this.mpnl_state.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_state.HorizontalScrollbarSize = 10;
            this.mpnl_state.Location = new System.Drawing.Point(0, 560);
            this.mpnl_state.Name = "mpnl_state";
            this.mpnl_state.Size = new System.Drawing.Size(1035, 177);
            this.mpnl_state.TabIndex = 3;
            this.mpnl_state.VerticalScrollbarBarColor = true;
            this.mpnl_state.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_state.VerticalScrollbarSize = 10;
            // 
            // mpnl_map
            // 
            this.mpnl_map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_map.HorizontalScrollbarBarColor = true;
            this.mpnl_map.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_map.HorizontalScrollbarSize = 10;
            this.mpnl_map.Location = new System.Drawing.Point(0, 15);
            this.mpnl_map.Name = "mpnl_map";
            this.mpnl_map.Size = new System.Drawing.Size(1035, 545);
            this.mpnl_map.TabIndex = 4;
            this.mpnl_map.VerticalScrollbarBarColor = true;
            this.mpnl_map.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_map.VerticalScrollbarSize = 10;
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
            this.mpnl_temp.TabIndex = 5;
            this.mpnl_temp.VerticalScrollbarBarColor = true;
            this.mpnl_temp.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_temp.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(430, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(183, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "covid status of selected nation";
            // 
            // MetroOverseas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_map);
            this.Controls.Add(this.mpnl_state);
            this.Controls.Add(this.mpnl_list);
            this.Controls.Add(this.mpnl_temp);
            this.Name = "MetroOverseas";
            this.Size = new System.Drawing.Size(1305, 737);
            this.mpnl_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgr_covidList)).EndInit();
            this.mpnl_state.ResumeLayout(false);
            this.mpnl_state.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_list;
        private MetroFramework.Controls.MetroPanel mpnl_state;
        private MetroFramework.Controls.MetroPanel mpnl_map;
        private MetroFramework.Controls.MetroPanel mpnl_temp;
        private MetroFramework.Controls.MetroPanel mpnl_temp2;
        private MetroFramework.Controls.MetroDateTime mdt_date;
        private MetroFramework.Controls.MetroGrid mgr_covidList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_count;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
