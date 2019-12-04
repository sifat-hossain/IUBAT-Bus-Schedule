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
    public partial class AdminProfile : Form
    {
        Entity.DAL.Admin ad = new Entity.DAL.Admin();
        ErrorProvider ep = new ErrorProvider();
        string Session_id = "";
        string Session_name = "";
        int admin_updateId = 0;
        public AdminProfile(string adName,string adId)
        {
            InitializeComponent();
            Session_id = adId;
            Session_name = adName;
            this.Text = adName;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            
            ad.Admin_Id = Session_id;
            if (ad.SelectByAdminId())
            {
                admin_updateId = ad.Id;
                txt_name.Text = ad.Name;
                txt_id.Text = ad.Admin_Id;
                txt_contact.Text = ad.Contact;
                txt_email.Text = ad.Email;
                txt_joinDate.Text = ad.JoinDate.ToLongDateString();
                txt_pass.Text = ad.Password;
                txt_address.Text = ad.Address;
                if (ad.Gender == 0)
                {
                    txt_gender.Text = "Male";
                }
                if (ad.Gender == 1)
                {
                    txt_gender.Text = "Female";
                }
            }

        }

        private void btn_en_update_Click(object sender, EventArgs e)
        {
            txt_name.ReadOnly = false;
            txt_contact.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_address.ReadOnly = false;
            btn_update.Visible = true;
            btn_cancel.Visible = true;
            btn_en_update.Visible = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_name.ReadOnly = true;
            txt_contact.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_address.ReadOnly = true;
            btn_update.Visible = false;
            btn_cancel.Visible = false;
            btn_en_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {


            ep.Clear();
            int er = 0;

            if (txt_name.Text == "" || txt_name == null || !System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            {
                er++;
                ep.SetError(txt_name, "Invalid Name");
            }

            if (txt_contact.Text == "" || txt_contact == null || !System.Text.RegularExpressions.Regex.IsMatch(txt_contact.Text, "(^(\\+8801|8801|01|008801))[1|5-9]{1}(\\d){8}"))
            {
                er++;
                ep.SetError(txt_contact, "Invalid Conact Number");
            }

            if (txt_email.Text == "" || txt_email == null || !System.Text.RegularExpressions.Regex.IsMatch(txt_email.Text, "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$"))
            {
                er++;
                ep.SetError(txt_email, "Invalid Email");
            }

            if (txt_address.Text == "" || txt_address == null)
            {
                er++;
                ep.SetError(txt_address, "Invalid Address");
            }

            if (er > 0)
                return;

            
            ad.Name = txt_name.Text;
            ad.Password = txt_pass.Text;
            ad.Contact = txt_contact.Text;
            ad.Email = txt_email.Text;
            ad.Admin_Id = txt_id.Text;
            ad.Address = txt_address.Text;
            ad.Id = admin_updateId;

            if (ad.Update())
            {
                MessageBox.Show("Profile Updated!");
                this.Text = txt_name.Text;
                btn_cancel.PerformClick();
            }
            else
            {
                MessageBox.Show(ad.Error);
            }
        }
    }
}
