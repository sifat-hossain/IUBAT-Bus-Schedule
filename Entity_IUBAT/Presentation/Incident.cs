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
    public partial class Incident : Form
    {
        Entity.DAL.Bus b = new Entity.DAL.Bus();
        Entity.DAL.Time_Schedule ts = new Entity.DAL.Time_Schedule();
        Entity.DAL.Incident i = new Entity.DAL.Incident();
        Entity.DAL.Location loc = new Entity.DAL.Location();
       
        ErrorProvider ep = new ErrorProvider();
        int Session_id = 0;

        public Incident(int id)
        {
            Session_id = id;
            InitializeComponent();
        }


        public void timeLoad()
        {
          
        }

        private void Incident_Load(object sender, EventArgs e)
        {

            dtp_date.MaxDate = DateTime.Now.Date;
            dtp_date.MinDate = DateTime.Now.Date.AddMonths(-1);

            DataTable dtb = b.Select().Tables[0];
            DataRow drb = dtb.NewRow();
            drb["bus_number"] = "--SELECT--";
            drb["id"] = 0;
            dtb.Rows.InsertAt(drb, 0);
            cmbbus.DataSource = dtb;
            cmbbus.DisplayMember = "bus_number";
            cmbbus.ValueMember = "id";
            cmbbus.SelectedValue = 0;

            DataTable dtt = ts.Select().Tables[0];
            cmbtime.DataSource = dtt;
            cmbtime.DisplayMember = "schedule_time";
            cmbtime.ValueMember = "id";
            cmbtime.Text = "--SELECT--";

            DataTable dtlf = loc.Select().Tables[0];
            DataRow drlf = dtlf.NewRow();
            drlf["name"] = "--SELECT--";
            drlf["id"] = 0;
            dtlf.Rows.InsertAt(drlf, 0);
            cmb_from.DataSource = dtlf;
            cmb_from.DisplayMember = "name";
            cmb_from.ValueMember = "id";
            cmb_from.SelectedValue = 0;


            DataTable dtlt = loc.Select().Tables[0];
            DataRow drlt = dtlt.NewRow();
            drlt["name"] = "--SELECT--";
            drlt["id"] = 0;
            dtlt.Rows.InsertAt(drlt, 0);
            cmb_to.DataSource = dtlt;
            cmb_to.DisplayMember = "name";
            cmb_to.ValueMember = "id";
            cmb_to.SelectedValue = 0;


        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (cmbbus.Text == "" || cmbbus.Text == "--SELECT--")
            {
                er++;
                ep.SetError(cmbbus, "Required");
            }

            if (cmbtime.Text == "" || cmbtime.Text == "--SELECT--")
            {
                er++;
                ep.SetError(cmbtime, "Required");
            }

            if (cmb_from.Text == "" || cmb_from.Text == "--SELECT--")
            {
                er++;
                ep.SetError(cmb_from, "Required");
            }
            if (cmb_to.Text == "" || cmb_to.Text == "--SELECT--")
            {
                er++;
                ep.SetError(cmb_to, "Required");
            }
            if (txt_incident.Text == "")
            {
                er++;
                ep.SetError(txt_incident, "Required");
            }

            if (er > 0)
                return;

            i.Bus_id = Convert.ToInt32(cmbbus.SelectedValue);
            i.Time_id = Convert.ToInt32(cmbtime.SelectedValue);
            i.Passanger_id = Session_id;
            i.Incident_date = System.DateTime.Now;
            i.Description = txt_incident.Text;
            i.Loc_from = Convert.ToInt32(cmb_from.SelectedValue);
            i.Loc_to = Convert.ToInt32(cmb_to.SelectedValue);

            if (i.Insert())
            {
                MessageBox.Show("Incident Reported");
                dtp_date.Value = DateTime.Now.Date;
                cmbbus.SelectedValue = 0;
                cmbtime.Text = "--SELECT--";
                cmb_from.SelectedValue = 0;
                cmb_to.SelectedValue = 0;
                txt_incident.Text = "";
                dtp_date.Focus();
            }
            else
            {
                MessageBox.Show(i.Error);
            }

        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
