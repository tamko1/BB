namespace blood_bank
{
    partial class PatientList
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
            this.comboBoxPBGroup = new System.Windows.Forms.ComboBox();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.richTextBoxPAddress = new System.Windows.Forms.RichTextBox();
            this.comboBoxPGender = new System.Windows.Forms.ComboBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPPhone = new System.Windows.Forms.TextBox();
            this.lblDonorBloodGroup = new System.Windows.Forms.Label();
            this.lblDonorGender = new System.Windows.Forms.Label();
            this.lblDonorAge = new System.Windows.Forms.Label();
            this.txtPAge = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblPatientList = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvPList = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPList)).BeginInit();
            this.panelleft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPBGroup
            // 
            this.comboBoxPBGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxPBGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPBGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPBGroup.FormattingEnabled = true;
            this.comboBoxPBGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBoxPBGroup.Location = new System.Drawing.Point(496, 443);
            this.comboBoxPBGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPBGroup.Name = "comboBoxPBGroup";
            this.comboBoxPBGroup.Size = new System.Drawing.Size(263, 31);
            this.comboBoxPBGroup.TabIndex = 44;
            this.comboBoxPBGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxPBGroup_SelectedIndexChanged);
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackColor = System.Drawing.Color.Blue;
            this.btnPDelete.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDelete.ForeColor = System.Drawing.Color.White;
            this.btnPDelete.Location = new System.Drawing.Point(565, 774);
            this.btnPDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(165, 60);
            this.btnPDelete.TabIndex = 47;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = false;
            this.btnPDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // richTextBoxPAddress
            // 
            this.richTextBoxPAddress.Location = new System.Drawing.Point(447, 585);
            this.richTextBoxPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxPAddress.Name = "richTextBoxPAddress";
            this.richTextBoxPAddress.Size = new System.Drawing.Size(312, 131);
            this.richTextBoxPAddress.TabIndex = 59;
            this.richTextBoxPAddress.Text = "";
            this.richTextBoxPAddress.TextChanged += new System.EventHandler(this.richTextBoxPAddress_TextChanged);
            // 
            // comboBoxPGender
            // 
            this.comboBoxPGender.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxPGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPGender.FormattingEnabled = true;
            this.comboBoxPGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxPGender.Location = new System.Drawing.Point(447, 383);
            this.comboBoxPGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPGender.Name = "comboBoxPGender";
            this.comboBoxPGender.Size = new System.Drawing.Size(312, 31);
            this.comboBoxPGender.TabIndex = 58;
            this.comboBoxPGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxPGender_SelectedIndexChanged);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPatientID.Location = new System.Drawing.Point(307, 174);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(121, 27);
            this.lblPatientID.TabIndex = 57;
            this.lblPatientID.Text = "Patient ID";
            this.lblPatientID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // txtPNum
            // 
            this.txtPNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNum.Location = new System.Drawing.Point(447, 174);
            this.txtPNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPNum.Name = "txtPNum";
            this.txtPNum.ReadOnly = true;
            this.txtPNum.Size = new System.Drawing.Size(312, 31);
            this.txtPNum.TabIndex = 56;
            this.txtPNum.TextChanged += new System.EventHandler(this.txtPNum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(323, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 27);
            this.label7.TabIndex = 55;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AllowDrop = true;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPhone.Location = new System.Drawing.Point(323, 513);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 27);
            this.lblPhone.TabIndex = 54;
            this.lblPhone.Text = "Phone";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtPPhone
            // 
            this.txtPPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPhone.Location = new System.Drawing.Point(447, 513);
            this.txtPPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.Size = new System.Drawing.Size(312, 31);
            this.txtPPhone.TabIndex = 53;
            this.txtPPhone.TextChanged += new System.EventHandler(this.txtPPhone_TextChanged);
            // 
            // lblDonorBloodGroup
            // 
            this.lblDonorBloodGroup.AutoSize = true;
            this.lblDonorBloodGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorBloodGroup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorBloodGroup.Location = new System.Drawing.Point(307, 443);
            this.lblDonorBloodGroup.Name = "lblDonorBloodGroup";
            this.lblDonorBloodGroup.Size = new System.Drawing.Size(153, 27);
            this.lblDonorBloodGroup.TabIndex = 52;
            this.lblDonorBloodGroup.Text = "Blood Group";
            this.lblDonorBloodGroup.Click += new System.EventHandler(this.lblDonorBloodGroup_Click);
            // 
            // lblDonorGender
            // 
            this.lblDonorGender.AutoSize = true;
            this.lblDonorGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorGender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorGender.Location = new System.Drawing.Point(307, 383);
            this.lblDonorGender.Name = "lblDonorGender";
            this.lblDonorGender.Size = new System.Drawing.Size(96, 27);
            this.lblDonorGender.TabIndex = 51;
            this.lblDonorGender.Text = "Gender";
            this.lblDonorGender.Click += new System.EventHandler(this.lblDonorGender_Click);
            // 
            // lblDonorAge
            // 
            this.lblDonorAge.AutoSize = true;
            this.lblDonorAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorAge.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorAge.Location = new System.Drawing.Point(307, 315);
            this.lblDonorAge.Name = "lblDonorAge";
            this.lblDonorAge.Size = new System.Drawing.Size(142, 27);
            this.lblDonorAge.TabIndex = 50;
            this.lblDonorAge.Text = "Patient Age";
            this.lblDonorAge.Click += new System.EventHandler(this.lblDonorAge_Click);
            // 
            // txtPAge
            // 
            this.txtPAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAge.Location = new System.Drawing.Point(468, 315);
            this.txtPAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPAge.Name = "txtPAge";
            this.txtPAge.Size = new System.Drawing.Size(291, 31);
            this.txtPAge.TabIndex = 49;
            this.txtPAge.TextChanged += new System.EventHandler(this.txtPAge_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(307, 242);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 27);
            this.lblName.TabIndex = 48;
            this.lblName.Text = "Full Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(447, 242);
            this.txtPName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(312, 31);
            this.txtPName.TabIndex = 46;
            this.txtPName.TextChanged += new System.EventHandler(this.txtPName_TextChanged);
            // 
            // lblPatientList
            // 
            this.lblPatientList.AutoSize = true;
            this.lblPatientList.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientList.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPatientList.Location = new System.Drawing.Point(687, 78);
            this.lblPatientList.Name = "lblPatientList";
            this.lblPatientList.Size = new System.Drawing.Size(371, 55);
            this.lblPatientList.TabIndex = 45;
            this.lblPatientList.Text = "All Patient View";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(311, 774);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 60);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvPList
            // 
            this.dgvPList.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPList.Location = new System.Drawing.Point(789, 174);
            this.dgvPList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPList.Name = "dgvPList";
            this.dgvPList.RowHeadersWidth = 51;
            this.dgvPList.RowTemplate.Height = 24;
            this.dgvPList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPList.Size = new System.Drawing.Size(732, 542);
            this.dgvPList.TabIndex = 61;
            this.dgvPList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPList_CellContentClick);
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
            this.panelleft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(259, 846);
            this.panelleft.TabIndex = 72;
            this.panelleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleft_Paint);
            // 
            // lblBloodDonate
            // 
            this.lblBloodDonate.AutoSize = true;
            this.lblBloodDonate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodDonate.ForeColor = System.Drawing.Color.White;
            this.lblBloodDonate.Location = new System.Drawing.Point(38, 370);
            this.lblBloodDonate.Name = "lblBloodDonate";
            this.lblBloodDonate.Size = new System.Drawing.Size(141, 23);
            this.lblBloodDonate.TabIndex = 9;
            this.lblBloodDonate.Text = "Donate Blood";
            this.lblBloodDonate.Click += new System.EventHandler(this.lblBloodDonate_Click_1);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(38, 159);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(119, 23);
            this.lblDashboard.TabIndex = 8;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // lblBloodTransfert
            // 
            this.lblBloodTransfert.AutoSize = true;
            this.lblBloodTransfert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodTransfert.ForeColor = System.Drawing.Color.White;
            this.lblBloodTransfert.Location = new System.Drawing.Point(38, 666);
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
            this.lblBloodStock.Location = new System.Drawing.Point(38, 594);
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
            this.lblViewPatient.Location = new System.Drawing.Point(38, 523);
            this.lblViewPatient.Name = "lblViewPatient";
            this.lblViewPatient.Size = new System.Drawing.Size(130, 23);
            this.lblViewPatient.TabIndex = 8;
            this.lblViewPatient.Text = "View Patient";
            this.lblViewPatient.Click += new System.EventHandler(this.lblViewPatient_Click_2);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.ForeColor = System.Drawing.Color.White;
            this.lblPatient.Location = new System.Drawing.Point(38, 443);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(78, 23);
            this.lblPatient.TabIndex = 6;
            this.lblPatient.Text = "Patient";
            this.lblPatient.Click += new System.EventHandler(this.lblPatient_Click_1);
            // 
            // lblViewDonor
            // 
            this.lblViewDonor.AutoSize = true;
            this.lblViewDonor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDonor.ForeColor = System.Drawing.Color.White;
            this.lblViewDonor.Location = new System.Drawing.Point(38, 299);
            this.lblViewDonor.Name = "lblViewDonor";
            this.lblViewDonor.Size = new System.Drawing.Size(122, 23);
            this.lblViewDonor.TabIndex = 6;
            this.lblViewDonor.Text = "View Donor";
            this.lblViewDonor.Click += new System.EventHandler(this.lblViewDonor_Click_1);
            // 
            // lblDonor
            // 
            this.lblDonor.AutoSize = true;
            this.lblDonor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonor.ForeColor = System.Drawing.Color.White;
            this.lblDonor.Location = new System.Drawing.Point(38, 224);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(70, 23);
            this.lblDonor.TabIndex = 4;
            this.lblDonor.Text = "Donor";
            this.lblDonor.Click += new System.EventHandler(this.lblDonor_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(30, 509);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 54);
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
            this.panelTop.TabIndex = 73;
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
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::blood_bank.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1548, 846);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.dgvPList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBoxPBGroup);
            this.Controls.Add(this.btnPDelete);
            this.Controls.Add(this.richTextBoxPAddress);
            this.Controls.Add(this.comboBoxPGender);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtPNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPPhone);
            this.Controls.Add(this.lblDonorBloodGroup);
            this.Controls.Add(this.lblDonorGender);
            this.Controls.Add(this.lblDonorAge);
            this.Controls.Add(this.txtPAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.lblPatientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientList";
            this.Load += new System.EventHandler(this.PatientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPList)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPBGroup;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.RichTextBox richTextBoxPAddress;
        private System.Windows.Forms.ComboBox comboBoxPGender;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPPhone;
        private System.Windows.Forms.Label lblDonorBloodGroup;
        private System.Windows.Forms.Label lblDonorGender;
        private System.Windows.Forms.Label lblDonorAge;
        private System.Windows.Forms.TextBox txtPAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPatientList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvPList;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Label lblBloodDonate;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblBloodTransfert;
        private System.Windows.Forms.Label lblBloodStock;
        private System.Windows.Forms.Label lblViewPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblViewDonor;
        private System.Windows.Forms.Label lblDonor;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblbloodbank;
        private System.Windows.Forms.Panel panel1;
    }
}