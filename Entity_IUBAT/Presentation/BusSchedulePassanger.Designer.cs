namespace Entity_IUBAT.Presentation
{
    partial class BusSchedulePassanger
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
            this.data_bus_schedule = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_bus_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // data_bus_schedule
            // 
            this.data_bus_schedule.AllowUserToAddRows = false;
            this.data_bus_schedule.AllowUserToDeleteRows = false;
            this.data_bus_schedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_bus_schedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_bus_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bus_schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.time,
            this.location_from,
            this.location_to,
            this.bus_number});
            this.data_bus_schedule.Location = new System.Drawing.Point(-6, 4);
            this.data_bus_schedule.Name = "data_bus_schedule";
            this.data_bus_schedule.ReadOnly = true;
            this.data_bus_schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_bus_schedule.Size = new System.Drawing.Size(929, 563);
            this.data_bus_schedule.TabIndex = 6;
            this.data_bus_schedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_bus_schedule_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // location_from
            // 
            this.location_from.DataPropertyName = "loc_from";
            this.location_from.HeaderText = "From";
            this.location_from.Name = "location_from";
            this.location_from.ReadOnly = true;
            // 
            // location_to
            // 
            this.location_to.DataPropertyName = "loc_to";
            this.location_to.HeaderText = "To";
            this.location_to.Name = "location_to";
            this.location_to.ReadOnly = true;
            // 
            // bus_number
            // 
            this.bus_number.DataPropertyName = "bus_no";
            this.bus_number.HeaderText = "Bus Number";
            this.bus_number.Name = "bus_number";
            this.bus_number.ReadOnly = true;
            // 
            // BusSchedulePassanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 562);
            this.Controls.Add(this.data_bus_schedule);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(936, 600);
            this.MinimumSize = new System.Drawing.Size(936, 600);
            this.Name = "BusSchedulePassanger";
            this.Text = "Bus Schedule";
            this.Load += new System.EventHandler(this.BusSchedulePassanger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_bus_schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_bus_schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_number;
    }
}