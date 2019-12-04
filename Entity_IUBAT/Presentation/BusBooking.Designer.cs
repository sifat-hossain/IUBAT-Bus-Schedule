namespace Entity_IUBAT.Presentation
{
    partial class BusBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBooking = new System.Windows.Forms.DateTimePicker();
            this.cmbtime = new System.Windows.Forms.ComboBox();
            this.cmbto = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.cmbfrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbus = new System.Windows.Forms.ComboBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_available = new System.Windows.Forms.Label();
            this.btn_avail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // dtpBooking
            // 
            this.dtpBooking.Location = new System.Drawing.Point(103, 80);
            this.dtpBooking.Name = "dtpBooking";
            this.dtpBooking.Size = new System.Drawing.Size(219, 21);
            this.dtpBooking.TabIndex = 1;
            // 
            // cmbtime
            // 
            this.cmbtime.FormattingEnabled = true;
            this.cmbtime.Location = new System.Drawing.Point(66, 157);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(102, 21);
            this.cmbtime.TabIndex = 2;
            this.cmbtime.SelectedIndexChanged += new System.EventHandler(this.cmbtime_SelectedIndexChanged);
            // 
            // cmbto
            // 
            this.cmbto.FormattingEnabled = true;
            this.cmbto.Location = new System.Drawing.Point(510, 157);
            this.cmbto.Name = "cmbto";
            this.cmbto.Size = new System.Drawing.Size(202, 21);
            this.cmbto.TabIndex = 3;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(241, 319);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(87, 23);
            this.btnsubmit.TabIndex = 4;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // cmbfrom
            // 
            this.cmbfrom.FormattingEnabled = true;
            this.cmbfrom.Location = new System.Drawing.Point(241, 157);
            this.cmbfrom.Name = "cmbfrom";
            this.cmbfrom.Size = new System.Drawing.Size(189, 21);
            this.cmbfrom.TabIndex = 5;
            this.cmbfrom.SelectedIndexChanged += new System.EventHandler(this.cmbfrom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Booking Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bus No.";
            this.label5.Visible = false;
            // 
            // cmbbus
            // 
            this.cmbbus.FormattingEnabled = true;
            this.cmbbus.Location = new System.Drawing.Point(241, 203);
            this.cmbbus.Name = "cmbbus";
            this.cmbbus.Size = new System.Drawing.Size(189, 21);
            this.cmbbus.TabIndex = 10;
            this.cmbbus.Visible = false;
            this.cmbbus.SelectedIndexChanged += new System.EventHandler(this.cmbbus_SelectedIndexChanged);
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(103, 19);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(219, 21);
            this.cmb_type.TabIndex = 11;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "To";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(510, 201);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(163, 23);
            this.btn_generate.TabIndex = 13;
            this.btn_generate.Text = "See Available Bus";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(555, 259);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.Location = new System.Drawing.Point(35, 240);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(0, 13);
            this.lbl_available.TabIndex = 15;
            // 
            // btn_avail
            // 
            this.btn_avail.Location = new System.Drawing.Point(532, 230);
            this.btn_avail.Name = "btn_avail";
            this.btn_avail.Size = new System.Drawing.Size(120, 23);
            this.btn_avail.TabIndex = 16;
            this.btn_avail.Text = "Availability";
            this.btn_avail.UseVisualStyleBackColor = true;
            this.btn_avail.Click += new System.EventHandler(this.btn_avail_Click);
            // 
            // BusBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 354);
            this.Controls.Add(this.btn_avail);
            this.Controls.Add(this.lbl_available);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.cmbbus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbfrom);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.cmbto);
            this.Controls.Add(this.cmbtime);
            this.Controls.Add(this.dtpBooking);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "BusBooking";
            this.Text = "Bus Booking";
            this.Load += new System.EventHandler(this.BusBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBooking;
        private System.Windows.Forms.ComboBox cmbtime;
        private System.Windows.Forms.ComboBox cmbto;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ComboBox cmbfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbus;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_available;
        private System.Windows.Forms.Button btn_avail;
    }
}