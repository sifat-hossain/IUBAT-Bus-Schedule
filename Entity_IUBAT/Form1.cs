using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_IUBAT
{
    public partial class frm_login : Form
    {

        
       Presentation.Registration reg = new Presentation.Registration();
       
        ErrorProvider ep = new ErrorProvider();
        Entity.DAL.Admin ad = new Entity.DAL.Admin();
        Entity.DAL.Passanger ps = new Entity.DAL.Passanger();
        public frm_login()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            ep.Clear();
            int er = 0;
            

            if (cmb_type.SelectedIndex.ToString() == "-1")
            {
                er++;
                ep.SetError(cmb_type, "Required");
                cmb_type.Focus();
            }

            if (txt_uemail.Text == "")
            {
                er++;
                ep.SetError(txt_uemail, "Required");
                txt_uemail.Focus();
            }

            if (txt_upassword.Text == "")
            {
                er++;
                ep.SetError(txt_upassword, "Required");
                txt_upassword.Focus();
            }

            if (er > 0)
                return;

            if (cmb_type.SelectedIndex.ToString() == "0")
            {
                ad.Admin_Id = txt_uemail.Text;
                ad.Password = txt_upassword.Text;
                ad.LogIn();
                if (txt_uemail.Text==ad.LogID && txt_upassword.Text == ad.LogPassword)
                {
                    Presentation.MainMenu m = new Presentation.MainMenu(ad.Name, ad.LogID);
                    if (m.IsDisposed)
                        m = new Presentation.MainMenu(ad.Name, ad.LogID);
                    m.Show();
                    m.BringToFront();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed! \nCheck User ID and Password again!! " + ad.Error);
                }
            }
            if (cmb_type.SelectedIndex.ToString() == "1")
            {
                ps.Student_Id = txt_uemail.Text;
                ps.Password = txt_upassword.Text;
                ps.LogIn();

                if (txt_uemail.Text == ps.LogID && txt_upassword.Text == ps.LogPassword)
                {
                    Presentation.Passsenger_mainmenu pmm = new Presentation.Passsenger_mainmenu(ps.Name, ps.LogID, ps.Id);
                    if (pmm.IsDisposed)
                        pmm = new Presentation.Passsenger_mainmenu(ps.Name, ps.LogID, ps.Id);
                   pmm.Show();
                   pmm.BringToFront();
                   this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed! \n  Check User ID and Password again!! " + ps.Error);
                }
            }


        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (reg.IsDisposed)
                reg = new Presentation.Registration();
            reg.Show();
            reg.BringToFront();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            
            cmb_type.Items.Add("Admin");
            cmb_type.Items.Add("Passanger");
            cmb_type.SelectedIndex = -1;

            txt_upassword.UseSystemPasswordChar = true;
        }

        private void chk_show_pass_log_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show_pass_log.Checked)
            {
                txt_upassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_upassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
