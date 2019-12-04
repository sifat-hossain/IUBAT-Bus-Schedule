namespace Entity_IUBAT.Presentation
{
    partial class Time
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
            this.time_hour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.time_min = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.time_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_min)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Slot";
            // 
            // time_hour
            // 
            this.time_hour.Location = new System.Drawing.Point(121, 42);
            this.time_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.time_hour.Name = "time_hour";
            this.time_hour.Size = new System.Drawing.Size(56, 21);
            this.time_hour.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // time_min
            // 
            this.time_min.Location = new System.Drawing.Point(204, 42);
            this.time_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.time_min.Name = "time_min";
            this.time_min.Size = new System.Drawing.Size(56, 21);
            this.time_min.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(121, 104);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(87, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 158);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.time_min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time_hour);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(319, 196);
            this.MinimumSize = new System.Drawing.Size(319, 196);
            this.Name = "Time";
            this.Text = "Time";
            ((System.ComponentModel.ISupportInitialize)(this.time_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown time_hour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown time_min;
        private System.Windows.Forms.Button btn_Save;
    }
}