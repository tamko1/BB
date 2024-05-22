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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");

        private void populate()
        {
            Con.Open();
            string Query = "select * from Employee";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvEmployee.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            txtEmpNum.Text = "";    
            txtEmpName.Text = "";
            Email.Text = "";
            EmpAge.Text = "";
            txtNationality.Text = "";
            comboBoxEmpGender.SelectedIndex = -1;
            txtEmpPhone.Text = "";
            richTextBoxEmpAddress.Text = "";
            key = 0;
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void lblLDetails_Click(object sender, EventArgs e)
        {
            LoginDetail ld = new LoginDetail();
            ld.Show();
            this.Hide();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPatientID_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "" || comboBoxEmpGender.SelectedIndex == -1 || txtEmpPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "update Employee set EmpName= '" + txtEmpName.Text + "', EmpEmail = '" + Email.Text + "', EmpAge = " + EmpAge.Text + ", Nationality ='" + txtNationality.Text + "',EmpGender = '" + comboBoxEmpGender.SelectedItem.ToString() + "',EmpPhone = '" + txtEmpPhone.Text + "',EmpAddress='" + richTextBoxEmpAddress.Text + "' where EmpNum="+key+";";
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Information Successfully Updated");

                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Employee Information to Delete ");
            }
            else
            {
                try
                {
                    string query = "delete from Employee WHERE EmpNum = " + key + "";
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Information Successfully Deleted");

                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpNum.Text = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpName.Text = dgvEmployee.SelectedRows[0].Cells[1].Value.ToString();
            Email.Text = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();
            EmpAge.Text = dgvEmployee.SelectedRows[0].Cells[3].Value.ToString();
            txtNationality.Text = dgvEmployee.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxEmpGender.SelectedItem = dgvEmployee.SelectedRows[0].Cells[5].Value.ToString();
            txtEmpPhone.Text = dgvEmployee.SelectedRows[0].Cells[6].Value.ToString();
            richTextBoxEmpAddress.Text = dgvEmployee.SelectedRows[0].Cells[7].Value.ToString();
            if (txtEmpName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
          
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
 