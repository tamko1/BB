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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");

        private void Reset()
        {

            txtEmpName.Text = "";
            Email.Text = "";
            EmpAge.Text = "";
            txtNationality.Text = "";
            comboBoxEmpGender.SelectedIndex = -1;
            txtEmpPhone.Text = "";
            richTextBoxEmpAddress.Text = "";
        }
       
        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee ve = new ViewEmployee();
            ve.Show();
            this.Hide();
        }

        private void lblLDetails_Click(object sender, EventArgs e)
        {
            LoginDetail ld = new LoginDetail();
            ld.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Emplyee_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {

            if (txtEmpName.Text == "" || comboBoxEmpGender.SelectedIndex == -1 || txtEmpPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into Employee values('" + txtEmpName.Text + "', '" + Email.Text + "', "+ EmpAge.Text + ", '" + txtNationality.Text + "','" + comboBoxEmpGender.SelectedItem.ToString() + "','" + txtEmpPhone.Text + "','" + richTextBoxEmpAddress.Text + "')";
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Saved");

                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void lblempID_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpAge_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           AdminDashboard adb = new AdminDashboard();
            adb.Show();
            this.Hide();
        }

        private void lblViewEmp_Click(object sender, EventArgs e)
        {
            ViewEmployee ve = new ViewEmployee();
            ve.Show();
            this.Hide();
        }
    }
    
}
