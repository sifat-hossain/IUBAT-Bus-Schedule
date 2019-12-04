using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_IUBAT.Presentation
{
    public partial class MainMenu : Form
    {
        Presentation.Bus bus = new Bus();
        Presentation.Schedule schedule = new Schedule();
        Presentation.Location location = new Location();
        Presentation.Passanger passanger = new Presentation.Passanger();
        Presentation.AdminManager adminManager = new AdminManager();
        Presentation.Time time = new Presentation.Time();
        Presentation.BusSchedule busSchedule = new BusSchedule();
        Presentation.Booking_Report booking_Report = new Booking_Report();
        Presentation.PenaltyEntry penaltyEntry = new PenaltyEntry();
        Presentation.PenaltyDetails penaltyDetails = new PenaltyDetails();
        Presentation.IncidentAdmin incidentAdmin = new IncidentAdmin();
        //Entity.DAL.Admin admin = new Entity.DAL.Admin();

        string Session_id = "";
        string Session_name = "";
        public MainMenu(string adName, string adId)
        {
            InitializeComponent();
            this.Text = adName;
            Session_id = adId;
            Session_name = adName;

        }

        

        private void busInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bus.IsDisposed)
                bus = new Presentation.Bus();
            bus.MdiParent = this;
            bus.Show();
            bus.BringToFront();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login log = new frm_login();
            log.Show();
            log.BringToFront();

        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (location.IsDisposed)
                location = new Presentation.Location();
            location.MdiParent = this;
            location.Show();
            location.BringToFront();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void scheduleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (schedule.IsDisposed)
                schedule = new Presentation.Schedule();
            schedule.MdiParent = this;
            schedule.Show();
            schedule.BringToFront();
        }

        private void addTimeSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (time.IsDisposed)
                time = new Presentation.Time();
            time.MdiParent = this;
            time.Show();
            time.BringToFront();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void manageAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.AdminProfile ap = new AdminProfile(Session_name,Session_id);
            if (ap.IsDisposed)
                ap = new AdminProfile(Session_name,Session_id);
            ap.MdiParent = this;
            ap.Show();
            ap.BringToFront();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.ChangePasswordAdmin changePassword = new ChangePasswordAdmin(Session_name, Session_id);
            if (changePassword.IsDisposed)
                changePassword = new ChangePasswordAdmin(Session_name, Session_id);
            changePassword.MdiParent = this;
            changePassword.Show();
            changePassword.BringToFront();
        }

        private void manageAdminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminManager.IsDisposed)
                adminManager = new AdminManager();
            adminManager.MdiParent = this;
            adminManager.Show();
            adminManager.BringToFront();
        }

        private void busScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (busSchedule.IsDisposed)
                busSchedule = new BusSchedule();
            busSchedule.MdiParent = this;
            busSchedule.Show();
            busSchedule.BringToFront();

        }

        private void profileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            profileToolStripMenuItem.ShowDropDown();
        }

        private void usersToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            usersToolStripMenuItem.ShowDropDown();
        }

        private void scheduleToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            scheduleToolStripMenuItem.ShowDropDown();
        }

        private void reportToolStripMenuItem2_MouseHover(object sender, EventArgs e)
        {
            reportToolStripMenuItem2.ShowDropDown();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (passanger.IsDisposed)
                passanger = new Presentation.Passanger();
            passanger.MdiParent = this;
            passanger.Show();
            passanger.BringToFront();
        }

        private void bookingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (booking_Report.IsDisposed)
                booking_Report = new Presentation.Booking_Report();
            booking_Report.MdiParent = this;
            booking_Report.Show();
            booking_Report.BringToFront();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void penaltyEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (penaltyEntry.IsDisposed)
                penaltyEntry = new Presentation.PenaltyEntry();
            penaltyEntry.MdiParent = this;
            penaltyEntry.Show();
            penaltyEntry.BringToFront();
        }

        private void penaltyDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (penaltyDetails.IsDisposed)
                penaltyDetails = new PenaltyDetails();
            penaltyDetails.MdiParent = this;
            penaltyDetails.Show();
            penaltyDetails.BringToFront();
        }

        private void incidentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (incidentAdmin.IsDisposed)
                incidentAdmin = new IncidentAdmin();
            incidentAdmin.MdiParent = this;
            incidentAdmin.Show();
            incidentAdmin.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToLongTimeString().Replace(@".", @":");
            lbldate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
