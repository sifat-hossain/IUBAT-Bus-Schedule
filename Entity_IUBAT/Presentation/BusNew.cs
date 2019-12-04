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
    public partial class BusNew : Form
    {
        ErrorProvider ep = new ErrorProvider();

        public BusNew()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_saveBus_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;


            if (txt_busNumber.Text == "")
            {
                er++;
                ep.SetError(txt_busNumber, "Required");
            }

            if (txt_numberPlate.Text == "")
            {
                er++;
                ep.SetError(txt_numberPlate, "Required");
            }

            if (txt_maxCapacity.Text == "")
            {
                er++;
                ep.SetError(txt_maxCapacity, "Required");
            }

            if (er > 0)
                return;

            Entity.DAL.Bus b = new Entity.DAL.Bus();
            b.Bus_Number = txt_busNumber.Text;
            b.Number_Plate = txt_numberPlate.Text;
            b.Max_Capacity = Convert.ToInt32(txt_maxCapacity.Text);

            if (b.Insert())
            {
                MessageBox.Show("Bus Data Inserted");
                txt_busNumber.Text = "";
                txt_numberPlate.Text = "";
                txt_maxCapacity.Text = "";
                txt_busNumber.Focus();
            }
            else
            {
                MessageBox.Show(b.Error);
            }
        }
    }
}
