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
    public partial class PenaltyPassanger : Form
    {
        int Session_id = 0;
        Entity.DAL.Passanger p = new Entity.DAL.Passanger();
        Entity.DAL.Penalty pen = new Entity.DAL.Penalty();

        public PenaltyPassanger(int id)
        {
            Session_id = id;
            InitializeComponent();
        }

        private void PenaltyPassanger_Load(object sender, EventArgs e)
        {
            pen.pas_id = Session_id;
            DataSet ds = pen.SelectbyId();

            p.Id = Session_id;
            p.SelectById();

            lbl_name.Text = p.Name;
            lbl_contact.Text = p.Contact;
            lbl_email.Text = p.Email;


            if (ds == null)
            {
               
                return;
            }

            data_penalty.DataSource = ds.Tables[0];

            if (data_penalty.Rows.Count == 0)
            {
                data_penalty.Visible = false;
                lbl_pen.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                data_penalty.Visible = true;
                lbl_pen.Visible = false;
            }
        }
    }
}
