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
    public partial class LocationEdit : Form
    {
        ErrorProvider ep = new ErrorProvider();
        Entity.DAL.Location loc = new Entity.DAL.Location();

        public LocationEdit(int id)
        {
            InitializeComponent();
            loc.Id = id;

            if (!loc.SelectById())
            {
                MessageBox.Show("Not Found!");
                Close();
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
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

            loc.Name = txt_name.Text;
           
            loc.City = txt_city.Text;

            if (loc.Update())
            {
                MessageBox.Show("Location Data Updated ! ");
                txt_name.Focus();
            }
            else
            {
                MessageBox.Show(loc.Error);
            }
        }

        private void LocationEdit_Load(object sender, EventArgs e)
        {
            txt_name.Text = loc.Name;
            txt_city.Text =loc.City;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
