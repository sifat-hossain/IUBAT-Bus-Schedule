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
    public partial class BusSchedulePassanger : Form
    {
        public BusSchedulePassanger()
        {
            InitializeComponent();
        }

        private void data_bus_schedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BusSchedulePassanger_Load(object sender, EventArgs e)
        {
            Entity.DAL.BusSchedule bs = new Entity.DAL.BusSchedule();
            DataSet ds = bs.Select();

            if (ds == null)
            {
                MessageBox.Show(bs.Error);
                return;
            }

            data_bus_schedule.DataSource = ds.Tables[0];
        }
    }
}
