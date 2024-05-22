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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");

        private void Reset()
        {
            txtPnum.Text = "";
            txtPName.Text = "";
            txtPAge.Text = "";
            comboBoxPGender.SelectedIndex = -1;
            comboBoxPBGroup.SelectedIndex = -1;
            txtPPhone.Text = "";
            richTextBoxPAddress.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPName.Text == "" || txtPAge.Text == "" || comboBoxPGender.SelectedIndex == -1 || comboBoxPBGroup.SelectedIndex == -1 || txtPPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into Patient values('" + txtPName.Text + "', " + txtPAge.Text + ", '" + comboBoxPGender.SelectedItem.ToString() + "', '" + comboBoxPBGroup.SelectedItem.ToString() + "','" + txtPPhone.Text + "','" + richTextBoxPAddress.Text + "')";
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Saved");

                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void lblPatient_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void lblPatient_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lblViewPatient_Click(object sender, EventArgs e)
        {
        }

        private void lblBloodTransfert_Click(object sender, EventArgs e)
        {
            BloodTransfert bt = new BloodTransfert();
            bt.Show();
            this.Hide(); 
        }

        private void txtPnum_TextChanged(object sender, EventArgs e)
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

        private void lblBloodDonate_Click(object sender, EventArgs e)
        {
            DonateBlood db = new DonateBlood();
            db.Show();
            this.Hide();
        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblBloodStock_Click(object sender, EventArgs e)
        {
            BloodStock bs = new BloodStock();
            bs.Show();
            this.Hide();
        }

        private void lblBloodTransfert_Click_1(object sender, EventArgs e)
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

        private void lblViewPatient_Click_1(object sender, EventArgs e)
        {
            PatientList pl = new PatientList();
            pl.Show();
            this.Hide();
        }

        private void lblPatient_Click_2(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();

        }
    }
}
