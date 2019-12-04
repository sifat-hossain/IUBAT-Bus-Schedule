namespace Entity_IUBAT.Presentation
{
    partial class ChangePasswordAdmin
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
            this.btn_cancel_ad = new System.Windows.Forms.Button();
            this.btn_change_pass_ad = new System.Windows.Forms.Button();
            this.btn_adcheck = new System.Windows.Forms.Button();
            this.txt_adnewRepeat = new System.Windows.Forms.TextBox();
            this.txt_adnew = new System.Windows.Forms.TextBox();
            this.txt_adcurrent = new System.Windows.Forms.TextBox();
            this.labeladr = new System.Windows.Forms.Label();
            this.labeladn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_show_pass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_cancel_ad
            // 
            this.btn_cancel_ad.Location = new System.Drawing.Point(344, 189);
            this.btn_cancel_ad.Name = "btn_cancel_ad";
            this.btn_cancel_ad.Size = new System.Drawing.Size(107, 23);
            this.btn_cancel_ad.TabIndex = 17;
            this.btn_cancel_ad.Text = "Cancel";
            this.btn_cancel_ad.UseVisualStyleBackColor = true;
            this.btn_cancel_ad.Visible = false;
            this.btn_cancel_ad.Click += new System.EventHandler(this.btn_cancel_ad_Click);
            // 
            // btn_change_pass_ad
            // 
            this.btn_change_pass_ad.Location = new System.Drawing.Point(211, 189);
            this.btn_change_pass_ad.Name = "btn_change_pass_ad";
            this.btn_change_pass_ad.Size = new System.Drawing.Size(107, 23);
            this.btn_change_pass_ad.TabIndex = 16;
            this.btn_change_pass_ad.Text = "Save Changes";
            this.btn_change_pass_ad.UseVisualStyleBackColor = true;
            this.btn_change_pass_ad.Visible = false;
            this.btn_change_pass_ad.Click += new System.EventHandler(this.btn_change_pass_ad_Click);
            // 
            // btn_adcheck
            // 
            this.btn_adcheck.Location = new System.Drawing.Point(211, 70);
            this.btn_adcheck.Name = "btn_adcheck";
            this.btn_adcheck.Size = new System.Drawing.Size(150, 23);
            this.btn_adcheck.TabIndex = 15;
            this.btn_adcheck.Text = "Change Password";
            this.btn_adcheck.UseVisualStyleBackColor = true;
            this.btn_adcheck.Click += new System.EventHandler(this.btn_adcheck_Click);
            // 
            // txt_adnewRepeat
            // 
            this.txt_adnewRepeat.Location = new System.Drawing.Point(211, 151);
            this.txt_adnewRepeat.Name = "txt_adnewRepeat";
            this.txt_adnewRepeat.Size = new System.Drawing.Size(240, 21);
            this.txt_adnewRepeat.TabIndex = 14;
            this.txt_adnewRepeat.Visible = false;
            // 
            // txt_adnew
            // 
            this.txt_adnew.Location = new System.Drawing.Point(211, 108);
            this.txt_adnew.Name = "txt_adnew";
            this.txt_adnew.Size = new System.Drawing.Size(240, 21);
            this.txt_adnew.TabIndex = 13;
            this.txt_adnew.Visible = false;
            // 
            // txt_adcurrent
            // 
            this.txt_adcurrent.Location = new System.Drawing.Point(211, 30);
            this.txt_adcurrent.Name = "txt_adcurrent";
            this.txt_adcurrent.Size = new System.Drawing.Size(240, 21);
            this.txt_adcurrent.TabIndex = 12;
            // 
            // labeladr
            // 
            this.labeladr.AutoSize = true;
            this.labeladr.Location = new System.Drawing.Point(50, 154);
            this.labeladr.Name = "labeladr";
            this.labeladr.Size = new System.Drawing.Size(142, 13);
            this.labeladr.TabIndex = 11;
            this.labeladr.Text = "Re Enter New Password";
            this.labeladr.Visible = false;
            // 
            // labeladn
            // 
            this.labeladn.AutoSize = true;
            this.labeladn.Location = new System.Drawing.Point(103, 111);
            this.labeladn.Name = "labeladn";
            this.labeladn.Size = new System.Drawing.Size(89, 13);
            this.labeladn.TabIndex = 10;
            this.labeladn.Text = "New Password";
            this.labeladn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Password";
            // 
            // chk_show_pass
            // 
            this.chk_show_pass.AutoSize = true;
            this.chk_show_pass.Location = new System.Drawing.Point(483, 33);
            this.chk_show_pass.Name = "chk_show_pass";
            this.chk_show_pass.Size = new System.Drawing.Size(57, 17);
            this.chk_show_pass.TabIndex = 18;
            this.chk_show_pass.Text = "Show";
            this.chk_show_pass.UseVisualStyleBackColor = true;
            this.chk_show_pass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChangePasswordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 251);
            this.Controls.Add(this.chk_show_pass);
            this.Controls.Add(this.btn_cancel_ad);
            this.Controls.Add(this.btn_change_pass_ad);
            this.Controls.Add(this.btn_adcheck);
            this.Controls.Add(this.txt_adnewRepeat);
            this.Controls.Add(this.txt_adnew);
            this.Controls.Add(this.txt_adcurrent);
            this.Controls.Add(this.labeladr);
            this.Controls.Add(this.labeladn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(576, 289);
            this.MinimumSize = new System.Drawing.Size(576, 289);
            this.Name = "ChangePasswordAdmin";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_ad;
        private System.Windows.Forms.Button btn_change_pass_ad;
        private System.Windows.Forms.Button btn_adcheck;
        private System.Windows.Forms.TextBox txt_adnewRepeat;
        private System.Windows.Forms.TextBox txt_adnew;
        private System.Windows.Forms.TextBox txt_adcurrent;
        private System.Windows.Forms.Label labeladr;
        private System.Windows.Forms.Label labeladn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_show_pass;
    }
}