using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_IUBAT.Presentation
{
    public partial class ScheduleNew : Form
    {
        ErrorProvider ep = new ErrorProvider();
        Entity.DAL.Location l = new Entity.DAL.Location();
        Entity.DAL.Time_Schedule ts = new Entity.DAL.Time_Schedule();
        Entity.DAL.Schedule s = new Entity.DAL.Schedule();
        public ScheduleNew()
        {
            InitializeComponent();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (cmb_scheduleType.SelectedIndex.ToString() == "-1")
            {
                er++;
                ep.SetError(cmb_scheduleType, "Required");
            }


            if (cmb_time.Text == "" || cmb_time.SelectedValue == null)
            {
                er++;
                ep.SetError(cmb_time, "Required");
            }

            if (cmb_from.Text == "" || cmb_from.SelectedValue ==  null)
            {
                er++;
                ep.SetError(cmb_from, "Requried");
            }
            

            if (er > 0)
                return;

            s.Time_ID = Convert.ToInt32(cmb_time.SelectedValue.ToString());
            if (cmb_scheduleType.SelectedIndex.ToString() == "0")
            {
                s.Location_To = Convert.ToInt32(cmb_from.SelectedValue.ToString());
                s.Location_From = 1;
            }
            if (cmb_scheduleType.SelectedIndex.ToString() == "1")
            {
                s.Location_From = Convert.ToInt32(cmb_from.SelectedValue.ToString());
                s.Location_To = 1;
            }


            if (s.Location_From == s.Location_To)
            {
                MessageBox.Show("Invalid Route Selection! Departure Location and Arrival Location Cannot be Same!");
                return;
            }

            if (s.ScheduleAlreadyExist())
            {
                MessageBox.Show("sSchedule Already Exists");
                return;
            }

            if (s.Insert())
            {
                cmb_time.SelectedValue = -1;
                cmb_from.SelectedValue = -1;

                MessageBox.Show("Schdedule Created");
            }
            else
            {
                MessageBox.Show("Something Went Wrong" + s.Error);
            }
            
        }

        private void ScheduleNew_Load(object sender, EventArgs e)
        {

            cmb_scheduleType.Items.Add("Departing");
            cmb_scheduleType.Items.Add("Incoming");
            cmb_scheduleType.SelectedIndex = -1; 



            cmb_time.DataSource = ts.Select().Tables[0];
            cmb_time.DisplayMember = "schedule_time";
            cmb_time.ValueMember = "id";
            cmb_time.SelectedValue = -1;

            cmb_from.DataSource = l.Select().Tables[0];
            cmb_from.DisplayMember = "name";
            cmb_from.ValueMember = "id";
            cmb_from.SelectedValue = -1;

       




        }

        private void time_hour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_scheduleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_scheduleType.SelectedIndex.ToString() == "0")
            {
                lbl_loc.Text = "Location To";
            }
            if (cmb_scheduleType.SelectedIndex.ToString() == "1")
            {
                lbl_loc.Text = "Location From";
            }
            if (cmb_scheduleType.SelectedIndex.ToString() == "-1" || cmb_scheduleType.SelectedIndex.ToString() == "")
            {
                return;
            }



        }
    }
}
