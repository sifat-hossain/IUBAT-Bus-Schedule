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
    public partial class LocationNew : Form
    {
        ErrorProvider ep = new ErrorProvider();

        public LocationNew()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;


            if (txt_name.Text == "")
            {
                er++;
                ep.SetError(txt_name, "Required");
            }
           
            if (txt_city.Text == "")
            {
                er++;
                ep.SetError(txt_city, "Required");
            }

            if (er > 0)
                return;

            Entity.DAL.Location loc = new Entity.DAL.Location();
            loc.Name = txt_name.Text;
            loc.City = txt_city.Text;

            if (loc.Insert())
            {
                MessageBox.Show("Location Data Inserted");
                txt_name.Text = "";
                txt_city.Text = "";
                txt_name.Focus();
            }
            else
            {
                MessageBox.Show(loc.Error);
            }
        }
    }
}
