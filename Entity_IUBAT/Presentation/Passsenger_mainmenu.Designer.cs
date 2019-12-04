namespace Entity_IUBAT.Presentation
{
    partial class Passsenger_mainmenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltyInormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_notification = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.busBookingToolStripMenuItem,
            this.incidentReportToolStripMenuItem,
            this.busScheduleToolStripMenuItem,
            this.penaltyInormationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.MouseHover += new System.EventHandler(this.profileToolStripMenuItem_MouseHover);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.myProfileToolStripMenuItem.Text = "&My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // busBookingToolStripMenuItem
            // 
            this.busBookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookBusToolStripMenuItem,
            this.cancelBookingToolStripMenuItem});
            this.busBookingToolStripMenuItem.Name = "busBookingToolStripMenuItem";
            this.busBookingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.busBookingToolStripMenuItem.Text = "Booking";
            this.busBookingToolStripMenuItem.Click += new System.EventHandler(this.busBookingToolStripMenuItem_Click);
            this.busBookingToolStripMenuItem.MouseHover += new System.EventHandler(this.busBookingToolStripMenuItem_MouseHover);
            // 
            // bookBusToolStripMenuItem
            // 
            this.bookBusToolStripMenuItem.Name = "bookBusToolStripMenuItem";
            this.bookBusToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bookBusToolStripMenuItem.Text = "&Book Bus";
            this.bookBusToolStripMenuItem.Click += new System.EventHandler(this.bookBusToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cancelBookingToolStripMenuItem.Text = "&Cancel Booking";
            this.cancelBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelBookingToolStripMenuItem_Click);
            // 
            // incidentReportToolStripMenuItem
            // 
            this.incidentReportToolStripMenuItem.Name = "incidentReportToolStripMenuItem";
            this.incidentReportToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.incidentReportToolStripMenuItem.Text = "Incident Report";
            this.incidentReportToolStripMenuItem.Click += new System.EventHandler(this.incidentReportToolStripMenuItem_Click);
            // 
            // busScheduleToolStripMenuItem
            // 
            this.busScheduleToolStripMenuItem.Name = "busScheduleToolStripMenuItem";
            this.busScheduleToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.busScheduleToolStripMenuItem.Text = "Bus Schedule Information";
            this.busScheduleToolStripMenuItem.Click += new System.EventHandler(this.busScheduleToolStripMenuItem_Click);
            // 
            // penaltyInormationToolStripMenuItem
            // 
            this.penaltyInormationToolStripMenuItem.Name = "penaltyInormationToolStripMenuItem";
            this.penaltyInormationToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.penaltyInormationToolStripMenuItem.Text = "Penalty Inormation";
            this.penaltyInormationToolStripMenuItem.Click += new System.EventHandler(this.penaltyInormationToolStripMenuItem_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_log_out.Location = new System.Drawing.Point(794, 0);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(87, 23);
            this.btn_log_out.TabIndex = 1;
            this.btn_log_out.Text = "Log out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldate.Location = new System.Drawing.Point(31, 37);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(84, 25);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "label1";
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbltimer.Location = new System.Drawing.Point(28, 5);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(114, 35);
            this.lbltimer.TabIndex = 2;
            this.lbltimer.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lbltimer);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Location = new System.Drawing.Point(543, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 68);
            this.panel1.TabIndex = 6;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(17, 36);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 13);
            this.Date.TabIndex = 1;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(17, 12);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 13);
            this.lbltime.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_notification);
            this.panel2.Location = new System.Drawing.Point(118, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 68);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lbl_notification
            // 
            this.lbl_notification.AutoSize = true;
            this.lbl_notification.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notification.Location = new System.Drawing.Point(12, 12);
            this.lbl_notification.Name = "lbl_notification";
            this.lbl_notification.Size = new System.Drawing.Size(77, 23);
            this.lbl_notification.TabIndex = 8;
            this.lbl_notification.Text = "label1";
            this.lbl_notification.Click += new System.EventHandler(this.lbl_notification_Click);
            // 
            // Passsenger_mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Passsenger_mainmenu";
            this.Text = "Passsenger Main Menu";
            this.Load += new System.EventHandler(this.Passsenger_mainmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busScheduleToolStripMenuItem;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltyInormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_notification;
    }
}