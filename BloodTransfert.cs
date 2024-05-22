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
    public partial class BloodTransfert : Form
    {
        public BloodTransfert()
        {
            InitializeComponent();
            fillPatient();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");

        private void fillPatient()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PNum from Patient", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(int));
            dt.Load(rdr);
            CbPatId.ValueMember = "PNum";
            CbPatId.DataSource = dt;
            Con.Close();
        }

        private void GetData()
        {
            Con.Open();
            string query = "select * from Patient where PNum=" + CbPatId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtPName.Text = dr["PName"].ToString();
                txtBG.Text = dr["PBGroup"].ToString();
            }
            Con.Close();
        }

        int stock = 0;
        private void GetStock(string Bgroup)
        {
            Con.Open();
            string Query = "select * from Blood where BGroup='" + Bgroup + "';";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();
        }
        private void BloodTransfert_Load(object sender, EventArgs e)
        {

        }


       /* int oldstock;
        private void GetStock(string Bgroup)
        {
            Con.Open();
            string Query = "select * from Blood where BGroup='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();
        
        }*/



        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbPatId_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CbPatId_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
           GetData();
            GetStock(txtBG.Text);
            if(stock>0)
            {
                btnTransfert.Visible = true;
                lblAvailable.Text = "Available Stock";
                lblAvailable.Visible = true;
            }
            else
            {
                lblAvailable.Text = "NO Available Stock";
                lblAvailable.Visible = true;
            }
        }
        private void Reset()
        {
            txtPName.Text = "";
            txtBG.Text = ""; 
            //CbPatId.SelectedIndex = -1;
            lblAvailable.Visible = false;
            btnTransfert.Visible = false;
        }

        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {
                string query = "update Blood set BStock =" + newstock + " where BGroup ='" + txtBG.Text + "';";
                Con.Open();

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Patient Successfully Deleted");

                Con.Close();
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void btnTransfert_Click(object sender, EventArgs e)
        {
            if (txtPName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
               try
                {
                    string query = "insert into Transfer values('" + txtPName.Text + "', '" + txtBG.Text + "')";
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transfert Successfully");

                    Con.Close();
                    GetStock(txtBG.Text);
                    updateStock();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {
            Patient p=new Patient();
            p.Show();
            this.Hide();
        }

        private void lblBloodStock_Click(object sender, EventArgs e)
        {
            BloodStock bs = new BloodStock();
            bs.Show();
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

        private void lblPatient_Click_1(object sender, EventArgs e)
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

        private void lblBloodStock_Click_1(object sender, EventArgs e)
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

        private void lblAvailable_Click(object sender, EventArgs e)
        {

        }

        private void txtBGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
