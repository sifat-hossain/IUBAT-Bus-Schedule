namespace Entity_IUBAT.Presentation
{
    partial class CancleBooking
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
            this.data_cancle = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_ref = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_cancle)).BeginInit();
            this.SuspendLayout();
            // 
            // data_cancle
            // 
            this.data_cancle.AllowUserToAddRows = false;
            this.data_cancle.AllowUserToDeleteRows = false;
            this.data_cancle.AllowUserToResizeColumns = false;
            this.data_cancle.AllowUserToResizeRows = false;
            this.data_cancle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_cancle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cancle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.from,
            this.to,
            this.time,
            this.bus,
            this.date});
            this.data_cancle.Location = new System.Drawing.Point(-4, 32);
            this.data_cancle.Name = "data_cancle";
            this.data_cancle.ReadOnly = true;
            this.data_cancle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_cancle.Size = new System.Drawing.Size(707, 337);
            this.data_cancle.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // from
            // 
            this.from.DataPropertyName = "from";
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.DataPropertyName = "to";
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // bus
            // 
            this.bus.DataPropertyName = "bus";
            this.bus.HeaderText = "Bus";
            this.bus.Name = "bus";
            this.bus.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(3, 3);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(145, 23);
            this.btn_cancle.TabIndex = 1;
            this.btn_cancle.Text = "Cancel Selected Booking";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Location = new System.Drawing.Point(154, 3);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(75, 23);
            this.btn_ref.TabIndex = 2;
            this.btn_ref.Text = "Refresh";
            this.btn_ref.UseVisualStyleBackColor = true;
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // CancleBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 364);
            this.Controls.Add(this.btn_ref);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.data_cancle);
            this.MaximizeBox = false;
            this.Name = "CancleBooking";
            this.Text = "Cancle Booking";
            this.Load += new System.EventHandler(this.CancleBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_cancle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_cancle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_ref;
    }
}