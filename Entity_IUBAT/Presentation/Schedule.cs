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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void btn_scheduleAdd_Click(object sender, EventArgs e)
        {
            new ScheduleNew().ShowDialog();
            btn_scheduleSearch.PerformClick();
        }

        private void btn_scheduleSearch_Click(object sender, EventArgs e)
        {

            Entity.DAL.Schedule s = new Entity.DAL.Schedule();

           // s.Location_From = Convert.ToInt32(txt_scheduleSearch.Text);

            DataSet ds = s.Select();

            if (ds == null)
            {
                MessageBox.Show(s.Error);
                return;
            }

            schedule_data.DataSource = ds.Tables[0];
        }

        private void btn_scheduleEdit_Click(object sender, EventArgs e)
        {
            if (schedule_data.SelectedRows.Count <= 0)
                return;

            Presentation.ScheduleEdit scheduleEdit = new Presentation.ScheduleEdit(Convert.ToInt32(schedule_data.SelectedRows[0].Cells["colId"].Value));
            scheduleEdit.ShowDialog();
            btn_scheduleSearch.PerformClick();
        }

        private void schedule_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            btn_scheduleSearch.PerformClick();
        }

        private void btn_scheduleDelete_Click(object sender, EventArgs e)
        {
            if (schedule_data.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show("Are You Sure You want to Delete?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            Entity.DAL.Schedule s = new Entity.DAL.Schedule();
            s.Id = Convert.ToInt32(schedule_data.SelectedRows[0].Cells["colId"].Value);

            if (s.Delete())
            {
                MessageBox.Show("Schedule Deleted");
                btn_scheduleSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(s.Error);
            }

           
        }

        private void btn_schedulePrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            schedule_data.ClearSelection();
            schedule_data.BackgroundColor = Color.Gray;
            schedule_data.RowHeadersVisible = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            schedule_data.ClearSelection();
            schedule_data.BackgroundColor = Color.White;
            schedule_data.RowHeadersVisible = false;
            schedule_data.BorderStyle = BorderStyle.None;
            Bitmap bitmap = new Bitmap(869, this.schedule_data.Height);
            schedule_data.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 869, this.schedule_data.Height));
            e.Graphics.DrawImage(bitmap, 0, 40);
            e.Graphics.DrawString("Schedule Details", new System.Drawing.Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(System.DateTime.Now.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1130));
            e.Graphics.DrawString("© Entity " + System.DateTime.Now.Year.ToString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1150));

        }
    }
}
