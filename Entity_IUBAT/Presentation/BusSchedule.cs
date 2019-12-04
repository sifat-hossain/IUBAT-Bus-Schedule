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
    public partial class BusSchedule : Form
    {
        public BusSchedule()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Entity.DAL.BusSchedule bs = new Entity.DAL.BusSchedule();
            DataSet ds = bs.Select();

            if (ds == null)
            {
                MessageBox.Show(bs.Error);
                return;
            }

            data_bus_schedule.DataSource = ds.Tables[0];
        }

        private void BusSchedule_Load(object sender, EventArgs e)
        {
            btn_search.PerformClick();

        }

        private void data_bus_schedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Presentation.BusScheduleNew bsn = new BusScheduleNew();
            if (bsn.IsDisposed)
                bsn = new BusScheduleNew();

            bsn.Show();
            bsn.BringToFront();

            btn_search.PerformClick();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (data_bus_schedule.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            Entity.DAL.BusSchedule bs = new Entity.DAL.BusSchedule();
            bs.Id = Convert.ToInt32(data_bus_schedule.SelectedRows[0].Cells["id"].Value);

            if (bs.Delete())
            {
                MessageBox.Show("Bus Schedule Deleted");
                btn_search.PerformClick();
            }
            else
            {
                MessageBox.Show(bs.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (data_bus_schedule.SelectedRows.Count <= 0)
                return;

            Presentation.BusScheduleEdit busScheduleEdit = new Presentation.BusScheduleEdit(Convert.ToInt32(data_bus_schedule.SelectedRows[0].Cells["id"].Value));
            busScheduleEdit.ShowDialog();
            btn_search.PerformClick();

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            data_bus_schedule.ClearSelection();
            data_bus_schedule.BackgroundColor = Color.Gray;
            data_bus_schedule.RowHeadersVisible = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            data_bus_schedule.ClearSelection();
            data_bus_schedule.BackgroundColor = Color.White;
            data_bus_schedule.RowHeadersVisible = false;
            data_bus_schedule.BorderStyle = BorderStyle.None;
            Bitmap bitmap = new Bitmap(920, this.data_bus_schedule.Height);
            data_bus_schedule.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 920, this.data_bus_schedule.Height));
            e.Graphics.DrawImage(bitmap, 0, 40);
            e.Graphics.DrawString("Bus Schedule Details", new System.Drawing.Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(System.DateTime.Now.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1130));
            e.Graphics.DrawString("© Entity " + System.DateTime.Now.Year.ToString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1150));

        }
    }
}
