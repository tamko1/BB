namespace blood_bank
{
    partial class Employee
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblViewEmp = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblbloodbank = new System.Windows.Forms.Label();
            this.lblPatientList = new System.Windows.Forms.Label();
            this.btnEmpSave = new System.Windows.Forms.Button();
            this.richTextBoxEmpAddress = new System.Windows.Forms.RichTextBox();
            this.comboBoxEmpGender = new System.Windows.Forms.ComboBox();
            this.lblempID = new System.Windows.Forms.Label();
            this.txtPnum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.lblDonorGender = new System.Windows.Forms.Label();
            this.lblEmpAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PassCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpAge = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.panelleft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.MediumBlue;
            this.panelleft.Controls.Add(this.label3);
            this.panelleft.Controls.Add(this.lblViewEmp);
            this.panelleft.Controls.Add(this.lblEmployee);
            this.panelleft.Controls.Add(this.panel1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(259, 846);
            this.panelleft.TabIndex = 79;
            this.panelleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleft_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dashboard";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblViewEmp
            // 
            this.lblViewEmp.AutoSize = true;
            this.lblViewEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewEmp.ForeColor = System.Drawing.Color.White;
            this.lblViewEmp.Location = new System.Drawing.Point(35, 473);
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
            this.lblEmployee.Location = new System.Drawing.Point(51, 377);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(151, 23);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Add Employee";
            this.lblEmployee.Click += new System.EventHandler(this.lblEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(39, 361);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 58);
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
            this.panelTop.TabIndex = 80;
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
            // lblPatientList
            // 
            this.lblPatientList.AutoSize = true;
            this.lblPatientList.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientList.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPatientList.Location = new System.Drawing.Point(581, 82);
            this.lblPatientList.Name = "lblPatientList";
            this.lblPatientList.Size = new System.Drawing.Size(650, 55);
            this.lblPatientList.TabIndex = 81;
            this.lblPatientList.Text = "Employee Registration Form";
            // 
            // btnEmpSave
            // 
            this.btnEmpSave.BackColor = System.Drawing.Color.Blue;
            this.btnEmpSave.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSave.ForeColor = System.Drawing.Color.White;
            this.btnEmpSave.Location = new System.Drawing.Point(844, 773);
            this.btnEmpSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpSave.Name = "btnEmpSave";
            this.btnEmpSave.Size = new System.Drawing.Size(165, 60);
            this.btnEmpSave.TabIndex = 84;
            this.btnEmpSave.Text = "Save";
            this.btnEmpSave.UseVisualStyleBackColor = false;
            this.btnEmpSave.Click += new System.EventHandler(this.btnEmpSave_Click);
            // 
            // richTextBoxEmpAddress
            // 
            this.richTextBoxEmpAddress.Location = new System.Drawing.Point(237, 368);
            this.richTextBoxEmpAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxEmpAddress.Name = "richTextBoxEmpAddress";
            this.richTextBoxEmpAddress.Size = new System.Drawing.Size(604, 138);
            this.richTextBoxEmpAddress.TabIndex = 96;
            this.richTextBoxEmpAddress.Text = "";
            // 
            // comboBoxEmpGender
            // 
            this.comboBoxEmpGender.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxEmpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpGender.FormattingEnabled = true;
            this.comboBoxEmpGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxEmpGender.Location = new System.Drawing.Point(253, 274);
            this.comboBoxEmpGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmpGender.Name = "comboBoxEmpGender";
            this.comboBoxEmpGender.Size = new System.Drawing.Size(228, 31);
            this.comboBoxEmpGender.TabIndex = 95;
            // 
            // lblempID
            // 
            this.lblempID.AutoSize = true;
            this.lblempID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblempID.Location = new System.Drawing.Point(107, 62);
            this.lblempID.Name = "lblempID";
            this.lblempID.Size = new System.Drawing.Size(151, 27);
            this.lblempID.TabIndex = 94;
            this.lblempID.Text = "Employee ID";
            this.lblempID.Click += new System.EventHandler(this.lblempID_Click);
            // 
            // txtPnum
            // 
            this.txtPnum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPnum.Location = new System.Drawing.Point(279, 62);
            this.txtPnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPnum.Name = "txtPnum";
            this.txtPnum.ReadOnly = true;
            this.txtPnum.Size = new System.Drawing.Size(203, 31);
            this.txtPnum.TabIndex = 93;
            this.txtPnum.TextChanged += new System.EventHandler(this.txtPnum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(495, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 27);
            this.label7.TabIndex = 92;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AllowDrop = true;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPhone.Location = new System.Drawing.Point(613, 278);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 27);
            this.lblPhone.TabIndex = 91;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPhone.Location = new System.Drawing.Point(703, 278);
            this.txtEmpPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(289, 31);
            this.txtEmpPhone.TabIndex = 90;
            // 
            // lblDonorGender
            // 
            this.lblDonorGender.AutoSize = true;
            this.lblDonorGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorGender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorGender.Location = new System.Drawing.Point(133, 274);
            this.lblDonorGender.Name = "lblDonorGender";
            this.lblDonorGender.Size = new System.Drawing.Size(96, 27);
            this.lblDonorGender.TabIndex = 88;
            this.lblDonorGender.Text = "Gender";
            // 
            // lblEmpAge
            // 
            this.lblEmpAge.AutoSize = true;
            this.lblEmpAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAge.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmpAge.Location = new System.Drawing.Point(133, 224);
            this.lblEmpAge.Name = "lblEmpAge";
            this.lblEmpAge.Size = new System.Drawing.Size(57, 27);
            this.lblEmpAge.TabIndex = 87;
            this.lblEmpAge.Text = "Age";
            this.lblEmpAge.Click += new System.EventHandler(this.lblEmpAge_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(107, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 27);
            this.lblName.TabIndex = 85;
            this.lblName.Text = "Full Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(253, 116);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(739, 31);
            this.txtEmpName.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBoxEmpAddress);
            this.panel2.Controls.Add(this.PassCode);
            this.panel2.Controls.Add(this.txtPnum);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblempID);
            this.panel2.Controls.Add(this.EmpAge);
            this.panel2.Controls.Add(this.txtNationality);
            this.panel2.Controls.Add(this.comboBoxEmpGender);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtEmpPhone);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.txtEmpName);
            this.panel2.Controls.Add(this.lblEmpAge);
            this.panel2.Controls.Add(this.lblDonorGender);
            this.panel2.Location = new System.Drawing.Point(367, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 554);
            this.panel2.TabIndex = 97;
            // 
            // PassCode
            // 
            this.PassCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassCode.Location = new System.Drawing.Point(751, 62);
            this.PassCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassCode.Name = "PassCode";
            this.PassCode.ReadOnly = true;
            this.PassCode.Size = new System.Drawing.Size(241, 31);
            this.PassCode.TabIndex = 93;
            this.PassCode.TextChanged += new System.EventHandler(this.txtPnum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(588, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 94;
            this.label2.Text = "Pass Code";
            this.label2.Click += new System.EventHandler(this.lblempID_Click);
            // 
            // EmpAge
            // 
            this.EmpAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAge.Location = new System.Drawing.Point(211, 224);
            this.EmpAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpAge.Name = "EmpAge";
            this.EmpAge.Size = new System.Drawing.Size(271, 31);
            this.EmpAge.TabIndex = 90;
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(751, 228);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(241, 31);
            this.txtNationality.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(613, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 91;
            this.label1.Text = "Nationality";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmail.Location = new System.Drawing.Point(107, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(172, 27);
            this.lblEmail.TabIndex = 85;
            this.lblEmail.Text = "Email Address";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(300, 174);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(692, 31);
            this.Email.TabIndex = 83;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::blood_bank.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1548, 846);
            this.Controls.Add(this.btnEmpSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPatientList);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emplyee";
            this.Load += new System.EventHandler(this.Emplyee_Load);
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblbloodbank;
        private System.Windows.Forms.Label lblPatientList;
        private System.Windows.Forms.Label lblViewEmp;
        private System.Windows.Forms.Button btnEmpSave;
        private System.Windows.Forms.RichTextBox richTextBoxEmpAddress;
        private System.Windows.Forms.ComboBox comboBoxEmpGender;
        private System.Windows.Forms.Label lblempID;
        private System.Windows.Forms.TextBox txtPnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.Label lblDonorGender;
        private System.Windows.Forms.Label lblEmpAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpAge;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PassCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}