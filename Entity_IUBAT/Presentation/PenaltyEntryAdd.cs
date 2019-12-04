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

namespace Entity_IUBAT.Presentation
{
    public partial class PenaltyEntryAdd : Form
    {
        int Booking_ID = 0;
        Entity.DAL.Passanger pp = new Entity.DAL.Passanger();
        Entity.DAL.Booking book = new Entity.DAL.Booking();
        Entity.DAL.Penalty p = new Entity.DAL.Penalty();
        public PenaltyEntryAdd(int id)
        {
            InitializeComponent();
            Booking_ID = id;
        }

        private void PenaltyEntryAdd_Load(object sender, EventArgs e)
        {
            book.Id = Booking_ID ;
            book.Return_passanger_ID();
            book.Booking_information();
            pp.Id = book.Passanger_id ;
            pp.SelectById();

            label2.Text = "Passanger Name: " + pp.Name + "\n\tOn " + book.Date.ToShortDateString() + "\n\t\tFrom " + book.Loc_from + "\n\t\tto " + book.Loc_to + "\n\t\tat " + book.time + "\n\t\tin " + book.Bus_number +  "\nAmount : 50"  ;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            
            p.Booking_id = Booking_ID;

            if (p.PenaltyAlreadyExist())
            {
                MessageBox.Show("Penalty Already Exists!");
                return;
            }

            if (p.Insert())
            {
                MessageBox.Show("Penalty Information Inserted.");
                this.Hide();
            }
        }
    }
}
