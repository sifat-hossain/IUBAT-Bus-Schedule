using System;
using System.Windows.Forms;

namespace Entity_IUBAT.Presentation
{
    public partial class Registration : Form
    {

        ErrorProvider ep = new ErrorProvider();
        Entity.DAL.Passanger ps = new Entity.DAL.Passanger();
        Entity.DAL.Admin ad = new Entity.DAL.Admin();
        public Registration()
        {
            InitializeComponent();
        }

       


        private void btn_register_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (txt_stdId.Text == "" || txt_stdId.Text == null)
            {
                er++;
                ep.SetError(txt_stdId, "Required");
                txt_stdId.Focus();
            }

            if (txt_stdId.Text.Length > 9 || !System.Text.RegularExpressions.Regex.IsMatch(txt_stdId.Text, "^[0-9]"))
            {
                er++;
                ep.SetError(txt_stdId, "Invalid Id Card Number");
                txt_stdId.Focus();
            }


            if (txt_name.Text == "" || txt_name.Text == null)
            {
                er++;
                ep.SetError(txt_name, "Required");
                txt_name.Focus();
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            {
                er++;
                ep.SetError(txt_name, "Invalid Name");
                txt_name.Focus();
            }

            if (txt_contact.Text == "" || txt_contact.Text ==  null)
            {
                er++;
                ep.SetError(txt_contact, "Required");
                txt_contact.Focus();
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_contact.Text, "(^(\\+8801|8801|01|008801))[1|5-9]{1}(\\d){8}"))
            {
                er++;
                ep.SetError(txt_contact, "Invalid Contact");
            }

            if (txt_email.Text == "" || txt_email.Text == null)
            {
                er++;
                ep.SetError(txt_email, "Required");
                txt_email.Focus();
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_email.Text, "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$"))
            {
                er++;
                ep.SetError(txt_email, "Invalid Email");
                txt_email.Focus();
            }
            if (txt_password.Text == "" || txt_password == null )
            {
                er++;
                ep.SetError(txt_password, "Required");
                txt_password.Focus();
            }

            if (txt_re_password.Text == "" || txt_re_password.Text == null )
            {
                er++;
                ep.SetError(txt_re_password, "Required");
                txt_re_password.Focus();
            }

            if (txt_password.Text != txt_re_password.Text)
            {
                er++;
                ep.SetError(txt_re_password, "Password Didn't Match");
                txt_re_password.Focus();
            }
            if (cmd_gender.SelectedIndex.ToString() == "-1" )
            {
                er++;
                ep.SetError(cmd_gender, "Required");
                cmd_gender.Focus();
            }

            if (txt_address.Text == "" || txt_address.Text == null)
            {
                er++;
                ep.SetError(txt_address, "Required");
                txt_address.Focus();
            }


           

            if (er > 0)
                return;

           

            ps.Student_Id = txt_stdId.Text;
                ps.Name = txt_name.Text;
                ps.Contact = txt_contact.Text;
                ps.Email = txt_email.Text;
                ps.Gender = Convert.ToInt32(cmd_gender.SelectedIndex);
                ps.Password = txt_password.Text;
                ps.JoinDate = DateTime.Now.Date;
                ps.Address = txt_address.Text;

                if (ps.Insert())
                {
                    MessageBox.Show("User Registered");
                    txt_stdId.Text = "";
                    txt_name.Text= "";
                    txt_contact.Text="";
                    txt_email.Text="";
                    txt_password.Text="";
                    txt_re_password.Text = "";
                    txt_address.Text="";
                    cmd_gender.SelectedIndex = -1;
                    txt_stdId.Focus();
                }
                else
                {
                    MessageBox.Show(ps.Error);
                }
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {

            cmd_gender.Items.Add("Male");
            cmd_gender.Items.Add("Female");
            cmd_gender.SelectedIndex = -1;
            txt_stdId.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_stdId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
