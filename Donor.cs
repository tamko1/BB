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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing.Drawing2D;
namespace blood_bank
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        private void Donor_Load(object sender, EventArgs e)
        {

        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");


        private void Reset()
        {
            txtDName.Text = "";
            txtDAge.Text = "";
            comboBoxDGender.SelectedIndex = -1;
            comboBoxDBGroup.SelectedIndex= -1;
            txtDPhone.Text = "";
            richTextBoxDAddress.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDName.Text == "" || txtDAge.Text == "" || comboBoxDGender.SelectedIndex == -1 || comboBoxDBGroup.SelectedIndex == -1 || txtDPhone.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try 
                {
                    string query = "insert into Donor values('" + txtDName.Text + "', " + txtDAge.Text + ", '" + comboBoxDGender.SelectedItem.ToString() + "', '" + comboBoxDBGroup.SelectedItem.ToString() + "','" + txtDPhone.Text + "','" + richTextBoxDAddress.Text + "')";
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Saved");

                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                { 
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtDAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelleft_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
