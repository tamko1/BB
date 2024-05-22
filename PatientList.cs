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

namespace blood_bank
{
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7BE87E;Initial Catalog=BloodBankDB;Integrated Security=True;Encrypt=False");


        private void populate()
        {
            Con.Open();
            string Query = "select * from Patient";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvPList.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            txtPNum.Text = "";
            txtPName.Text = "";
            txtPAge.Text = "";
            comboBoxPGender.SelectedIndex = -1;
            comboBoxPBGroup.SelectedIndex = -1;
            txtPPhone.Text = "";
            richTextBoxPAddress.Text = "";
            key = 0;
        }

        private void lblDonorBloodGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Select the Patient to Delete ");
            }
            else
            {
                try
                {
                    string query = "delete from Patient WHERE PNum = "+key+"";
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted");

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
        private void dgvPList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPNum.Text = dgvPList.SelectedRows[0].Cells[0].Value.ToString();
            txtPName.Text = dgvPList.SelectedRows[0].Cells[1].Value.ToString();
            txtPAge.Text = dgvPList.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxPGender.SelectedItem = dgvPList.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxPBGroup.SelectedItem = dgvPList.SelectedRows[0].Cells[4].Value.ToString();
            txtPPhone.Text = dgvPList.SelectedRows[0].Cells[5].Value.ToString();
            richTextBoxPAddress.Text = dgvPList.SelectedRows[0].Cells[6].Value.ToString();
            if (txtPName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvPList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void richTextBoxPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientList_Load(object sender, EventArgs e)
        {

        }

        private void lblViewPatient_Click(object sender, EventArgs e)
        {
            PatientList pl = new PatientList();
            pl.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPName.Text == "" || txtPAge.Text == "" || comboBoxPGender.SelectedIndex == -1 || comboBoxPBGroup.SelectedIndex == -1 || txtPPhone.Text == "")
            {
                MessageBox.Show("Missing information ");
            }
            else
            {
                try
                {
                    string query = "update Patient set PName ='"+ txtPName.Text + "', PAge="+ txtPAge.Text + ", PGender='"+ comboBoxPGender.SelectedItem.ToString() + "', PBGroup='"+ comboBoxPBGroup.SelectedItem.ToString() + "', PPhone='"+ txtPPhone.Text + "', PAddress='"+ richTextBoxPAddress.Text +"'where PNum ="+key+"";
                    Con.Open();

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Updated");

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

        private void comboBoxPGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblViewPatient_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
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
            
        }

        private void comboBoxPBGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtPPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
          
        }

        private void lblPatientID_Click(object sender, EventArgs e)
        {

        }

        private void txtPNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDonorGender_Click(object sender, EventArgs e)
        {

        }

        private void lblDonorAge_Click(object sender, EventArgs e)
        {

        }

        private void txtPAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBloodTransfert_Click(object sender, EventArgs e)
        {
            BloodTransfert bt = new BloodTransfert();
            bt.Show();
            this.Hide();
        }

        private void lblViewPatient_Click_2(object sender, EventArgs e)
        {

        }

        private void lblDonor_Click_1(object sender, EventArgs e)
        {
            Donor d = new Donor();
            d.Show();
            this.Hide();
        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblViewDonor_Click_1(object sender, EventArgs e)
        {
            DonorView dv = new DonorView(); 
            dv.Show();
            this.Hide();
        }

        private void lblBloodDonate_Click_1(object sender, EventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
