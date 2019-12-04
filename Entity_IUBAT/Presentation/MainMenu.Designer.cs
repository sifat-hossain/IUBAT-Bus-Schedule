namespace Entity_IUBAT.Presentation
{
    partial class MainMenu
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
            this.manageAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAdminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltyEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltyDetilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTimeSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.lbl_ad_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.busInformationToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.reportToolStripMenuItem1,
            this.reportToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAdminToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.manageAdminsToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.profileToolStripMenuItem.Text = "&Profile";
            this.profileToolStripMenuItem.MouseHover += new System.EventHandler(this.profileToolStripMenuItem_MouseHover);
            // 
            // manageAdminToolStripMenuItem
            // 
            this.manageAdminToolStripMenuItem.Name = "manageAdminToolStripMenuItem";
            this.manageAdminToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.manageAdminToolStripMenuItem.Text = "&Current Admin Profile";
            this.manageAdminToolStripMenuItem.Click += new System.EventHandler(this.manageAdminToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change Password ";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // manageAdminsToolStripMenuItem
            // 
            this.manageAdminsToolStripMenuItem.Name = "manageAdminsToolStripMenuItem";
            this.manageAdminsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.manageAdminsToolStripMenuItem.Text = "Manage Admins";
            this.manageAdminsToolStripMenuItem.Click += new System.EventHandler(this.manageAdminsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.penaltyEntryToolStripMenuItem,
            this.penaltyDetilsToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.usersToolStripMenuItem.Text = "&Passanger";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            this.usersToolStripMenuItem.MouseHover += new System.EventHandler(this.usersToolStripMenuItem_MouseHover);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.detailsToolStripMenuItem.Text = "&Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // penaltyEntryToolStripMenuItem
            // 
            this.penaltyEntryToolStripMenuItem.Name = "penaltyEntryToolStripMenuItem";
            this.penaltyEntryToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.penaltyEntryToolStripMenuItem.Text = "&Penalty Entry";
            this.penaltyEntryToolStripMenuItem.Click += new System.EventHandler(this.penaltyEntryToolStripMenuItem_Click);
            // 
            // penaltyDetilsToolStripMenuItem
            // 
            this.penaltyDetilsToolStripMenuItem.Name = "penaltyDetilsToolStripMenuItem";
            this.penaltyDetilsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.penaltyDetilsToolStripMenuItem.Text = "&Penalty Details";
            this.penaltyDetilsToolStripMenuItem.Click += new System.EventHandler(this.penaltyDetilsToolStripMenuItem_Click);
            // 
            // busInformationToolStripMenuItem
            // 
            this.busInformationToolStripMenuItem.Name = "busInformationToolStripMenuItem";
            this.busInformationToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.busInformationToolStripMenuItem.Text = "&Bus Information";
            this.busInformationToolStripMenuItem.Click += new System.EventHandler(this.busInformationToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTimeSlotToolStripMenuItem,
            this.scheduleDetailsToolStripMenuItem,
            this.busScheduleToolStripMenuItem});
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.scheduleToolStripMenuItem.Text = "&Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            this.scheduleToolStripMenuItem.MouseHover += new System.EventHandler(this.scheduleToolStripMenuItem_MouseHover);
            // 
            // addTimeSlotToolStripMenuItem
            // 
            this.addTimeSlotToolStripMenuItem.Name = "addTimeSlotToolStripMenuItem";
            this.addTimeSlotToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addTimeSlotToolStripMenuItem.Text = "&Add Time Slot";
            this.addTimeSlotToolStripMenuItem.Click += new System.EventHandler(this.addTimeSlotToolStripMenuItem_Click);
            // 
            // scheduleDetailsToolStripMenuItem
            // 
            this.scheduleDetailsToolStripMenuItem.Name = "scheduleDetailsToolStripMenuItem";
            this.scheduleDetailsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.scheduleDetailsToolStripMenuItem.Text = "&Schedule Details";
            this.scheduleDetailsToolStripMenuItem.Click += new System.EventHandler(this.scheduleDetailsToolStripMenuItem_Click);
            // 
            // busScheduleToolStripMenuItem
            // 
            this.busScheduleToolStripMenuItem.Name = "busScheduleToolStripMenuItem";
            this.busScheduleToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.busScheduleToolStripMenuItem.Text = "&Bus Schedule";
            this.busScheduleToolStripMenuItem.Click += new System.EventHandler(this.busScheduleToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.reportToolStripMenuItem1.Text = "&Location";
            this.reportToolStripMenuItem1.Click += new System.EventHandler(this.reportToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem2
            // 
            this.reportToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingReportToolStripMenuItem,
            this.incidentReportToolStripMenuItem});
            this.reportToolStripMenuItem2.Name = "reportToolStripMenuItem2";
            this.reportToolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.reportToolStripMenuItem2.Text = "&Report";
            this.reportToolStripMenuItem2.MouseHover += new System.EventHandler(this.reportToolStripMenuItem2_MouseHover);
            // 
            // bookingReportToolStripMenuItem
            // 
            this.bookingReportToolStripMenuItem.Name = "bookingReportToolStripMenuItem";
            this.bookingReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bookingReportToolStripMenuItem.Text = "&Booking Report";
            this.bookingReportToolStripMenuItem.Click += new System.EventHandler(this.bookingReportToolStripMenuItem_Click);
            // 
            // incidentReportToolStripMenuItem
            // 
            this.incidentReportToolStripMenuItem.Name = "incidentReportToolStripMenuItem";
            this.incidentReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.incidentReportToolStripMenuItem.Text = "&Incident Report";
            this.incidentReportToolStripMenuItem.Click += new System.EventHandler(this.incidentReportToolStripMenuItem_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logOut.Location = new System.Drawing.Point(731, 1);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(114, 23);
            this.btn_logOut.TabIndex = 1;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // lbl_ad_name
            // 
            this.lbl_ad_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ad_name.AutoSize = true;
            this.lbl_ad_name.Location = new System.Drawing.Point(728, 27);
            this.lbl_ad_name.Name = "lbl_ad_name";
            this.lbl_ad_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_ad_name.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lbltimer);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Location = new System.Drawing.Point(512, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 68);
            this.panel1.TabIndex = 5;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_ad_name);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(863, 466);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addTimeSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busScheduleToolStripMenuItem;
        private System.Windows.Forms.Label lbl_ad_name;
        private System.Windows.Forms.ToolStripMenuItem manageAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAdminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltyEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltyDetilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentReportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltimer;
    }
}