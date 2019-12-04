namespace Entity_IUBAT.Presentation
{
    partial class ChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_current = new System.Windows.Forms.TextBox();
            this.txt_new = new System.Windows.Forms.TextBox();
            this.txt_newRepeat = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_change_pass = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.chk_show_pass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re Enter New Password";
            this.label3.Visible = false;
            // 
            // txt_current
            // 
            this.txt_current.Location = new System.Drawing.Point(182, 34);
            this.txt_current.Name = "txt_current";
            this.txt_current.Size = new System.Drawing.Size(240, 21);
            this.txt_current.TabIndex = 3;
            // 
            // txt_new
            // 
            this.txt_new.Location = new System.Drawing.Point(182, 112);
            this.txt_new.Name = "txt_new";
            this.txt_new.Size = new System.Drawing.Size(240, 21);
            this.txt_new.TabIndex = 4;
            this.txt_new.Visible = false;
            // 
            // txt_newRepeat
            // 
            this.txt_newRepeat.Location = new System.Drawing.Point(182, 155);
            this.txt_newRepeat.Name = "txt_newRepeat";
            this.txt_newRepeat.Size = new System.Drawing.Size(240, 21);
            this.txt_newRepeat.TabIndex = 5;
            this.txt_newRepeat.Visible = false;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(182, 74);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(150, 23);
            this.btn_check.TabIndex = 6;
            this.btn_check.Text = "Change Password";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_change_pass
            // 
            this.btn_change_pass.Location = new System.Drawing.Point(182, 193);
            this.btn_change_pass.Name = "btn_change_pass";
            this.btn_change_pass.Size = new System.Drawing.Size(107, 23);
            this.btn_change_pass.TabIndex = 7;
            this.btn_change_pass.Text = "Save Changes";
            this.btn_change_pass.UseVisualStyleBackColor = true;
            this.btn_change_pass.Visible = false;
            this.btn_change_pass.Click += new System.EventHandler(this.btn_change_pass_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(315, 193);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // chk_show_pass
            // 
            this.chk_show_pass.AutoSize = true;
            this.chk_show_pass.Location = new System.Drawing.Point(440, 36);
            this.chk_show_pass.Name = "chk_show_pass";
            this.chk_show_pass.Size = new System.Drawing.Size(57, 17);
            this.chk_show_pass.TabIndex = 9;
            this.chk_show_pass.Text = "Show";
            this.chk_show_pass.UseVisualStyleBackColor = true;
            this.chk_show_pass.CheckedChanged += new System.EventHandler(this.chk_show_pass_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 243);
            this.Controls.Add(this.chk_show_pass);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_change_pass);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_newRepeat);
            this.Controls.Add(this.txt_new);
            this.Controls.Add(this.txt_current);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 281);
            this.MinimumSize = new System.Drawing.Size(533, 281);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_current;
        private System.Windows.Forms.TextBox txt_new;
        private System.Windows.Forms.TextBox txt_newRepeat;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_change_pass;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox chk_show_pass;
    }
}