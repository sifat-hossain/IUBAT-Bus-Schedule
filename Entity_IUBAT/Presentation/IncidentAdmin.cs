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
    public partial class IncidentAdmin : Form
    {
        Entity.DAL.Incident inc = new Entity.DAL.Incident();
        Entity.DAL.Bus bus1 = new Entity.DAL.Bus();
        Entity.DAL.Location loc = new Entity.DAL.Location();
        int c = 0;
        public IncidentAdmin()
        {
            InitializeComponent();
        }


        private void IncidentAdmin_Load(object sender, EventArgs e)
        {
            inc.bus = "";
            inc.location_from = "";
            inc.location_to = "";
            inc.from_date = "";
            inc.to_date = "";
            inc.passanger = "";

            DataTable dtb = bus1.Select().Tables[0];
            DataRow drb = dtb.NewRow();
            drb["bus_number"] = "ALL";
            drb["id"] = 0;
            dtb.Rows.InsertAt(drb, 0);
            cmb_bus.DataSource = dtb;
            cmb_bus.DisplayMember = "bus_number";
            cmb_bus.ValueMember = "id";
            cmb_bus.SelectedValue = 0;


            DataTable dtf = loc.Select().Tables[0];
            DataRow drf = dtf.NewRow();
            drf["name"] = "ALL";
            drf["id"] = 0;
            dtf.Rows.InsertAt(drf, 0);
            cmb_from.DataSource = dtf;
            cmb_from.DisplayMember = "name";
            cmb_from.ValueMember = "id";
            cmb_from.SelectedValue = 0;


            DataTable dtt = loc.Select().Tables[0];
            DataRow drt = dtt.NewRow();
            drt["name"] = "ALL";
            drt["id"] = 0;
            dtt.Rows.InsertAt(drt, 0);
            cmb_to.DataSource = dtt;
            cmb_to.DisplayMember = "name";
            cmb_to.ValueMember = "id";
            cmb_to.SelectedValue = 0;


            dateTimePicker1.MinDate = System.DateTime.Now.Date.AddMonths(-4);
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            btn_gen.PerformClick();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            dateTimePicker2.MaxDate = dateTimePicker1.Value.AddMonths(4);
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            data_incident.DataSource = null;
            c++;
            inc.passanger = txt_pas.Text;
            inc.bus = cmb_bus.Text;
            inc.from_date = dateTimePicker1.Value.Date.ToShortDateString();
            inc.to_date = dateTimePicker2.Value.Date.ToShortDateString();
            inc.location_from = cmb_from.Text;
            inc.location_to = cmb_to.Text;

            DataTable dt = inc.Select().Tables[0];
            if (dt.Rows.Count >0 )
            {
                data_incident.DataSource = dt;
            }
            else
            {
                if (c >= 8)
                {
                    MessageBox.Show("No Incedent Reported Within the Search Paramenter");
                }
                
            }
        }

        private void txt_pas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_pas.Text.Equals("Name or ID Number") == true)
            {
                txt_pas.Text = "";
                txt_pas.ForeColor = Color.Black;
            }
        }

        private void txt_pas_Leave(object sender, EventArgs e)
        {
            if (txt_pas.Text.Equals(null) == true || txt_pas.Text.Equals("") == true)
            {
                txt_pas.Text = "Name or ID Number";
                txt_pas.ForeColor = Color.Gray;
            }
        }

        private void txt_pas_TextChanged(object sender, EventArgs e)
        {
           btn_gen.PerformClick();
        }

        private void cmb_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_gen.PerformClick();
        }

        private void cmb_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_gen.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btn_gen.PerformClick();
        }

        private void cmb_bus_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_gen.PerformClick();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            data_incident.ClearSelection();
            data_incident.BackgroundColor = Color.White;
            data_incident.RowHeadersVisible = false;
            data_incident.BorderStyle = BorderStyle.None;
            Bitmap bitmap = new Bitmap(1000, this.data_incident.Height);
            data_incident.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 1000, this.data_incident.Height));
            e.Graphics.DrawImage(bitmap, 0, 40);
            e.Graphics.DrawString("Incedent Report", new System.Drawing.Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(System.DateTime.Now.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1130));
            e.Graphics.DrawString("© Entity " + System.DateTime.Now.Year.ToString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1150));

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            data_incident.ClearSelection();
            data_incident.BackgroundColor = Color.Gray;
            data_incident.RowHeadersVisible = true;
        }
    }
}
