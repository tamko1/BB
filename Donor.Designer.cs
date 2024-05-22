namespace blood_bank
{
    partial class Donor
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
            this.txtDName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDonorAge = new System.Windows.Forms.Label();
            this.txtDAge = new System.Windows.Forms.TextBox();
            this.lblDonorGender = new System.Windows.Forms.Label();
            this.lblDonorBloodGroup = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtDPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDonorID = new System.Windows.Forms.Label();
            this.comboBoxDGender = new System.Windows.Forms.ComboBox();
            this.comboBoxDBGroup = new System.Windows.Forms.ComboBox();
            this.richTextBoxDAddress = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.lblBloodDonate = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblBloodTransfert = new System.Windows.Forms.Label();
            this.lblBloodStock = new System.Windows.Forms.Label();
            this.lblViewPatient = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblViewDonor = new System.Windows.Forms.Label();
            this.lblDonor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblbloodbank = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPatientList = new System.Windows.Forms.Label();
            this.txtDNum = new System.Windows.Forms.TextBox();
            this.panelleft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDName
            // 
            this.txtDName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDName.Location = new System.Drawing.Point(215, 121);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(670, 31);
            this.txtDName.TabIndex = 6;
            this.txtDName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(474, 313);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 27);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Full Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblDonorAge
            // 
            this.lblDonorAge.AutoSize = true;
            this.lblDonorAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorAge.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorAge.Location = new System.Drawing.Point(474, 384);
            this.lblDonorAge.Name = "lblDonorAge";
            this.lblDonorAge.Size = new System.Drawing.Size(150, 27);
            this.lblDonorAge.TabIndex = 12;
            this.lblDonorAge.Text = "Donor\'s Age";
            // 
            // txtDAge
            // 
            this.txtDAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAge.Location = new System.Drawing.Point(249, 196);
            this.txtDAge.Name = "txtDAge";
            this.txtDAge.Size = new System.Drawing.Size(636, 31);
            this.txtDAge.TabIndex = 11;
            this.txtDAge.TextChanged += new System.EventHandler(this.txtDAge_TextChanged);
            // 
            // lblDonorGender
            // 
            this.lblDonorGender.AutoSize = true;
            this.lblDonorGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorGender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorGender.Location = new System.Drawing.Point(474, 462);
            this.lblDonorGender.Name = "lblDonorGender";
            this.lblDonorGender.Size = new System.Drawing.Size(96, 27);
            this.lblDonorGender.TabIndex = 14;
            this.lblDonorGender.Text = "Gender";
            // 
            // lblDonorBloodGroup
            // 
            this.lblDonorBloodGroup.AutoSize = true;
            this.lblDonorBloodGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorBloodGroup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorBloodGroup.Location = new System.Drawing.Point(866, 456);
            this.lblDonorBloodGroup.Name = "lblDonorBloodGroup";
            this.lblDonorBloodGroup.Size = new System.Drawing.Size(153, 27);
            this.lblDonorBloodGroup.TabIndex = 16;
            this.lblDonorBloodGroup.Text = "Blood Group";
            // 
            // lblPhone
            // 
            this.lblPhone.AllowDrop = true;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPhone.Location = new System.Drawing.Point(474, 540);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 27);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // txtDPhone
            // 
            this.txtDPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDPhone.Location = new System.Drawing.Point(587, 540);
            this.txtDPhone.Name = "txtDPhone";
            this.txtDPhone.Size = new System.Drawing.Size(225, 31);
            this.txtDPhone.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(884, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address";
            // 
            // lblDonorID
            // 
            this.lblDonorID.AutoSize = true;
            this.lblDonorID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorID.Location = new System.Drawing.Point(474, 241);
            this.lblDonorID.Name = "lblDonorID";
            this.lblDonorID.Size = new System.Drawing.Size(111, 27);
            this.lblDonorID.TabIndex = 21;
            this.lblDonorID.Text = "Donor ID";
            // 
            // comboBoxDGender
            // 
            this.comboBoxDGender.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxDGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDGender.FormattingEnabled = true;
            this.comboBoxDGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxDGender.Location = new System.Drawing.Point(587, 462);
            this.comboBoxDGender.Name = "comboBoxDGender";
            this.comboBoxDGender.Size = new System.Drawing.Size(225, 31);
            this.comboBoxDGender.TabIndex = 22;
            // 
            // comboBoxDBGroup
            // 
            this.comboBoxDBGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxDBGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDBGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDBGroup.FormattingEnabled = true;
            this.comboBoxDBGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBoxDBGroup.Location = new System.Drawing.Point(1038, 452);
            this.comboBoxDBGroup.Name = "comboBoxDBGroup";
            this.comboBoxDBGroup.Size = new System.Drawing.Size(247, 31);
            this.comboBoxDBGroup.TabIndex = 23;
            // 
            // richTextBoxDAddress
            // 
            this.richTextBoxDAddress.Location = new System.Drawing.Point(1009, 540);
            this.richTextBoxDAddress.Name = "richTextBoxDAddress";
            this.richTextBoxDAddress.Size = new System.Drawing.Size(276, 113);
            this.richTextBoxDAddress.TabIndex = 24;
            this.richTextBoxDAddress.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::blood_bank.Properties.Resources.icons8_sauvegarder_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(775, 746);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 74);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.MediumBlue;
            this.panelleft.Controls.Add(this.lblBloodDonate);
            this.panelleft.Controls.Add(this.lblDashboard);
            this.panelleft.Controls.Add(this.lblBloodTransfert);
            this.panelleft.Controls.Add(this.lblBloodStock);
            this.panelleft.Controls.Add(this.lblViewPatient);
            this.panelleft.Controls.Add(this.lblPatient);
            this.panelleft.Controls.Add(this.lblViewDonor);
            this.panelleft.Controls.Add(this.lblDonor);
            this.panelleft.Controls.Add(this.panel1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(258, 846);
            this.panelleft.TabIndex = 80;
            this.panelleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleft_Paint_1);
            // 
            // lblBloodDonate
            // 
            this.lblBloodDonate.AutoSize = true;
            this.lblBloodDonate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodDonate.ForeColor = System.Drawing.Color.White;
            this.lblBloodDonate.Location = new System.Drawing.Point(27, 382);
            this.lblBloodDonate.Name = "lblBloodDonate";
            this.lblBloodDonate.Size = new System.Drawing.Size(141, 23);
            this.lblBloodDonate.TabIndex = 9;
            this.lblBloodDonate.Text = "Donate Blood";
            this.lblBloodDonate.Click += new System.EventHandler(this.lblBloodDonate_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(27, 161);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(119, 23);
            this.lblDashboard.TabIndex = 8;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click_1);
            // 
            // lblBloodTransfert
            // 
            this.lblBloodTransfert.AutoSize = true;
            this.lblBloodTransfert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodTransfert.ForeColor = System.Drawing.Color.White;
            this.lblBloodTransfert.Location = new System.Drawing.Point(27, 678);
            this.lblBloodTransfert.Name = "lblBloodTransfert";
            this.lblBloodTransfert.Size = new System.Drawing.Size(163, 23);
            this.lblBloodTransfert.TabIndex = 8;
            this.lblBloodTransfert.Text = "Blood Transfert";
            this.lblBloodTransfert.Click += new System.EventHandler(this.lblBloodTransfert_Click);
            // 
            // lblBloodStock
            // 
            this.lblBloodStock.AutoSize = true;
            this.lblBloodStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodStock.ForeColor = System.Drawing.Color.White;
            this.lblBloodStock.Location = new System.Drawing.Point(27, 606);
            this.lblBloodStock.Name = "lblBloodStock";
            this.lblBloodStock.Size = new System.Drawing.Size(126, 23);
            this.lblBloodStock.TabIndex = 8;
            this.lblBloodStock.Text = "Blood Stock";
            this.lblBloodStock.Click += new System.EventHandler(this.lblBloodStock_Click);
            // 
            // lblViewPatient
            // 
            this.lblViewPatient.AutoSize = true;
            this.lblViewPatient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPatient.ForeColor = System.Drawing.Color.White;
            this.lblViewPatient.Location = new System.Drawing.Point(27, 526);
            this.lblViewPatient.Name = "lblViewPatient";
            this.lblViewPatient.Size = new System.Drawing.Size(130, 23);
            this.lblViewPatient.TabIndex = 8;
            this.lblViewPatient.Text = "View Patient";
            this.lblViewPatient.Click += new System.EventHandler(this.lblViewPatient_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.ForeColor = System.Drawing.Color.White;
            this.lblPatient.Location = new System.Drawing.Point(27, 455);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(78, 23);
            this.lblPatient.TabIndex = 6;
            this.lblPatient.Text = "Patient";
            this.lblPatient.Click += new System.EventHandler(this.lblPatient_Click);
            // 
            // lblViewDonor
            // 
            this.lblViewDonor.AutoSize = true;
            this.lblViewDonor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDonor.ForeColor = System.Drawing.Color.White;
            this.lblViewDonor.Location = new System.Drawing.Point(27, 311);
            this.lblViewDonor.Name = "lblViewDonor";
            this.lblViewDonor.Size = new System.Drawing.Size(122, 23);
            this.lblViewDonor.TabIndex = 6;
            this.lblViewDonor.Text = "View Donor";
            this.lblViewDonor.Click += new System.EventHandler(this.lblViewDonor_Click);
            // 
            // lblDonor
            // 
            this.lblDonor.AutoSize = true;
            this.lblDonor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonor.ForeColor = System.Drawing.Color.White;
            this.lblDonor.Location = new System.Drawing.Point(49, 241);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(70, 23);
            this.lblDonor.TabIndex = 4;
            this.lblDonor.Text = "Donor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(31, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 62);
            this.panel1.TabIndex = 10;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumBlue;
            this.panelTop.Controls.Add(this.lblbloodbank);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(258, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1290, 48);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDName);
            this.panel2.Controls.Add(this.txtDAge);
            this.panel2.Location = new System.Drawing.Point(400, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 531);
            this.panel2.TabIndex = 82;
            // 
            // lblPatientList
            // 
            this.lblPatientList.AutoSize = true;
            this.lblPatientList.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientList.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPatientList.Location = new System.Drawing.Point(594, 93);
            this.lblPatientList.Name = "lblPatientList";
            this.lblPatientList.Size = new System.Drawing.Size(608, 55);
            this.lblPatientList.TabIndex = 48;
            this.lblPatientList.Text = "Donor\'s Registration Form";
            // 
            // txtDNum
            // 
            this.txtDNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNum.Location = new System.Drawing.Point(615, 241);
            this.txtDNum.Name = "txtDNum";
            this.txtDNum.ReadOnly = true;
            this.txtDNum.Size = new System.Drawing.Size(670, 31);
            this.txtDNum.TabIndex = 20;
            // 
            // Donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::blood_bank.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1548, 846);
            this.Controls.Add(this.lblPatientList);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richTextBoxDAddress);
            this.Controls.Add(this.comboBoxDBGroup);
            this.Controls.Add(this.comboBoxDGender);
            this.Controls.Add(this.lblDonorID);
            this.Controls.Add(this.txtDNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtDPhone);
            this.Controls.Add(this.lblDonorBloodGroup);
            this.Controls.Add(this.lblDonorGender);
            this.Controls.Add(this.lblDonorAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor";
            this.Load += new System.EventHandler(this.Donor_Load);
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
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDonorAge;
        private System.Windows.Forms.TextBox txtDAge;
        private System.Windows.Forms.Label lblDonorGender;
        private System.Windows.Forms.Label lblDonorBloodGroup;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtDPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDonorID;
        private System.Windows.Forms.ComboBox comboBoxDGender;
        private System.Windows.Forms.ComboBox comboBoxDBGroup;
        private System.Windows.Forms.RichTextBox richTextBoxDAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Label lblBloodDonate;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblBloodTransfert;
        private System.Windows.Forms.Label lblBloodStock;
        private System.Windows.Forms.Label lblViewPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblViewDonor;
        private System.Windows.Forms.Label lblDonor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblbloodbank;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPatientList;
        private System.Windows.Forms.TextBox txtDNum;
    }
}