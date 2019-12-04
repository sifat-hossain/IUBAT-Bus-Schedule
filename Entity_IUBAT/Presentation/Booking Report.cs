using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Entity_IUBAT.Presentation
{
    public partial class Booking_Report : Form
    {
        Entity.DAL.Bus bus = new Entity.DAL.Bus();
        Entity.DAL.Location loc = new Entity.DAL.Location();
        Entity.DAL.Booking book = new Entity.DAL.Booking();
        Entity.DAL.Incident inc = new Entity.DAL.Incident();
        Entity.DAL.Penalty p = new Entity.DAL.Penalty();


        public Booking_Report()
        {
            InitializeComponent();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void Booking_Report_Load(object sender, EventArgs e)
        {

            inc.bus = "";
            inc.location_from = "";
            inc.location_to = "";
            book.Bus_number = "";
            book.Loc_from = "";
            book.Loc_to = "";

            DataTable dtb = bus.Select().Tables[0];
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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.Date;
            dateTimePicker2.MaxDate = dateTimePicker1.Value.AddMonths(4);
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            booking.Series.Clear();
            booking.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            booking.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
           


            

            //int total = Convert.ToInt32((dateTimePicker2.Value.Date - dateTimePicker1.Value.Date).TotalDays);
            book.from_date = dateTimePicker1.Value.Date.ToShortDateString();
            book.to_date = dateTimePicker2.Value.Date.ToShortDateString();

            inc.from_date = dateTimePicker1.Value.Date.ToShortDateString();
            inc.to_date = dateTimePicker2.Value.Date.ToShortDateString();

            p.from_date = dateTimePicker1.Value.Date.ToShortDateString();
            p.to_date = dateTimePicker2.Value.Date.ToShortDateString();

            inc.bus = cmb_bus.Text;
            inc.location_from = cmb_from.Text;
            inc.location_to = cmb_to.Text;

            book.Bus_number = cmb_bus.Text;
            book.Loc_from = cmb_from.Text;
            book.Loc_to = cmb_to.Text;

            p.bus = cmb_bus.Text;
            p.location_from = cmb_from.Text;
            p.location_to = cmb_to.Text;

            //book.temp = Convert.ToInt32(cmb_bus.SelectedValue);
            //p.temp = book.temp;


            book.reportbook();
            book.reportCancle();
            inc.report();
            p.report();


            

            

            booking.Series.Add("Total Number of Booking");
            booking.Series.Add("Total Number of Cancellation");
            booking.Series.Add("Total Number Of Incident");
            booking.Series.Add("Total Number of Penalty");


            booking.Series["Total Number of Booking"].ChartType = SeriesChartType.Column;
            booking.Series["Total Number of Booking"]["PointWidth"] = (1).ToString();
            booking.Series["Total Number of Booking"].IsValueShownAsLabel = true;
            booking.Series["Total Number of Booking"].BorderDashStyle = ChartDashStyle.Solid;
            booking.Series["Total Number of Booking"].BorderColor = System.Drawing.Color.White;
            booking.Series["Total Number of Booking"].BorderWidth = 3;
            booking.Series["Total Number of Booking"].Color = Color.Black;


            booking.Series["Total Number of Cancellation"].ChartType = SeriesChartType.Column;
            booking.Series["Total Number of Cancellation"]["PointWidth"] = (1).ToString();
            booking.Series["Total Number of Cancellation"].IsValueShownAsLabel = true;
            booking.Series["Total Number of Cancellation"].BorderDashStyle = ChartDashStyle.Solid;
            booking.Series["Total Number of Cancellation"].BorderColor = System.Drawing.Color.White;
            booking.Series["Total Number of Cancellation"].BorderWidth = 3;
            booking.Series["Total Number of Cancellation"].Color = Color.Red;

            booking.Series["Total Number Of Incident"].ChartType = SeriesChartType.Column;
            booking.Series["Total Number Of Incident"]["PointWidth"] = (1).ToString();
            booking.Series["Total Number Of Incident"].IsValueShownAsLabel = true;
            booking.Series["Total Number Of Incident"].BorderDashStyle = ChartDashStyle.Solid;
            booking.Series["Total Number Of Incident"].BorderColor = System.Drawing.Color.White;
            booking.Series["Total Number Of Incident"].BorderWidth = 3;
            booking.Series["Total Number Of Incident"].Color = Color.Orange;


            booking.Series["Total Number of Penalty"].ChartType = SeriesChartType.Column;
            booking.Series["Total Number of Penalty"]["PointWidth"] = (1).ToString();
            booking.Series["Total Number of Penalty"].IsValueShownAsLabel = true;
            booking.Series["Total Number of Penalty"].BorderDashStyle = ChartDashStyle.Solid;
            booking.Series["Total Number of Penalty"].BorderColor = System.Drawing.Color.White;
            booking.Series["Total Number of Penalty"].BorderWidth = 3;
            booking.Series["Total Number of Penalty"].Color = Color.DarkRed;




            booking.Series["Total Number of Booking"].Points.AddXY("Over All Report \n" + book.from_date + " - " + book.to_date, book.Report);
            booking.Series["Total Number of Cancellation"].Points.AddXY("Cancellation \n" + book.from_date, book.cancle_count);
            booking.Series["Total Number Of Incident"].Points.AddXY("Incident\n" + book.from_date, inc.report_count);
            booking.Series["Total Number of Penalty"].Points.AddXY("Penalty\n" + book.from_date, p.report_count);

            int max = Math.Max(book.Report, Math.Max(book.cancle_count, Math.Max(inc.report_count, p.report_count)));
            booking.ChartAreas["ChartArea1"].AxisY.Maximum = max+5;

        }

        private void cmb_bus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
            Bitmap bitmap = new Bitmap(869, this.booking.Height);
            booking.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 869, this.booking.Height));
            e.Graphics.DrawImage(bitmap, 20, 180);
            e.Graphics.DrawString("Overall Report", new System.Drawing.Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("From " + dateTimePicker1.Value.Date.ToShortDateString()  + " to " + dateTimePicker2.Value.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 16, FontStyle.Bold), Brushes.Black, new Point(0, 40));
            e.Graphics.DrawString(System.DateTime.Now.Date.ToShortDateString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1050));
            e.Graphics.DrawString("© Entity " + System.DateTime.Now.Year.ToString(), new System.Drawing.Font("Verdana", 12, FontStyle.Regular), Brushes.Black, new Point(0, 1080));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmb_to_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void booking_Click(object sender, EventArgs e)
        {

        }
    }
}
