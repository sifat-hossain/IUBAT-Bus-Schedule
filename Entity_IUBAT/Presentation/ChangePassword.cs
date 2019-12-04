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
    public partial class ChangePassword : Form
    {
        ErrorProvider ep = new ErrorProvider();

        Entity.DAL.Passanger ps = new Entity.DAL.Passanger();
        int passanger_updateId = 0;
        string passanger_pass = "";
        string Session_id = "";
        public ChangePassword(string psName, string psId)
        {
            InitializeComponent();
            Session_id = psId;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            ps.Student_Id = Session_id;
            if (ps.SelectByStudentId())
            {
                passanger_updateId = ps.Id;
                passanger_pass = ps.Password;
            }
            txt_current.UseSystemPasswordChar = true;
            txt_new.UseSystemPasswordChar = true;
            txt_newRepeat.UseSystemPasswordChar = true;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (txt_current.Text == "" || txt_current.Text == null)
            {
                er++;
                ep.SetError(txt_current, "Required");
            }

            if (er > 0)
                return;

            if (txt_current.Text == passanger_pass)
            {
                label2.Visible = true;
                label3.Visible = true;
                txt_new.Visible = true;
                txt_newRepeat.Visible = true;

                btn_cancel.Visible = true;
                btn_change_pass.Visible = true;

                txt_current.Visible = false;
                btn_check.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong Password!!");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            txt_new.Visible = false;
            txt_newRepeat.Visible = false;

            btn_cancel.Visible = false;
            btn_change_pass.Visible = false;

            txt_current.Visible = true;
            btn_check.Visible = true;
            txt_current.Text = "";
            txt_new.Text = "";
            txt_newRepeat.Text = "";
        }

        private void btn_change_pass_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (txt_new.Text == "" || txt_new.Text == null)
            {
                er++;
                ep.SetError(txt_new, "Required");
            }

            if (txt_newRepeat.Text == "" || txt_newRepeat.Text == null)
            {
                er++;
                ep.SetError(txt_newRepeat, "Required");
            }

            if (txt_new.Text != txt_newRepeat.Text)
            {
                er++;
                ep.SetError(txt_newRepeat, "Password Didn't match");
            }

            if (er > 0)
                return;

            ps.Password = txt_new.Text;
            ps.Id = passanger_updateId;
            if (ps.UpdatePassword())
            {
                MessageBox.Show("Password Updated");
                passanger_pass = ps.Password;
                btn_cancel.PerformClick();
            }
            else
            {
                MessageBox.Show(ps.Error);
                btn_cancel.PerformClick();
            }
        }

        private void chk_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show_pass.Checked)
            {
                txt_current.UseSystemPasswordChar = false;
                txt_new.UseSystemPasswordChar = false;
                txt_newRepeat.UseSystemPasswordChar = false;
            }
            else
            {
                txt_current.UseSystemPasswordChar = true;
                txt_new.UseSystemPasswordChar = true;
                txt_newRepeat.UseSystemPasswordChar = true;
            }
        }
    }
}
