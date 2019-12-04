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
    public partial class PenaltyEntry : Form
    {
        ErrorProvider ep = new ErrorProvider();

        public PenaltyEntry()
        {
            InitializeComponent();
        }

        private void PenaltyEntry_Load(object sender, EventArgs e)
        {
            btn_refresh.PerformClick();
        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            if (data_cancle.SelectedRows.Count <= 0)
                return;

            Presentation.PenaltyEntryAdd PenaltyEntryAdd = new Presentation.PenaltyEntryAdd(Convert.ToInt32(data_cancle.SelectedRows[0].Cells["id"].Value));
            PenaltyEntryAdd.ShowDialog();
            btn_refresh.PerformClick();


        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Entity.DAL.Booking book = new Entity.DAL.Booking();


            DataSet ds = book.Select();
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
