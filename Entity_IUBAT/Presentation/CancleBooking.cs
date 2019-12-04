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
    public partial class CancleBooking : Form
    {
        Entity.DAL.Booking book = new Entity.DAL.Booking();
        int SessionId = 0;
        public CancleBooking(int id)
        {
            InitializeComponent();
            SessionId = id;
        }

        private void CancleBooking_Load(object sender, EventArgs e)
        {

            btn_ref.PerformClick();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            if (data_cancle.SelectedRows.Count <= 0)
                return;

            DialogResult dr = MessageBox.Show("Are You Sure You want to Cancle This Booking?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            Entity.DAL.Booking book = new Entity.DAL.Booking();
            book.Id = Convert.ToInt32(data_cancle.SelectedRows[0].Cells["id"].Value);
          
            book.Booking_status = 0;
            if (book.Update())
            {
                MessageBox.Show("Booking Cancled!");
                btn_ref.PerformClick();
            }
            else
            {
                MessageBox.Show(book.Error);
            }
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            book.Passanger_id = SessionId;

            DataSet ds = book.BookingOfPassanger();
            if (ds == null)
            {
                MessageBox.Show("No Booking Records");
                return;
            }

            data_cancle.DataSource = ds.Tables[0];
            data_cancle.ClearSelection();
        }
    }
}
