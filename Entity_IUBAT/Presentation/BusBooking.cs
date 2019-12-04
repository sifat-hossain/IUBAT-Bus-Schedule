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
    public partial class BusBooking : Form
    {
        Entity.DAL.Time_Schedule ts = new Entity.DAL.Time_Schedule();
        Entity.DAL.Location l = new Entity.DAL.Location();
        Entity.DAL.Bus b = new Entity.DAL.Bus();
        Entity.DAL.Schedule s = new Entity.DAL.Schedule();
        Entity.DAL.BusSchedule bs = new Entity.DAL.BusSchedule();
        Entity.DAL.Booking book = new Entity.DAL.Booking();
        ErrorProvider ep = new ErrorProvider();
        int SessionId = 0;

        public BusBooking(int id)
        {
            InitializeComponent();
            SessionId = id;
        }

        public void time_load()
        {
            cmbtime.DataSource = ts.Select().Tables[0];
            cmbtime.DisplayMember = "schedule_time";
            cmbtime.ValueMember = "id";
            cmbtime.SelectedValue = -1;
        }


        public void Loc_from_load()
        {
            cmbfrom.DataSource = l.Select().Tables[0];
            cmbfrom.DisplayMember = "name";
            cmbfrom.ValueMember = "id";
            cmbfrom.SelectedValue = -1;
        }

        public void Loc_to_load()
        {
            cmbto.DataSource = l.Select().Tables[0];
            cmbto.DisplayMember = "name";
            cmbto.ValueMember = "id";
            cmbto.SelectedValue = -1;
        }

        public void Bus_load()
        {
            cmbbus.DataSource = b.Select().Tables[0];
            cmbbus.DisplayMember = "bus_number";
            cmbbus.ValueMember = "id";
            cmbbus.SelectedValue = -1;
        }

        private void BusBooking_Load(object sender, EventArgs e)
        {
            time_load();
            Bus_load();
            cmb_type.Items.Add("Departing");
            cmb_type.Items.Add("Incoming");
            cmbfrom.Enabled = false;
            cmbto.Enabled = false;
            btn_avail.Visible = false;
            dtpBooking.MinDate = System.DateTime.Now.Date;
            dtpBooking.MaxDate = System.DateTime.Now.Date.AddMonths(1);


        }

        private void cmbfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cmbtime_SelectedIndexChanged(object sender, EventArgs e)
        {
          


            if (cmb_type.SelectedIndex == 0)
            {

                s.Location_From = 1;
                s.Time_ID = Convert.ToInt32(cmbtime.SelectedValue.ToString());
                DataSet ds = new DataSet();
                ds = s.SelectLocTo();

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Scheduled Location at This Time");
                   
                    return;

                }

                DataTable dt = new DataTable();
                dt.Columns.Add("name");
                dt.Columns.Add("id");
                DataRow dr = dt.NewRow();
                dr["name"] = "IUBAT Campus";
                dr["id"] = 1;
                dt.Rows.InsertAt(dr, 0);
                cmbfrom.DataSource = dt;
                cmbfrom.DisplayMember = "name";
                cmbfrom.ValueMember = "id";
                cmbfrom.SelectedValue = 1;
                cmbto.Enabled = true;
                cmbfrom.Enabled = true;
                
                
                DataTable dtto = ds.Tables[0];
                DataRow drto = dtto.NewRow();
                drto["loc_name"] = "--SELECT--";
                drto["loc_id"] = 0;
                dtto.Rows.InsertAt(drto, 0);
                cmbto.DataSource = dtto;
                cmbto.DisplayMember = "loc_name";
                cmbto.ValueMember = "loc_id";
                cmbto.SelectedValue = 0;

               
                


            }

            if (cmb_type.SelectedIndex == 1)
            {
                s.Location_To = 1;
                s.Time_ID = Convert.ToInt32(cmbtime.SelectedValue.ToString());
                DataSet dsn = new DataSet();
                dsn = s.SelectLocFrom();

                if (dsn.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Scheduled Location at This Time");
                  
                    return;

                }

                DataTable dtf = new DataTable();
                dtf.Columns.Add("name");
                dtf.Columns.Add("id");
                DataRow drf = dtf.NewRow();
                drf["name"] = "IUBAT Campus";
                drf["id"] = 1;
                dtf.Rows.InsertAt(drf, 0);
                cmbto.DataSource = dtf;
                cmbto.DisplayMember = "name";
                cmbto.ValueMember = "id";
                cmbto.SelectedValue = 1;
                cmbfrom.Enabled = true;
                cmbto.Enabled = true;
                

                

                DataTable dtfrom = dsn.Tables[0];
                DataRow drfrom = dtfrom.NewRow();
                drfrom["loc_name"] = "--SELECT--";
                drfrom["loc_id"] = 0;
                dtfrom.Rows.InsertAt(drfrom, 0);
                cmbfrom.DataSource = dtfrom;
                cmbfrom.DisplayMember = "loc_name";
                cmbfrom.ValueMember = "loc_id";
                cmbfrom.SelectedValue = 0;
           
            }


        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (cmb_type.SelectedIndex.ToString() == "-1")
            {
                er++;
                ep.SetError(cmb_type, "Required");
            }

            if (cmbtime.SelectedValue == null || cmbtime.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmbtime, "Required");
            }

            if (cmbto.SelectedValue == null || Convert.ToInt32(cmbto.SelectedValue) <= 0)
            {
                er++;
                ep.SetError(cmbto, "Required");
            }

            if (cmbfrom.SelectedValue == null || Convert.ToInt32(cmbfrom.SelectedValue) <= 0)
            {
                er++;
                ep.SetError(cmbfrom, "Required");
            }

            if (er > 0)
                return;


            s.Time_ID = Convert.ToInt32(cmbtime.SelectedValue);
            s.LOC_FROM = Convert.ToInt32(cmbfrom.SelectedValue);
            s.Location_To = Convert.ToInt32(cmbto.SelectedValue);
            s.SelectId();
            bs.Schedule_id = s.Id;
            //MessageBox.Show(bs.Schedule_id.ToString());
            DataSet ds = new DataSet();

            ds = bs.SelectBus();

            if (ds.Tables[0].Rows.Count == 0)
            {
                cmbbus.Enabled = false;
                MessageBox.Show("No Bus Scheduled");
                return;

            }

            cmbbus.DataSource = ds.Tables[0];
            cmbbus.DisplayMember = "bus_no";
            cmbbus.ValueMember = "bus_id";
            

            btn_avail.Visible = true;
            btn_avail.PerformClick();
            cmbbus.Enabled = true;
            btn_generate.Visible = false;
            btn_cancel.Visible = true;
            cmbbus.Visible = true;
            label5.Visible = true;
            cmbfrom.Enabled = false;
            cmbto.Enabled = false;
            cmbtime.Enabled = false;
            cmb_type.Enabled = false;
            dtpBooking.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_cancel.Visible = false;
            btn_avail.Visible = false;
            cmbbus.Visible = false;
            btn_generate.Visible = true;
            label5.Visible = false;
            cmb_type.Enabled = true;
            cmbtime.Enabled = true;
            dtpBooking.Enabled = true;
            cmbfrom.Enabled = false;
            cmbto.Enabled = false;
            lbl_available.Text = "";
            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            book.Passanger_id = SessionId;

            bs.Bus_id = Convert.ToInt32(cmbbus.SelectedValue.ToString());
            bs.SelectID();

            book.Schedule_id = bs.Id;
            book.Date = dtpBooking.Value.Date ;
            book.Booking_status = 1;
            book.SearchBookingForValidation();

            if (book.Count > 1)
            {
                MessageBox.Show("You Have Already Booked for today!");
                return;
            }


            if (book.Insert())
            {
                MessageBox.Show("Booking Confirmed");
                btn_avail.PerformClick();
            }
            else
            {
                MessageBox.Show(book.Error);
            }

        }

        private void cmbbus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btn_avail_Click(object sender, EventArgs e)
        {
            book.bus_id = Convert.ToInt32(cmbbus.SelectedValue);
            book.from_date = dtpBooking.Value.Date.ToShortDateString();
            book.available();
            b.Id = book.bus_id;
            b.SelectById();
            int available_seats = b.Max_Capacity - book.available_count;
       
            lbl_available.Text = "On : " + dtpBooking.Value.Date.ToShortDateString()  + "\nFrom  : " + cmbfrom.Text + "\nTo: " + cmbto.Text
                        + "\nAt : " + cmbtime.Text + "\nIn  :" + b.Bus_Number + "\nNumber of Available Seats are : " + available_seats;
           
        }
    }
}
