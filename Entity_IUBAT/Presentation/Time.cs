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
    public partial class Time : Form
    {
        ErrorProvider ep = new ErrorProvider();
        Entity.DAL.Time_Schedule ts = new Entity.DAL.Time_Schedule();

        public Time()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (time_hour.Value.ToString() == "" || time_min.Value.ToString() == "")
            {
                er++;
                ep.SetError(time_min, "Invalid Time");
            }

            if (er > 0)
                return;

            string t = time_hour.Value.ToString() + ":" + time_min.Value.ToString();

            ts.Schedule_time = t;

            if (ts.Insert())
            {
                time_hour.Value = 0;
                time_min.Value = 0;
                time_hour.Focus();
                MessageBox.Show("Time Slot Inserted");
            }
            else
            {
                MessageBox.Show(ts.Error);
            }


        }
    }
}
