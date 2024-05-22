using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blood_bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblContinueAdmin_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else if (txtPassword.Text == "password")
            {
                AdminDashboard adh = new AdminDashboard();
                adh.Show();
                this.Hide();    

            }
        }

        private void hideshow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (hideshow.Text == "Show")
            {
                hideshow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                hideshow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }
    }   
}
