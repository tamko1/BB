using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace blood_bank
{
    public partial class DonateBlood : Form
    {
        public DonateBlood()
        {
            InitializeComponent();
            populate();
            bloodStock();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");
        private void populate()
        {
            Con.Open();
            string Query = "select * from Donor";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvDonorList.DataSource = ds.Tables[0];
            Con.Close();
        }

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
        private void DonateBlood_Load(object sender, EventArgs e)
        {

        }
        int oldstock;
        private void GetStock (string Bgroup) 
        {
            Con.Open();
            string Query = "select * from Blood where BGroup='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt =new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter (cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();
        }
        private void dgvDonorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDName.Text = dgvDonorList.SelectedRows[0].Cells[1].Value.ToString();
            txtBGroup.Text= dgvDonorList.SelectedRows[0].Cells[4].Value.ToString();
            GetStock (txtBGroup.Text);
            
        }
        private void Reset()
        {
            txtDName.Text = "";
            txtBGroup.Text = "";
       
        }
       
        
        private void txtDPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(txtDName.Text == "")
            {
                MessageBox.Show("Select A Donor");
            }
            else
            {
                try
                {
                    int stock = oldstock + 1;
                    string query = "update Blood set BStock =" + stock + " where BGroup ='" + txtBGroup.Text + "';";
                    
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Successfull");

                    Con.Close();
                    Reset();
                    
                    bloodStock();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void txtBGroup_TextChanged(object sender, EventArgs e)
        {

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
            BloodStock bs = new BloodStock();
            bs.Show();
            this.Hide();
        }

        private void lblBloodTransfert_Click(object sender, EventArgs e)
        {
            BloodTransfert bt = new BloodTransfert();
            bt.Show();
            this.Hide();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Dashboard da = new Dashboard();
            da.Show();
            this.Hide();
        }
    }
}
