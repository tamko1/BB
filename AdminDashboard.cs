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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            GetData();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");

        private void GetData()
        {
           Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BStock) from Blood", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int BStock = Convert.ToInt32(dt.Rows[0][0].ToString());
            lblBB.Text = "" + BStock;

            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from Transfer", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lblBT.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from Donor", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lblD.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("Select count(*) from Patient", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            lblP.Text = dt3.Rows[0][0].ToString();


            SqlDataAdapter sda4 = new SqlDataAdapter("Select count(*) from Employee", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            lblTEmp.Text = dt4.Rows[0][0].ToString();


            Con.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblDC_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblP_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Employee emp= new Employee();
            emp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void lblViewEmp_Click(object sender, EventArgs e)
        {
            ViewEmployee ve = new ViewEmployee();
            ve.Show();
            this.Hide();
        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
          

        }
    }
}
