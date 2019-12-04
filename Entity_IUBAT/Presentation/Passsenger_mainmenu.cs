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

    
    public partial class Passsenger_mainmenu : Form

    {
        int LoginId = 0;
        string Session_id = "";
        string Session_name = "";
        Entity.DAL.Penalty penalty = new Entity.DAL.Penalty();
        public Passsenger_mainmenu(string psName, string psId, int id)
        {
            InitializeComponent();
            Session_id = psId;
            Session_name = psName;
            LoginId = id;
            this.Text = psName;
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_login l = new frm_login();
            l.Show();
            l.BringToFront();
        }

        private void busBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Passsenger_mainmenu_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            timer1.Start();

            penalty.pas_id = LoginId;

            penalty.notification();
            if (penalty.notification_count > 0)
            {
                lbl_notification.Text = "You Have " + penalty.notification_count + " Penalty Pending!! \nPlease Pay The Dues In time Or your Id May Get Blocked!!";
                lbl_notification.ForeColor = System.Drawing.Color.Red;
                panel2.BackColor = System.Drawing.Color.Yellow;
                panel2.Visible = true;
            }


        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.PassenegerProfile pss = new PassenegerProfile(Session_name,Session_id);
            if (pss.IsDisposed)
                pss = new PassenegerProfile(Session_name,Session_id);
            pss.MdiParent = this;
            pss.Show();
            pss.BringToFront();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.ChangePassword changePassword = new ChangePassword(Session_name,Session_id);
            if (changePassword.IsDisposed)
                changePassword = new ChangePassword(Session_name, Session_id);
            changePassword.MdiParent = this;
            changePassword.Show();
            changePassword.BringToFront();
        }

        private void incidentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.Incident incident = new Incident(LoginId);
            if (incident.IsDisposed)
                incident = new Incident(LoginId);
            incident.MdiParent = this;
            incident.Show();
            incident.BringToFront();
        }

        private void busScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.BusSchedulePassanger busSchedule = new BusSchedulePassanger();
            if (busSchedule.IsDisposed)
                busSchedule = new BusSchedulePassanger();
            busSchedule.MdiParent = this;
            busSchedule.Show();
            busSchedule.BringToFront();
        }

        private void penaltyInormationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.PenaltyPassanger penaltyPassanger = new PenaltyPassanger(LoginId);
            if (penaltyPassanger.IsDisposed)
                penaltyPassanger = new PenaltyPassanger(LoginId);
            penaltyPassanger.MdiParent = this;
            penaltyPassanger.Show();
            penaltyPassanger.BringToFront();
        }

        private void profileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            profileToolStripMenuItem.ShowDropDown();
        }

        private void busBookingToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            busBookingToolStripMenuItem.ShowDropDown();
        }

        private void bookBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.BusBooking bus_book = new BusBooking(LoginId);
            if (bus_book.IsDisposed)
                bus_book = new Presentation.BusBooking(LoginId);
            bus_book.MdiParent = this;
            bus_book.Show();
            bus_book.BringToFront();
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.CancleBooking cancleBooking = new CancleBooking(LoginId);
            if (cancleBooking.IsDisposed)
                cancleBooking = new Presentation.CancleBooking(LoginId);
            cancleBooking.MdiParent = this;
            cancleBooking.Show();
            cancleBooking.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToLongTimeString().Replace(@".", @":");
            lbldate.Text = DateTime.Now.ToLongDateString();

            if (DateTime.Now.Second % 2 == 0)
            {
                lbl_notification.ForeColor = System.Drawing.Color.Red;
                panel2.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                lbl_notification.ForeColor = System.Drawing.Color.Yellow;
                panel2.BackColor = System.Drawing.Color.Red;
            }

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Presentation.PenaltyPassanger penaltyPassanger = new PenaltyPassanger(LoginId);
            if (penaltyPassanger.IsDisposed)
                penaltyPassanger = new PenaltyPassanger(LoginId);
            penaltyPassanger.MdiParent = this;
            penaltyPassanger.Show();
            penaltyPassanger.BringToFront();
        }

        private void lbl_notification_Click(object sender, EventArgs e)
        {
            Presentation.PenaltyPassanger penaltyPassanger = new PenaltyPassanger(LoginId);
            if (penaltyPassanger.IsDisposed)
                penaltyPassanger = new PenaltyPassanger(LoginId);
            penaltyPassanger.MdiParent = this;
            penaltyPassanger.Show();
            penaltyPassanger.BringToFront();
        }
    }
}
