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
    public partial class PenaltyDetails : Form
    {
        Entity.DAL.Penalty pen = new Entity.DAL.Penalty();
        Entity.DAL.Bus b = new Entity.DAL.Bus();
        Entity.DAL.Location loc = new Entity.DAL.Location();
        
        public PenaltyDetails()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            pen.location_from = cmb_from.Text;
            pen.location_to = cmb_to.Text;
            pen.bus = cmb_Bus.Text;
            pen.passanger = txt_pas.Text;
            DataSet ds = pen.Select();

            if (ds == null)
            {
                MessageBox.Show(pen.Error);
                return;
            }

            data_cancle.DataSource = ds.Tables[0];

            data_cancle.ClearSelection();
        }

        private void PenaltyDetails_Load(object sender, EventArgs e)
        {
            pen.location_from = "";
            pen.location_to = "";
            pen.bus = "";
            pen.passanger = "";


            DataTable dtbus = b.Select().Tables[0]; ;
            DataRow drbus = dtbus.NewRow();
            drbus["bus_number"] = "ALL";
            drbus["id"] = 0;
            dtbus.Rows.InsertAt(drbus, 0);
            cmb_Bus.DataSource = dtbus;
            cmb_Bus.DisplayMember = "bus_number";
            cmb_Bus.ValueMember = "id";
            cmb_Bus.SelectedValue = 0;


            DataTable dtfrom = loc.Select().Tables[0]; ;
            DataRow drfrom = dtfrom.NewRow();
            drfrom["name"] = "ALL";
            drfrom["id"] = 0;
            dtfrom.Rows.InsertAt(drfrom, 0);
            cmb_from.DataSource = dtfrom;
            cmb_from.DisplayMember = "name";
            cmb_from.ValueMember = "id";
            cmb_from.SelectedValue = 0;
            

            DataTable dtto = loc.Select().Tables[0];
            DataRow drto = dtto.NewRow();
            drto["name"] = "ALL";
            drto["id"] = 0;
            dtto.Rows.InsertAt(drto, 0);
            cmb_to.DataSource = dtto;
            cmb_to.DisplayMember = "name";
            cmb_to.ValueMember = "id";
            cmb_to.SelectedValue = 0;

            txt_pas.Text = "Name or ID Number";
            txt_pas.ForeColor = Color.Gray;

            btn_search.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (data_cancle.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show("Are You Sure This Penalty is Paid?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            pen.Id = Convert.ToInt32(data_cancle.SelectedRows[0].Cells["id"].Value);

            if (pen.Update())
            {
                MessageBox.Show("Penalty Discarded");
                btn_search.PerformClick();
            }
            else
            {
                MessageBox.Show(pen.Error);
            }
        }

        private void txt_pas_TextChanged(object sender, EventArgs e)
        {
            btn_search.PerformClick();
        }

        private void cmb_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_from.SelectedText != "")
            {
                cmb_from.Text = "ALL";
            }

            btn_search.PerformClick();
        }

        private void cmb_to_SelectedIndexChanged(object sender, EventArgs e)
        {
           btn_search.PerformClick();
        }

        private void cmb_Bus_SelectedIndexChanged(object sender, EventArgs e)
        {
           btn_search.PerformClick();
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

        private void data_cancle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            data_cancle.ClearSelection();
            data_cancle.BackgroundColor = Color.Gray;
            data_cancle.RowHeadersVisible = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            data_cancle.ClearSelection();
            data_cancle.BackgroundColor = Color.White;
            data_cancle.RowHeadersVisible = false;
            data_cancle.BorderStyle = BorderStyle.None;
            Bitmap bitmap = new Bitmap(1500, this.data_cancle.Height);
            data_cancle.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 1500, this.data_cancle.Height));
            e.Graphics.DrawImage(bitmap, 0, 40);
            e.Graphics.DrawString("Penalty List", new System.Drawing.Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(System.DateTime.Now.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1130));
            e.Graphics.DrawString("© Entity " + System.DateTime.Now.Year.ToString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1150));

        }
    }
}
