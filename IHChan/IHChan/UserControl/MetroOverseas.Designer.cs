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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mpnl_list = new MetroFramework.Controls.MetroPanel();
            this.mps_process = new MetroFramework.Controls.MetroProgressSpinner();
            this.mgr_covidList = new MetroFramework.Controls.MetroGrid();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_deathrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mbtn_refresh = new MetroFramework.Controls.MetroButton();
            this.mdt_date = new MetroFramework.Controls.MetroDateTime();
            this.mpnl_temp2 = new MetroFramework.Controls.MetroPanel();
            this.mpnl_state = new MetroFramework.Controls.MetroPanel();
            this.mlb_rate = new MetroFramework.Controls.MetroLabel();
            this.mlb_death = new MetroFramework.Controls.MetroLabel();
            this.mlb_total = new MetroFramework.Controls.MetroLabel();
            this.cg_deathrate = new IHChan.UserControl.CircleGraph();
            this.cg_death = new IHChan.UserControl.CircleGraph();
            this.cg_total = new IHChan.UserControl.CircleGraph();
            this.mpnl_map = new MetroFramework.Controls.MetroPanel();
            this.mpnl_temp = new MetroFramework.Controls.MetroPanel();
            this.mpnl_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgr_covidList)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.mpnl_state.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnl_list
            // 
            this.mpnl_list.Controls.Add(this.mps_process);
            this.mpnl_list.Controls.Add(this.mgr_covidList);
            this.mpnl_list.Controls.Add(this.metroPanel1);
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
            // mps_process
            // 
            this.mps_process.Location = new System.Drawing.Point(90, 303);
            this.mps_process.Maximum = 100;
            this.mps_process.Name = "mps_process";
            this.mps_process.Size = new System.Drawing.Size(95, 95);
            this.mps_process.TabIndex = 10;
            this.mps_process.UseSelectable = true;
            this.mps_process.Visible = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgr_covidList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgr_covidList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgr_covidList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_count,
            this.col_death,
            this.col_deathrate,
            this.col_nation});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgr_covidList.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgr_covidList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgr_covidList.EnableHeadersVisualStyles = false;
            this.mgr_covidList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgr_covidList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgr_covidList.Location = new System.Drawing.Point(10, 29);
            this.mgr_covidList.MultiSelect = false;
            this.mgr_covidList.Name = "mgr_covidList";
            this.mgr_covidList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgr_covidList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgr_covidList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgr_covidList.RowTemplate.Height = 23;
            this.mgr_covidList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgr_covidList.Size = new System.Drawing.Size(260, 693);
            this.mgr_covidList.TabIndex = 8;
            this.mgr_covidList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgr_covidList_CellClick);
            // 
            // col_name
            // 
            this.col_name.HeaderText = "국가명";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_count
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.col_count.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_count.HeaderText = "확진자 수";
            this.col_count.Name = "col_count";
            this.col_count.ReadOnly = true;
            // 
            // col_death
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.col_death.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_death.HeaderText = "사망자 수";
            this.col_death.Name = "col_death";
            this.col_death.ReadOnly = true;
            // 
            // col_deathrate
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.col_deathrate.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_deathrate.HeaderText = "사망자 비율";
            this.col_deathrate.Name = "col_deathrate";
            this.col_deathrate.ReadOnly = true;
            // 
            // col_nation
            // 
            this.col_nation.HeaderText = "국가코드";
            this.col_nation.Name = "col_nation";
            this.col_nation.ReadOnly = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mbtn_refresh);
            this.metroPanel1.Controls.Add(this.mdt_date);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(260, 29);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mbtn_refresh
            // 
            this.mbtn_refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtn_refresh.Location = new System.Drawing.Point(241, 0);
            this.mbtn_refresh.Name = "mbtn_refresh";
            this.mbtn_refresh.Size = new System.Drawing.Size(19, 29);
            this.mbtn_refresh.TabIndex = 9;
            this.mbtn_refresh.Text = "R";
            this.mbtn_refresh.UseSelectable = true;
            this.mbtn_refresh.Click += new System.EventHandler(this.mbtn_refresh_Click);
            // 
            // mdt_date
            // 
            this.mdt_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.mdt_date.Location = new System.Drawing.Point(0, 0);
            this.mdt_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdt_date.Name = "mdt_date";
            this.mdt_date.Size = new System.Drawing.Size(241, 29);
            this.mdt_date.TabIndex = 8;
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
            this.mpnl_state.Controls.Add(this.mlb_rate);
            this.mpnl_state.Controls.Add(this.mlb_death);
            this.mpnl_state.Controls.Add(this.mlb_total);
            this.mpnl_state.Controls.Add(this.cg_deathrate);
            this.mpnl_state.Controls.Add(this.cg_death);
            this.mpnl_state.Controls.Add(this.cg_total);
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
            // mlb_rate
            // 
            this.mlb_rate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_rate.Location = new System.Drawing.Point(755, 10);
            this.mlb_rate.Name = "mlb_rate";
            this.mlb_rate.Size = new System.Drawing.Size(210, 23);
            this.mlb_rate.TabIndex = 7;
            this.mlb_rate.Text = "사망자 비율";
            this.mlb_rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlb_death
            // 
            this.mlb_death.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_death.Location = new System.Drawing.Point(405, 10);
            this.mlb_death.Name = "mlb_death";
            this.mlb_death.Size = new System.Drawing.Size(210, 23);
            this.mlb_death.TabIndex = 6;
            this.mlb_death.Text = "사망자 수";
            this.mlb_death.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlb_total
            // 
            this.mlb_total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_total.Location = new System.Drawing.Point(55, 10);
            this.mlb_total.Name = "mlb_total";
            this.mlb_total.Size = new System.Drawing.Size(210, 23);
            this.mlb_total.TabIndex = 5;
            this.mlb_total.Text = "확진자 수";
            this.mlb_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cg_deathrate
            // 
            this.cg_deathrate.Alignment = System.Drawing.StringAlignment.Center;
            this.cg_deathrate.BackCircleColor = System.Drawing.Color.Gray;
            this.cg_deathrate.CirCleText = "0 / 0";
            this.cg_deathrate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cg_deathrate.ForeCircleColor = System.Drawing.Color.Blue;
            this.cg_deathrate.ForeColor = System.Drawing.Color.Crimson;
            this.cg_deathrate.HalfCircle = true;
            this.cg_deathrate.InCircleRate = 0.65D;
            this.cg_deathrate.Location = new System.Drawing.Point(755, 39);
            this.cg_deathrate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cg_deathrate.MaxValue = 100;
            this.cg_deathrate.Name = "cg_deathrate";
            this.cg_deathrate.Size = new System.Drawing.Size(210, 210);
            this.cg_deathrate.TabIndex = 4;
            this.cg_deathrate.TextColor = System.Drawing.Color.Black;
            this.cg_deathrate.UseSelectable = true;
            this.cg_deathrate.Value = 0;
            // 
            // cg_death
            // 
            this.cg_death.Alignment = System.Drawing.StringAlignment.Center;
            this.cg_death.BackCircleColor = System.Drawing.Color.Gray;
            this.cg_death.CirCleText = "0 / 0";
            this.cg_death.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cg_death.ForeCircleColor = System.Drawing.Color.Blue;
            this.cg_death.ForeColor = System.Drawing.Color.Crimson;
            this.cg_death.HalfCircle = true;
            this.cg_death.InCircleRate = 0.65D;
            this.cg_death.Location = new System.Drawing.Point(405, 39);
            this.cg_death.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cg_death.MaxValue = 100;
            this.cg_death.Name = "cg_death";
            this.cg_death.Size = new System.Drawing.Size(210, 210);
            this.cg_death.TabIndex = 3;
            this.cg_death.TextColor = System.Drawing.Color.Black;
            this.cg_death.UseSelectable = true;
            this.cg_death.Value = 0;
            // 
            // cg_total
            // 
            this.cg_total.Alignment = System.Drawing.StringAlignment.Center;
            this.cg_total.BackCircleColor = System.Drawing.Color.Gray;
            this.cg_total.CirCleText = "0 / 0";
            this.cg_total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cg_total.ForeCircleColor = System.Drawing.Color.Blue;
            this.cg_total.ForeColor = System.Drawing.Color.Crimson;
            this.cg_total.HalfCircle = true;
            this.cg_total.InCircleRate = 0.65D;
            this.cg_total.Location = new System.Drawing.Point(55, 39);
            this.cg_total.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cg_total.MaxValue = 100;
            this.cg_total.Name = "cg_total";
            this.cg_total.Size = new System.Drawing.Size(210, 210);
            this.cg_total.TabIndex = 2;
            this.cg_total.TextColor = System.Drawing.Color.Black;
            this.cg_total.UseSelectable = true;
            this.cg_total.Value = 0;
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
            this.metroPanel1.ResumeLayout(false);
            this.mpnl_state.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_list;
        private MetroFramework.Controls.MetroPanel mpnl_state;
        private MetroFramework.Controls.MetroPanel mpnl_map;
        private MetroFramework.Controls.MetroPanel mpnl_temp;
        private MetroFramework.Controls.MetroPanel mpnl_temp2;
        private MetroFramework.Controls.MetroGrid mgr_covidList;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime mdt_date;
        private MetroFramework.Controls.MetroButton mbtn_refresh;
        private MetroFramework.Controls.MetroProgressSpinner mps_process;
        private CircleGraph cg_total;
        private CircleGraph cg_deathrate;
        private CircleGraph cg_death;
        private MetroFramework.Controls.MetroLabel mlb_death;
        private MetroFramework.Controls.MetroLabel mlb_total;
        private MetroFramework.Controls.MetroLabel mlb_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_death;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_deathrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nation;
    }
}
