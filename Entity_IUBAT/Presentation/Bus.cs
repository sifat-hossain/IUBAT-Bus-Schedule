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
    public partial class Bus : Form
    {
        public Bus()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_busSearch.PerformClick();
        }

        private void btn_addBus_Click(object sender, EventArgs e)
        {
            new BusNew().ShowDialog();
            btn_busSearch.PerformClick();
        }

        private void btn_busSearch_Click(object sender, EventArgs e)
        {
            
            Entity.DAL.Bus b= new Entity.DAL.Bus();

            b.Bus_Number = txt_busSearch.Text;

            DataSet ds = b.Select();

            if (ds == null)
            {
                MessageBox.Show(b.Error);
                return;
            }

            bus_data.DataSource = ds.Tables[0];
        }

        private void Bus_Load(object sender, EventArgs e)
        {
            btn_busSearch.PerformClick();
        }

        private void btn_editBus_Click(object sender, EventArgs e)
        {
            if (bus_data.SelectedRows.Count <= 0)
                return;

            Presentation.BusEdit busEdit = new Presentation.BusEdit(Convert.ToInt32(bus_data.SelectedRows[0].Cells["colId"].Value));
            busEdit.ShowDialog();
            btn_busSearch.PerformClick();
        }

        private void btn_deleteBus_Click(object sender, EventArgs e)
        {
            if (bus_data.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            Entity.DAL.Bus b = new Entity.DAL.Bus();
            b.Id = Convert.ToInt32(bus_data.SelectedRows[0].Cells["colId"].Value);

            if (b.Delete())
            {
                MessageBox.Show("Bus Deleted");
                btn_busSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(b.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bus_data.ClearSelection();
            bus_data.BackgroundColor = Color.White;
            bus_data.RowHeadersVisible = false;
            bus_data.BorderStyle = BorderStyle.None;

            Bitmap bitmap = new Bitmap(1000, this.bus_data.Height);

            bus_data.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 1000, this.bus_data.Height));

            e.Graphics.DrawImage(bitmap, 0, 40);
            e.Graphics.DrawString("Bus List", new System.Drawing.Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(System.DateTime.Now.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1050));
            e.Graphics.DrawString("© Entity " + System.DateTime.Now.Year.ToString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1070));

        }

        private void btn_printBus_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            bus_data.ClearSelection();
            bus_data.BackgroundColor = Color.Gray;
            bus_data.RowHeadersVisible = true;
        }
    }
}
