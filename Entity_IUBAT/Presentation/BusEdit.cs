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
    public partial class BusEdit : Form
    {
        Entity.DAL.Bus b = new Entity.DAL.Bus();
        ErrorProvider ep = new ErrorProvider();
        public BusEdit(int id)
        {
            InitializeComponent();

            b.Id = id;

            if (!b.SelectById())
            {
                MessageBox.Show("Not Found!");
                Close();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BusEdit_Load(object sender, EventArgs e)
        {
            txt_busNumber.Text = b.Bus_Number;
            txt_numberPlate.Text = b.Number_Plate;
            txt_maxCapacity.Text = b.Max_Capacity.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
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

            b.Bus_Number = txt_busNumber.Text;
            b.Number_Plate = txt_numberPlate.Text;
            b.Max_Capacity = Convert.ToInt32(txt_maxCapacity.Text);

            if (b.Update())
            {
                MessageBox.Show("Bus Data Updated ! ");
                txt_busNumber.Focus();
            }
            else
            {
                MessageBox.Show(b.Error);
            }
        }
    }
}
