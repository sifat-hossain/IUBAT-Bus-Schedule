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
    public partial class BusScheduleNew : Form
    {
        Entity.DAL.BusSchedule bs = new Entity.DAL.BusSchedule();
        ErrorProvider ep = new ErrorProvider();
        public BusScheduleNew()
        {
            InitializeComponent();
        }

        private void BusScheduleNew_Load(object sender, EventArgs e)
        {
            btn_refresh.PerformClick();
            Entity.DAL.Bus b = new Entity.DAL.Bus();

            cmb_bus_no.DataSource = b.Select().Tables[0];
            cmb_bus_no.DisplayMember = "bus_number";
            cmb_bus_no.ValueMember = "id";
            cmb_bus_no.SelectedValue = -1;


        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Entity.DAL.Schedule s = new Entity.DAL.Schedule();
            
            DataSet ds = s.Select();

            if (ds == null)
            {
                MessageBox.Show(s.Error);
                return;
            }
            schedule_data.DataSource = ds.Tables[0];

            schedule_data.ClearSelection();

        }

        private void btn_add_bus_Click(object sender, EventArgs e)
        {

            ep.Clear();
            int er = 0;

            if (schedule_data.SelectedRows.Count<=0)
            {
                er++;
                MessageBox.Show("Please Select an Schedule to Allocate Bus");
            }

            if (cmb_bus_no.SelectedValue == null || cmb_bus_no.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(cmb_bus_no, "Required");
            }

            if (er > 0)
                return;

            bs.Bus_id = Convert.ToInt32(cmb_bus_no.SelectedValue.ToString());
            bs.Schedule_id = Convert.ToInt32(schedule_data.SelectedRows[0].Cells["colId"].Value.ToString());

            if (bs.Insert())
            {
                MessageBox.Show("Bus Scheduled!");

            }
            else
            {
                MessageBox.Show(bs.Error);
            }
        }

        private void schedule_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
