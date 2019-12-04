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
    public partial class BusScheduleEdit : Form
    {
        Entity.DAL.BusSchedule bs = new Entity.DAL.BusSchedule();
        Entity.DAL.Schedule s = new Entity.DAL.Schedule();
        Entity.DAL.Location l = new Entity.DAL.Location();
        Entity.DAL.Bus b = new Entity.DAL.Bus();
        Entity.DAL.Time_Schedule ts = new Entity.DAL.Time_Schedule();
        ErrorProvider ep = new ErrorProvider();
        public BusScheduleEdit(int id)
        {
            InitializeComponent();
            bs.Id = id;

            if (!bs.SelectById())
            {
                MessageBox.Show("Not Found!");
                Close();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BusScheduleEdit_Load(object sender, EventArgs e)
        {
            s.Id = bs.Schedule_id;

            if (!s.SelectById())
            {
                MessageBox.Show("Something Went Wrong!");
                Close();
            }

            cmb_bus.DataSource = b.Select().Tables[0];
            cmb_bus.DisplayMember = "bus_number";
            cmb_bus.ValueMember = "id";
            cmb_bus.SelectedValue = bs.Bus_id;

            cmb_from.DataSource = l.Select().Tables[0];
            cmb_from.DisplayMember = "name";
            cmb_from.ValueMember = "id";
            cmb_from.SelectedValue = s.Location_From;

            cmb_to.DataSource = l.Select().Tables[0];
            cmb_to.DisplayMember = "name";
            cmb_to.ValueMember = "id";
            cmb_to.SelectedValue = s.Location_To;

            cmb_time.DataSource = ts.Select().Tables[0];
            cmb_time.DisplayMember = "schedule_time";
            cmb_time.ValueMember = "id";
            cmb_time.SelectedValue = s.Time_ID;

            cmb_time.Enabled = false;
            cmb_from.Enabled = false;
            cmb_to.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (cmb_bus.SelectedValue == null || cmb_bus.SelectedValue.ToString() == "")
            {
                er++;
                 ep.SetError(cmb_bus , "Required");
            }

            if (er > 0)
                return;

            bs.Bus_id = Convert.ToInt32(cmb_bus.SelectedValue.ToString());

            if (bs.Update())
            {
                MessageBox.Show("Bus Rescheduled!");
            }
            else
            {
                MessageBox.Show(bs.Error);
            }
            

        }
    }
}
