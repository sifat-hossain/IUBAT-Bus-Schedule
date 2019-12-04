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
    public partial class ChangePasswordAdmin : Form
    {
        ErrorProvider ep = new ErrorProvider();

        Entity.DAL.Admin ad = new Entity.DAL.Admin();
        int admin_updateId = 0;
        string admin_password = "";
        string Session_id = "";

        public ChangePasswordAdmin(string adName, string adId)
        {
            InitializeComponent();
            Session_id = adId;
        }

        private void ChangePasswordAdmin_Load(object sender, EventArgs e)
        {
            ad.Admin_Id = Session_id;
            if (ad.SelectByAdminId())
            {
                admin_updateId = ad.Id;
                admin_password = ad.Password;
            }

            txt_adcurrent.UseSystemPasswordChar = true;
            txt_adnew.UseSystemPasswordChar = true;
            txt_adnewRepeat.UseSystemPasswordChar = true;
        }

        private void btn_adcheck_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (txt_adcurrent.Text == "" || txt_adcurrent.Text == null)
            {
                er++;
                ep.SetError(txt_adcurrent, "Required");
            }

            if (er > 0)
                return;

            if (txt_adcurrent.Text == admin_password)
            {
                labeladn.Visible = true;
                labeladr.Visible = true;
                txt_adnew.Visible = true;
                txt_adnewRepeat.Visible = true;

                btn_cancel_ad.Visible = true;
                btn_change_pass_ad.Visible = true;

                txt_adcurrent.Visible = false;
                btn_adcheck.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong Password!!");
            }
        }

        private void btn_cancel_ad_Click(object sender, EventArgs e)
        {
            labeladn.Visible = false;
            labeladr.Visible = false;
            txt_adnew.Visible = false;
            txt_adnewRepeat.Visible = false;

            btn_cancel_ad.Visible = false;
            btn_change_pass_ad.Visible = false;

            txt_adcurrent.Visible = true;
            btn_adcheck.Visible = true;
            txt_adcurrent.Text = "";
            txt_adnew.Text = "";
            txt_adnewRepeat.Text = "";
        }

        private void btn_change_pass_ad_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (txt_adnew.Text == "" || txt_adnew.Text == null)
            {
                er++;
                ep.SetError(txt_adnew, "Required");
            }

            if (txt_adnewRepeat.Text == "" || txt_adnewRepeat.Text == null)
            {
                er++;
                ep.SetError(txt_adnewRepeat, "Required");
            }

            if (txt_adnew.Text != txt_adnewRepeat.Text)
            {
                er++;
                ep.SetError(txt_adnewRepeat, "Password Didn't match");
            }

            if (er > 0)
                return;

            ad.Password = txt_adnew.Text;
            ad.Id = admin_updateId;
            if (ad.UpdatePassword())
            {
                MessageBox.Show("Password Updated");
                admin_password = ad.Password;
                btn_cancel_ad.PerformClick();
            }
            else
            {
                MessageBox.Show(ad.Error);
                btn_cancel_ad.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show_pass.Checked)
            {
                txt_adcurrent.UseSystemPasswordChar = false;
                txt_adnew.UseSystemPasswordChar = false;
                txt_adnewRepeat.UseSystemPasswordChar = false;
            }
            else
            {
                txt_adcurrent.UseSystemPasswordChar = true;
                txt_adnew.UseSystemPasswordChar = true;
                txt_adnewRepeat.UseSystemPasswordChar = true;
            }
        }
    }
}
