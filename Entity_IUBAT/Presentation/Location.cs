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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            btn_lsearch.PerformClick();
        }

        private void btn_lsearch_Click(object sender, EventArgs e)
        {

            Entity.DAL.Location loc = new Entity.DAL.Location();

            loc.Name = txt_lsearch.Text;

            DataSet ds = loc.Select();

            if (ds == null)
            {
                MessageBox.Show(loc.Error);
                return;
            }

            data_location.DataSource = ds.Tables[0];

            data_location.ClearSelection();
        }

        private void btn_addLocation_Click(object sender, EventArgs e)
        {
            new LocationNew().ShowDialog();
            btn_lsearch.PerformClick();
        }

        private void btn_editLocation_Click(object sender, EventArgs e)
        {
            if (data_location.SelectedRows.Count <= 0)
                return;

            Presentation.LocationEdit locEdit = new Presentation.LocationEdit(Convert.ToInt32(data_location.SelectedRows[0].Cells["id"].Value));
            locEdit.ShowDialog();
            btn_lsearch.PerformClick();
        }

        private void btn_deleteLocation_Click(object sender, EventArgs e)
        {
            if (data_location.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            Entity.DAL.Location loc = new Entity.DAL.Location();
            loc.Id = Convert.ToInt32(data_location.SelectedRows[0].Cells["id"].Value);

            if (loc.Delete())
            {
                MessageBox.Show("Location Deleted");
                btn_lsearch.PerformClick();
            }
            else
            {
                MessageBox.Show(loc.Error);
            }
        }

        private void txt_lsearch_TextChanged(object sender, EventArgs e)
        {
            btn_lsearch.PerformClick();
        }

        private void btn_printLocation_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            data_location.ClearSelection();
            data_location.BackgroundColor = Color.Gray;
            data_location.RowHeadersVisible = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            data_location.ClearSelection();
            data_location.BackgroundColor = Color.White;
            data_location.RowHeadersVisible = false;
            data_location.BorderStyle = BorderStyle.None;
            Bitmap bitmap = new Bitmap(869, this.data_location.Height);
            data_location.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 869, this.data_location.Height));
            e.Graphics.DrawImage(bitmap, 0, 40);
            e.Graphics.DrawString("Location Details", new System.Drawing.Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(System.DateTime.Now.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1130));
            e.Graphics.DrawString("© Entity " + System.DateTime.Now.Year.ToString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1150));

        }
    }
}
