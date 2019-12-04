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
    public partial class Passanger : Form
    {
        public Passanger()
        {
            InitializeComponent();
        }

        private void Passanger_Load(object sender, EventArgs e)
        {
            btn_psearch.PerformClick();
        }

        private void btn_psearch_Click(object sender, EventArgs e)
        {
            Entity.DAL.Passanger ps = new Entity.DAL.Passanger();
            ps.Name = txt_pSearch.Text;
            DataSet ds = ps.Select();

            if (ds == null)
            {
                MessageBox.Show(ps.Error);
                return;
            }

            data_passanger.DataSource = ds.Tables[0];
        }

        private void btn_editPassanger_Click(object sender, EventArgs e)
        {

        }

        private void txt_pSearch_TextChanged(object sender, EventArgs e)
        {
            btn_psearch.PerformClick();
        }

        private void btn_printPassanger_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            data_passanger.ClearSelection();
            data_passanger.BackgroundColor = Color.Gray;
            data_passanger.RowHeadersVisible = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            data_passanger.ClearSelection();
            data_passanger.BackgroundColor = Color.White;
            data_passanger.RowHeadersVisible = false;
            data_passanger.BorderStyle = BorderStyle.None;
            Bitmap bitmap = new Bitmap(1000, this.data_passanger.Height);
            data_passanger.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 1000, this.data_passanger.Height));
            e.Graphics.DrawImage(bitmap, 0, 40);
            e.Graphics.DrawString("Passanger List", new System.Drawing.Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(System.DateTime.Now.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1130));
            e.Graphics.DrawString("© Entity " + System.DateTime.Now.Year.ToString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1150));

        }
    }
}
