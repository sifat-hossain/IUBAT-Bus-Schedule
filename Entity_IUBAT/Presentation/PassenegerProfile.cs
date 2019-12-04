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
    public partial class PassenegerProfile : Form
    {
        ErrorProvider ep = new ErrorProvider();

        Entity.DAL.Passanger ps = new Entity.DAL.Passanger();
        int passanger_updateId = 0;
        string Session_id = "";
        public PassenegerProfile(string psName, string psId)
        {
            InitializeComponent();
            Session_id = psId;
            this.Text = psName;
        }

        private void btn_enable_update_Click(object sender, EventArgs e)
        {
            txt_pname.ReadOnly = false;
            txt_pcontact.ReadOnly = false;
            txt_pemail.ReadOnly = false;
            txt_paddress.ReadOnly = false;
            
            btn_save_update.Visible = true;
            btn_cancel_update.Visible = true;
            btn_enable_update.Visible = false;
        }

        private void btn_save_update_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (txt_pname.Text == "" | txt_pname == null)
            {
                er++;
                ep.SetError(txt_pname, "Invalid Name");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_pname.Text, "^[a-zA-Z ]"))
            {
                er++;
                ep.SetError(txt_pname, "Invalid Name");
            }

            if (txt_pcontact.Text == "" | txt_pcontact == null | !System.Text.RegularExpressions.Regex.IsMatch(txt_pcontact.Text, "(^(\\+8801|8801|01|008801))[1|5-9]{1}(\\d){8}"))
            {
                er++;
                ep.SetError(txt_pcontact, "Invalid Conact Number");
            }

            if (txt_pemail.Text == "" | txt_pemail == null | !System.Text.RegularExpressions.Regex.IsMatch(txt_pemail.Text, "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$"))
            {
                er++;
                ep.SetError(txt_pemail, "Invalid Email");
            }

            if (txt_paddress.Text == "" | txt_paddress == null)
            {
                er++;
                ep.SetError(txt_paddress, "Invalid Address");
            }

            if (er > 0)
                return;

            
            ps.Name = txt_pname.Text;
            ps.Password = txt_ppass.Text;
            ps.Contact = txt_pcontact.Text;
            ps.Email = txt_pemail.Text;
            ps.Student_Id = txt_pid.Text;
            ps.Address = txt_paddress.Text;
            

            if (ps.Update())
            {
                MessageBox.Show("Profile Updated!");
                this.Text = txt_pname.Text;
                btn_cancel_update.PerformClick();
            }
            else
            {
                MessageBox.Show(ps.Error);
            }
        }

        private void PassenegerProfile_Load(object sender, EventArgs e)
        {
            ps.Student_Id = Session_id;
            if (ps.SelectByStudentId())
            {
                passanger_updateId = ps.Id;
                txt_pname.Text = ps.Name;
                txt_pid.Text = ps.Student_Id;
                txt_pcontact.Text = ps.Contact;
                txt_pemail.Text = ps.Email;
                txt_pjoinDate.Text = ps.JoinDate.ToLongDateString();
                txt_ppass.Text = ps.Password;
                txt_paddress.Text = ps.Address;
                if (ps.Gender == 0)
                {
                    txt_pgender.Text = "Male";
                }
                if (ps.Gender == 1)
                {
                    txt_pgender.Text = "Female";
                }
            }
        }

        private void btn_cancel_update_Click(object sender, EventArgs e)
        {
            txt_pname.ReadOnly = true;
            txt_pcontact.ReadOnly = true;
            txt_pemail.ReadOnly = true;
            txt_paddress.ReadOnly = true;
            btn_save_update.Visible = false;
            btn_cancel_update.Visible = false;
            btn_enable_update.Visible = true;
        }
    }
}
