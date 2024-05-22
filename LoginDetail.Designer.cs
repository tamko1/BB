namespace blood_bank
{
    partial class LoginDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelleft = new System.Windows.Forms.Panel();
            this.lblLDetails = new System.Windows.Forms.Label();
            this.lblViewEmp = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblbloodbank = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtBG = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblDonorBloodGroup = new System.Windows.Forms.Label();
            this.CbEmpId = new System.Windows.Forms.ComboBox();
            this.lblPatientList = new System.Windows.Forms.Label();
            this.panelleft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.MediumBlue;
            this.panelleft.Controls.Add(this.lblLDetails);
            this.panelleft.Controls.Add(this.lblViewEmp);
            this.panelleft.Controls.Add(this.lblEmployee);
            this.panelleft.Controls.Add(this.panel1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(259, 846);
            this.panelleft.TabIndex = 81;
            // 
            // lblLDetails
            // 
            this.lblLDetails.AutoSize = true;
            this.lblLDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLDetails.ForeColor = System.Drawing.Color.White;
            this.lblLDetails.Location = new System.Drawing.Point(35, 494);
            this.lblLDetails.Name = "lblLDetails";
            this.lblLDetails.Size = new System.Drawing.Size(136, 23);
            this.lblLDetails.TabIndex = 6;
            this.lblLDetails.Text = "Login Details";
            // 
            // lblViewEmp
            // 
            this.lblViewEmp.AutoSize = true;
            this.lblViewEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewEmp.ForeColor = System.Drawing.Color.White;
            this.lblViewEmp.Location = new System.Drawing.Point(35, 405);
            this.lblViewEmp.Name = "lblViewEmp";
            this.lblViewEmp.Size = new System.Drawing.Size(158, 23);
            this.lblViewEmp.TabIndex = 6;
            this.lblViewEmp.Text = "View Employee";
            this.lblViewEmp.Click += new System.EventHandler(this.lblViewEmp_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(51, 302);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(106, 23);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Employee";
            this.lblEmployee.Click += new System.EventHandler(this.lblEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(12, 478);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 57);
            this.panel1.TabIndex = 10;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumBlue;
            this.panelTop.Controls.Add(this.lblbloodbank);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(259, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1289, 48);
            this.panelTop.TabIndex = 82;
            // 
            // lblbloodbank
            // 
            this.lblbloodbank.AutoSize = true;
            this.lblbloodbank.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbloodbank.ForeColor = System.Drawing.Color.White;
            this.lblbloodbank.Location = new System.Drawing.Point(423, 9);
            this.lblbloodbank.Name = "lblbloodbank";
            this.lblbloodbank.Size = new System.Drawing.Size(386, 30);
            this.lblbloodbank.TabIndex = 1;
            this.lblbloodbank.Text = "Blood Bank Management system";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(477, 272);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 357);
            this.panel2.TabIndex = 94;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtPName
            // 
            this.txtPName.Enabled = false;
            this.txtPName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(747, 416);
            this.txtPName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(457, 31);
            this.txtPName.TabIndex = 87;
            // 
            // txtBG
            // 
            this.txtBG.Enabled = false;
            this.txtBG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBG.Location = new System.Drawing.Point(747, 478);
            this.txtBG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBG.Name = "txtBG";
            this.txtBG.Size = new System.Drawing.Size(457, 31);
            this.txtBG.TabIndex = 86;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPatientName.Location = new System.Drawing.Point(567, 416);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(162, 27);
            this.lblPatientName.TabIndex = 88;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPatientID.Location = new System.Drawing.Point(565, 363);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(121, 27);
            this.lblPatientID.TabIndex = 89;
            this.lblPatientID.Text = "Patient ID";
            // 
            // lblDonorBloodGroup
            // 
            this.lblDonorBloodGroup.AutoSize = true;
            this.lblDonorBloodGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorBloodGroup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorBloodGroup.Location = new System.Drawing.Point(567, 481);
            this.lblDonorBloodGroup.Name = "lblDonorBloodGroup";
            this.lblDonorBloodGroup.Size = new System.Drawing.Size(153, 27);
            this.lblDonorBloodGroup.TabIndex = 91;
            this.lblDonorBloodGroup.Text = "Blood Group";
            // 
            // CbEmpId
            // 
            this.CbEmpId.BackColor = System.Drawing.Color.Gainsboro;
            this.CbEmpId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEmpId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEmpId.FormattingEnabled = true;
            this.CbEmpId.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.CbEmpId.Location = new System.Drawing.Point(725, 353);
            this.CbEmpId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbEmpId.Name = "CbEmpId";
            this.CbEmpId.Size = new System.Drawing.Size(477, 31);
            this.CbEmpId.TabIndex = 90;
            // 
            // lblPatientList
            // 
            this.lblPatientList.AutoSize = true;
            this.lblPatientList.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientList.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPatientList.Location = new System.Drawing.Point(641, 94);
            this.lblPatientList.Name = "lblPatientList";
            this.lblPatientList.Size = new System.Drawing.Size(539, 55);
            this.lblPatientList.TabIndex = 93;
            this.lblPatientList.Text = "Employee Login Details";
            // 
            // LoginDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::blood_bank.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1548, 846);
            this.Controls.Add(this.lblPatientList);
            this.Controls.Add(this.CbEmpId);
            this.Controls.Add(this.lblDonorBloodGroup);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtBG);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginDetail";
            this.Text = "LoginDetails";
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Label lblLDetails;
        private System.Windows.Forms.Label lblViewEmp;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblbloodbank;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtBG;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblDonorBloodGroup;
        private System.Windows.Forms.ComboBox CbEmpId;
        private System.Windows.Forms.Label lblPatientList;
    }
}