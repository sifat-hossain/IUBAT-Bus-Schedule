namespace Entity_IUBAT.Presentation
{
    partial class PenaltyEntry
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.data_cancle = new System.Windows.Forms.DataGridView();
            this.btn_pen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passanger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.passanger,
            this.from,
            this.to,
            this.time,
            this.bus,
            this.date,
            this.amount});
            this.data_cancle.Location = new System.Drawing.Point(3, 36);
            this.data_cancle.Name = "data_cancle";
            this.data_cancle.ReadOnly = true;
            this.data_cancle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_cancle.Size = new System.Drawing.Size(783, 396);
            this.data_cancle.TabIndex = 1;
            // 
            // btn_pen
            // 
            this.btn_pen.Location = new System.Drawing.Point(678, 7);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(88, 23);
            this.btn_pen.TabIndex = 2;
            this.btn_pen.Text = "Add Penalty";
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(225, 7);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(88, 23);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // passanger
            // 
            this.passanger.DataPropertyName = "passanger";
            this.passanger.HeaderText = "Passanger";
            this.passanger.Name = "passanger";
            this.passanger.ReadOnly = true;
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
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // PenaltyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 431);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_pen);
            this.Controls.Add(this.data_cancle);
            this.Name = "PenaltyEntry";
            this.Text = "Penalty Entry";
            this.Load += new System.EventHandler(this.PenaltyEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_cancle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView data_cancle;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn passanger;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}