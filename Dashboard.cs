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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetData();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");

        private void GetData()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Donor", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblDC.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from Patient", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lblP.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from Transfer", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lblBT.Text = dt2.Rows[0][0].ToString();


            SqlDataAdapter sda3 = new SqlDataAdapter("Select Sum(BStock) from Blood", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            int BStock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            lblTotal.Text = "" + BStock;


            SqlDataAdapter sda4 = new SqlDataAdapter("Select BStock from Blood where BGroup = '"+"O+"+"'", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            lblOplus.Text = dt4.Rows[0][0].ToString();
            double OplusPercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / BStock) * 100;
            OPlusProgress.Value = Convert.ToInt32(OplusPercentage);


            SqlDataAdapter sda5 = new SqlDataAdapter("Select BStock from Blood where BGroup = '" + "AB+" + "'", Con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            lblABplus.Text = dt5.Rows[0][0].ToString();
            double ABplusPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / BStock) * 100;
            ABPlusProgress.Value = Convert.ToInt32(ABplusPercentage);


            SqlDataAdapter sda6 = new SqlDataAdapter("Select BStock from Blood where BGroup = '" + "B+" + "'", Con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            lblBPlus.Text = dt6.Rows[0][0].ToString();
            double BplusPercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / BStock) * 100;
            BPlusProgress.Value = Convert.ToInt32(BplusPercentage);



            SqlDataAdapter sda7 = new SqlDataAdapter("Select BStock from Blood where BGroup = '" + "A+" + "'", Con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            lblAplus.Text = dt7.Rows[0][0].ToString();
            double AplusPercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / BStock) * 100;
            AplusProgress.Value = Convert.ToInt32(AplusPercentage);


            SqlDataAdapter sda8 = new SqlDataAdapter("Select BStock from Blood where BGroup = '" + "O-" + "'", Con);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
            lblOminus.Text = dt8.Rows[0][0].ToString();
            double OminusPercentage = (Convert.ToDouble(dt8.Rows[0][0].ToString()) / BStock) * 100;
            OMinusProgress.Value = Convert.ToInt32(OminusPercentage);


            SqlDataAdapter sda9 = new SqlDataAdapter("Select BStock from Blood where BGroup = '" + "A-" + "'", Con);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            lblAminus.Text = dt9.Rows[0][0].ToString();
            double AminusPercentage = (Convert.ToDouble(dt9.Rows[0][0].ToString()) / BStock) * 100;
            AMinusProgress.Value = Convert.ToInt32(AminusPercentage);


            SqlDataAdapter sda10 = new SqlDataAdapter("Select BStock from Blood where BGroup = '" + "AB-" + "'", Con);
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
            lblABminus.Text = dt10.Rows[0][0].ToString();
            double ABminusPercentage = (Convert.ToDouble(dt10.Rows[0][0].ToString()) / BStock) * 100;
            ABMinusProgress.Value = Convert.ToInt32(ABminusPercentage);



            SqlDataAdapter sda11 = new SqlDataAdapter("Select BStock from Blood where BGroup = '" + "B-" + "'", Con);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            lblBminus.Text = dt11.Rows[0][0].ToString();
            double BminusPercentage = (Convert.ToDouble(dt11.Rows[0][0].ToString()) / BStock) * 100;
            BMinusProgress.Value = Convert.ToInt32(BminusPercentage);


            Con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void lblPatientList_Click(object sender, EventArgs e)
        {

        }

        private void lblDonor_Click(object sender, EventArgs e)
        {
            Donor d =new Donor();
            d.Show();
            this.Hide();
        }

        private void lblViewDonor_Click(object sender, EventArgs e)
        {
            DonorView dv =new DonorView();
            dv.Show();
            this.Hide();
        }

        private void lblBloodDonate_Click(object sender, EventArgs e)
        {
            DonateBlood db =new DonateBlood();
            db.Show();
            this.Hide();
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void lblViewPatient_Click(object sender, EventArgs e)
        {
            PatientList pl = new PatientList();
            pl.Show();
            this.Hide();
        }

        private void lblBloodStock_Click(object sender, EventArgs e)
        {
            BloodStock bs =new BloodStock();
            bs.Show();
            this.Hide();
        }

        private void lblBloodTransfert_Click(object sender, EventArgs e)
        {
            BloodTransfert bt = new BloodTransfert();
            bt.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lblBminus_Click(object sender, EventArgs e)
        {

        }

        private void BPlusProgress_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
