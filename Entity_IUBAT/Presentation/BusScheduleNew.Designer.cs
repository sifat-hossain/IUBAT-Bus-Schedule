namespace Entity_IUBAT.Presentation
{
    partial class BusScheduleNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.schedule_data = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_bus = new System.Windows.Forms.Button();
            this.cmb_bus_no = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_data)).BeginInit();
            this.SuspendLayout();
            // 
            // schedule_data
            // 
            this.schedule_data.AllowUserToAddRows = false;
            this.schedule_data.AllowUserToDeleteRows = false;
            this.schedule_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schedule_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.t_id,
            this.l_from,
            this.l_to});
            this.schedule_data.Location = new System.Drawing.Point(-1, 52);
            this.schedule_data.Name = "schedule_data";
            this.schedule_data.ReadOnly = true;
            this.schedule_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schedule_data.Size = new System.Drawing.Size(833, 243);
            this.schedule_data.TabIndex = 7;
            this.schedule_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_data_CellContentClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // t_id
            // 
            this.t_id.DataPropertyName = "time_id";
            this.t_id.HeaderText = "Time ";
            this.t_id.Name = "t_id";
            this.t_id.ReadOnly = true;
            // 
            // l_from
            // 
            this.l_from.DataPropertyName = "location_from";
            this.l_from.HeaderText = "From";
            this.l_from.Name = "l_from";
            this.l_from.ReadOnly = true;
            // 
            // l_to
            // 
            this.l_to.DataPropertyName = "location_to";
            this.l_to.HeaderText = "To";
            this.l_to.Name = "l_to";
            this.l_to.ReadOnly = true;
            // 
            // btn_add_bus
            // 
            this.btn_add_bus.Location = new System.Drawing.Point(369, 23);
            this.btn_add_bus.Name = "btn_add_bus";
            this.btn_add_bus.Size = new System.Drawing.Size(146, 23);
            this.btn_add_bus.TabIndex = 8;
            this.btn_add_bus.Text = "Schedule Bus";
            this.btn_add_bus.UseVisualStyleBackColor = true;
            this.btn_add_bus.Click += new System.EventHandler(this.btn_add_bus_Click);
            // 
            // cmb_bus_no
            // 
            this.cmb_bus_no.FormattingEnabled = true;
            this.cmb_bus_no.Location = new System.Drawing.Point(114, 25);
            this.cmb_bus_no.Name = "cmb_bus_no";
            this.cmb_bus_no.Size = new System.Drawing.Size(247, 21);
            this.cmb_bus_no.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bus Number";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(521, 23);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(146, 23);
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // BusScheduleNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 293);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_bus_no);
            this.Controls.Add(this.btn_add_bus);
            this.Controls.Add(this.schedule_data);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BusScheduleNew";
            this.Text = "New Bus Schedule";
            this.Load += new System.EventHandler(this.BusScheduleNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedule_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView schedule_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_to;
        private System.Windows.Forms.Button btn_add_bus;
        private System.Windows.Forms.ComboBox cmb_bus_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
    }
}