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

namespace blood_bank
{
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
            bloodStock();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");
        private void bloodStock()
        {
            Con.Open();
            string Query = "select * from Blood";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvBStock.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BloodStock_Load(object sender, EventArgs e)
        {

        }

        private void lblBloodTransfert_Click(object sender, EventArgs e)
        {
            BloodTransfert bt = new BloodTransfert();
            bt.Show();
            this.Hide();
        }

        private void lblDonor_Click(object sender, EventArgs e)
        {
            Donor d = new Donor();
            d.Show();
            this.Hide();
        }

        private void lblViewDonor_Click(object sender, EventArgs e)
        {
            DonorView dv = new DonorView();
            dv.Show();
            this.Hide();
        }

        private void lblBloodDonate_Click(object sender, EventArgs e)
        {
            DonateBlood db = new DonateBlood();
            db.Show();
            this.Hide();
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblViewPatient_Click(object sender, EventArgs e)
        {
            PatientList pl = new PatientList();
            pl.Show();
            this.Hide();
        }

        private void lblBloodStock_Click(object sender, EventArgs e)
        {
            BloodStock bs = new BloodStock();
            bs.Show();
            this.Hide();

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Dashboard da = new Dashboard();
            da.Show();
            this.Hide();
        }

        private void lblBloodTransfert_Click_1(object sender, EventArgs e)
        {
            BloodTransfert bt = new BloodTransfert();
            bt.Show();
            this.Hide();
        }
    }
}
