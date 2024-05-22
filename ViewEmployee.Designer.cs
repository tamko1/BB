namespace blood_bank
{
    partial class ViewEmployee
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
            this.lblLDetails = new System.Windows.Forms.Label();
            this.lblViewEmp = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblbloodbank = new System.Windows.Forms.Label();
            this.lblPatientList = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.richTextBoxEmpAddress = new System.Windows.Forms.RichTextBox();
            this.comboBoxEmpGender = new System.Windows.Forms.ComboBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.lblEmpGender = new System.Windows.Forms.Label();
            this.lblDonorAge = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.PassCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.Nationality = new System.Windows.Forms.Label();
            this.EmpAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.panelleft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.MediumBlue;
            this.panelleft.Controls.Add(this.label3);
            this.panelleft.Controls.Add(this.lblLDetails);
            this.panelleft.Controls.Add(this.lblViewEmp);
            this.panelleft.Controls.Add(this.lblEmployee);
            this.panelleft.Controls.Add(this.panel1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(259, 846);
            this.panelleft.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dashboard";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLDetails
            // 
            this.lblLDetails.AutoSize = true;
            this.lblLDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLDetails.ForeColor = System.Drawing.Color.White;
            this.lblLDetails.Location = new System.Drawing.Point(58, 572);
            this.lblLDetails.Name = "lblLDetails";
            this.lblLDetails.Size = new System.Drawing.Size(0, 23);
            this.lblLDetails.TabIndex = 6;
            this.lblLDetails.Click += new System.EventHandler(this.lblLDetails_Click);
            // 
            // lblViewEmp
            // 
            this.lblViewEmp.AutoSize = true;
            this.lblViewEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewEmp.ForeColor = System.Drawing.Color.White;
            this.lblViewEmp.Location = new System.Drawing.Point(58, 483);
            this.lblViewEmp.Name = "lblViewEmp";
            this.lblViewEmp.Size = new System.Drawing.Size(158, 23);
            this.lblViewEmp.TabIndex = 6;
            this.lblViewEmp.Text = "View Employee";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(31, 395);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(151, 23);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Add Employee";
            this.lblEmployee.Click += new System.EventHandler(this.lblEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(35, 460);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 65);
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
            this.panelTop.TabIndex = 81;
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
            this.lblPatientList.Location = new System.Drawing.Point(661, 81);
            this.lblPatientList.Name = "lblPatientList";
            this.lblPatientList.Size = new System.Drawing.Size(444, 55);
            this.lblPatientList.TabIndex = 82;
            this.lblPatientList.Text = "All Employees View";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEmployee.Location = new System.Drawing.Point(797, 207);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(697, 523);
            this.dgvEmployee.TabIndex = 99;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(300, 773);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 60);
            this.btnUpdate.TabIndex = 98;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackColor = System.Drawing.Color.Blue;
            this.btnPDelete.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDelete.ForeColor = System.Drawing.Color.White;
            this.btnPDelete.Location = new System.Drawing.Point(555, 773);
            this.btnPDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(165, 60);
            this.btnPDelete.TabIndex = 85;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = false;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // richTextBoxEmpAddress
            // 
            this.richTextBoxEmpAddress.Location = new System.Drawing.Point(440, 624);
            this.richTextBoxEmpAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxEmpAddress.Name = "richTextBoxEmpAddress";
            this.richTextBoxEmpAddress.Size = new System.Drawing.Size(324, 105);
            this.richTextBoxEmpAddress.TabIndex = 97;
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
            this.comboBoxEmpGender.Location = new System.Drawing.Point(427, 517);
            this.comboBoxEmpGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmpGender.Name = "comboBoxEmpGender";
            this.comboBoxEmpGender.Size = new System.Drawing.Size(337, 31);
            this.comboBoxEmpGender.TabIndex = 96;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmpID.Location = new System.Drawing.Point(300, 207);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(151, 27);
            this.lblEmpID.TabIndex = 95;
            this.lblEmpID.Text = "Employee ID";
            this.lblEmpID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNum.Location = new System.Drawing.Point(472, 207);
            this.txtEmpNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.ReadOnly = true;
            this.txtEmpNum.Size = new System.Drawing.Size(292, 31);
            this.txtEmpNum.TabIndex = 94;
            this.txtEmpNum.TextChanged += new System.EventHandler(this.txtEmpNum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(315, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 27);
            this.label7.TabIndex = 93;
            this.label7.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AllowDrop = true;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPhone.Location = new System.Drawing.Point(301, 570);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 27);
            this.lblPhone.TabIndex = 92;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPhone.Location = new System.Drawing.Point(427, 570);
            this.txtEmpPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(337, 31);
            this.txtEmpPhone.TabIndex = 91;
            // 
            // lblEmpGender
            // 
            this.lblEmpGender.AutoSize = true;
            this.lblEmpGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpGender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmpGender.Location = new System.Drawing.Point(301, 522);
            this.lblEmpGender.Name = "lblEmpGender";
            this.lblEmpGender.Size = new System.Drawing.Size(96, 27);
            this.lblEmpGender.TabIndex = 89;
            this.lblEmpGender.Text = "Gender";
            // 
            // lblDonorAge
            // 
            this.lblDonorAge.AutoSize = true;
            this.lblDonorAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorAge.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorAge.Location = new System.Drawing.Point(300, 361);
            this.lblDonorAge.Name = "lblDonorAge";
            this.lblDonorAge.Size = new System.Drawing.Size(172, 27);
            this.lblDonorAge.TabIndex = 88;
            this.lblDonorAge.Text = "Email Address";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(496, 361);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(268, 31);
            this.Email.TabIndex = 87;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(300, 306);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 27);
            this.lblName.TabIndex = 86;
            this.lblName.Text = "Full Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(441, 306);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(323, 31);
            this.txtEmpName.TabIndex = 84;
            // 
            // PassCode
            // 
            this.PassCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassCode.Location = new System.Drawing.Point(472, 252);
            this.PassCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassCode.Name = "PassCode";
            this.PassCode.ReadOnly = true;
            this.PassCode.Size = new System.Drawing.Size(292, 31);
            this.PassCode.TabIndex = 94;
            this.PassCode.TextChanged += new System.EventHandler(this.txtEmpNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(300, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 95;
            this.label1.Text = "Pass Code";
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(461, 462);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(303, 31);
            this.txtNationality.TabIndex = 87;
            // 
            // Nationality
            // 
            this.Nationality.AutoSize = true;
            this.Nationality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nationality.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Nationality.Location = new System.Drawing.Point(300, 462);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(131, 27);
            this.Nationality.TabIndex = 88;
            this.Nationality.Text = "Nationality";
            // 
            // EmpAge
            // 
            this.EmpAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAge.Location = new System.Drawing.Point(408, 415);
            this.EmpAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpAge.Name = "EmpAge";
            this.EmpAge.Size = new System.Drawing.Size(356, 31);
            this.EmpAge.TabIndex = 87;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAge.Location = new System.Drawing.Point(300, 415);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(57, 27);
            this.lblAge.TabIndex = 88;
            this.lblAge.Text = "Age";
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::blood_bank.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1548, 846);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPDelete);
            this.Controls.Add(this.richTextBoxEmpAddress);
            this.Controls.Add(this.comboBoxEmpGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.PassCode);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.lblEmpGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.lblDonorAge);
            this.Controls.Add(this.EmpAge);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblPatientList);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
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
        private System.Windows.Forms.Label lblPatientList;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.RichTextBox richTextBoxEmpAddress;
        private System.Windows.Forms.ComboBox comboBoxEmpGender;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.Label lblEmpGender;
        private System.Windows.Forms.Label lblDonorAge;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox PassCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label Nationality;
        private System.Windows.Forms.TextBox EmpAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label3;
    }
}