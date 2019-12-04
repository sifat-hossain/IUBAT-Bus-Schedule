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
    public partial class ScheduleEdit : Form
    {
        ErrorProvider ep = new ErrorProvider();
        Entity.DAL.Location l = new Entity.DAL.Location();
        Entity.DAL.Time_Schedule ts = new Entity.DAL.Time_Schedule();
        Entity.DAL.Schedule s = new Entity.DAL.Schedule();
        Entity.DAL.Time_Schedule time = new Entity.DAL.Time_Schedule();
       
        public ScheduleEdit(int id)
        {
            InitializeComponent();
            s.Id = id;

            if (!s.SelectById())
            {
                MessageBox.Show("Not Found!");
                Close();
            }

        }

        private void ScheduleEdit_Load(object sender, EventArgs e)
        {
            cmb_time.DataSource = ts.Select().Tables[0];
            cmb_time.DisplayMember = "schedule_time";
            cmb_time.ValueMember = "id";
            cmb_time.SelectedValue = s.Time_ID;

            
            cmb_from.DataSource = l.Select().Tables[0];
            cmb_from.DisplayMember = "name";
            cmb_from.ValueMember = "id";
            cmb_from.SelectedValue = s.Location_From;

            cmb_to.DataSource = l.Select().Tables[0];
            cmb_to.DisplayMember = "name";
            cmb_to.ValueMember = "id";
            cmb_to.SelectedValue = s.Location_To;

            cmb_sType.Items.Add("Departing");
            cmb_sType.Items.Add("Incoming");

            if (s.Location_From == 1)
            {
                cmb_sType.SelectedIndex = 0;
                cmb_from.Enabled = false;

            }
            if (s.Location_To == 1)
            {
                cmb_sType.SelectedIndex = 1;
                cmb_to.Enabled = false;
            }

        }

     

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (cmb_time.SelectedValue == null || cmb_time.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmb_time, "Required");
            }

            if (cmb_from.SelectedValue == null || cmb_from.SelectedValue.ToString()== "")
            {
                er++;
                ep.SetError(cmb_from, "Required");
            }

            if (cmb_to.SelectedValue == null || cmb_to.SelectedValue.ToString()== "")
            {
                er++;
                ep.SetError(cmb_to, "Required");
            }

            if (er > 0)
                return;

            s.Time_ID = Convert.ToInt32(cmb_time.SelectedValue.ToString());
            s.Location_From = Convert.ToInt32(cmb_from.SelectedValue.ToString());
            s.Location_To = Convert.ToInt32(cmb_to.SelectedValue.ToString());
            if (s.Location_From != s.Location_To)
            {
                
                if(s.ScheduleAlreadyExist())
                {
                    MessageBox.Show("Can Not Update, Schedule Already Exists!");
                    return;
                }
                
                if (s.Update())
                {
                    MessageBox.Show("Schedule Updated");
                    cmb_time.Focus();
                }
                else
                {
                    MessageBox.Show(s.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Route Selection");
            }
        }

        private void cmb_sType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_sType.SelectedIndex == 1)
            {
                cmb_from.Enabled = true;
                cmb_to.SelectedValue = 1;
                cmb_to.Enabled = false;
            }

            if (cmb_sType.SelectedIndex == 0)
            {
                cmb_to.Enabled = true;
                cmb_from.SelectedValue = 1;
                cmb_from.Enabled = false;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
