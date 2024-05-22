namespace blood_bank
{
    partial class BloodTransfert
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
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.CbPatId = new System.Windows.Forms.ComboBox();
            this.lblDonorBloodGroup = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.btnTransfert = new System.Windows.Forms.Button();
            this.txtBG = new System.Windows.Forms.TextBox();
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
            this.lblPatientList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelleft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPatientID.Location = new System.Drawing.Point(530, 283);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(121, 27);
            this.lblPatientID.TabIndex = 63;
            this.lblPatientID.Text = "Patient ID";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPatientName.Location = new System.Drawing.Point(531, 336);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(162, 27);
            this.lblPatientName.TabIndex = 60;
            this.lblPatientName.Text = "Patient Name";
            // 
            // txtPName
            // 
            this.txtPName.Enabled = false;
            this.txtPName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(710, 336);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(457, 31);
            this.txtPName.TabIndex = 59;
            // 
            // CbPatId
            // 
            this.CbPatId.BackColor = System.Drawing.Color.Gainsboro;
            this.CbPatId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPatId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPatId.FormattingEnabled = true;
            this.CbPatId.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.CbPatId.Location = new System.Drawing.Point(690, 273);
            this.CbPatId.Name = "CbPatId";
            this.CbPatId.Size = new System.Drawing.Size(477, 31);
            this.CbPatId.TabIndex = 64;
            this.CbPatId.SelectionChangeCommitted += new System.EventHandler(this.CbPatId_SelectionChangeCommitted_1);
            // 
            // lblDonorBloodGroup
            // 
            this.lblDonorBloodGroup.AutoSize = true;
            this.lblDonorBloodGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorBloodGroup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDonorBloodGroup.Location = new System.Drawing.Point(531, 401);
            this.lblDonorBloodGroup.Name = "lblDonorBloodGroup";
            this.lblDonorBloodGroup.Size = new System.Drawing.Size(153, 27);
            this.lblDonorBloodGroup.TabIndex = 65;
            this.lblDonorBloodGroup.Text = "Blood Group";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.ForeColor = System.Drawing.Color.Crimson;
            this.lblAvailable.Location = new System.Drawing.Point(240, 327);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(408, 42);
            this.lblAvailable.TabIndex = 66;
            this.lblAvailable.Text = "Available/ Not Available";
            this.lblAvailable.Visible = false;
            this.lblAvailable.Click += new System.EventHandler(this.lblAvailable_Click);
            // 
            // btnTransfert
            // 
            this.btnTransfert.BackColor = System.Drawing.Color.Blue;
            this.btnTransfert.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfert.ForeColor = System.Drawing.Color.White;
            this.btnTransfert.Location = new System.Drawing.Point(816, 740);
            this.btnTransfert.Name = "btnTransfert";
            this.btnTransfert.Size = new System.Drawing.Size(166, 60);
            this.btnTransfert.TabIndex = 67;
            this.btnTransfert.Text = "Transfert";
            this.btnTransfert.UseVisualStyleBackColor = false;
            this.btnTransfert.Visible = false;
            this.btnTransfert.Click += new System.EventHandler(this.btnTransfert_Click);
            // 
            // txtBG
            // 
            this.txtBG.Enabled = false;
            this.txtBG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBG.Location = new System.Drawing.Point(710, 397);
            this.txtBG.Name = "txtBG";
            this.txtBG.Size = new System.Drawing.Size(457, 31);
            this.txtBG.TabIndex = 59;
            this.txtBG.TextChanged += new System.EventHandler(this.txtBGroup_TextChanged);
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
            this.panelleft.TabIndex = 82;
            this.panelleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleft_Paint);
            // 
            // lblBloodDonate
            // 
            this.lblBloodDonate.AutoSize = true;
            this.lblBloodDonate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodDonate.ForeColor = System.Drawing.Color.White;
            this.lblBloodDonate.Location = new System.Drawing.Point(34, 347);
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
            this.lblDashboard.Location = new System.Drawing.Point(34, 160);
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
            this.lblBloodTransfert.Location = new System.Drawing.Point(45, 643);
            this.lblBloodTransfert.Name = "lblBloodTransfert";
            this.lblBloodTransfert.Size = new System.Drawing.Size(163, 23);
            this.lblBloodTransfert.TabIndex = 8;
            this.lblBloodTransfert.Text = "Blood Transfert";
            // 
            // lblBloodStock
            // 
            this.lblBloodStock.AutoSize = true;
            this.lblBloodStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodStock.ForeColor = System.Drawing.Color.White;
            this.lblBloodStock.Location = new System.Drawing.Point(34, 571);
            this.lblBloodStock.Name = "lblBloodStock";
            this.lblBloodStock.Size = new System.Drawing.Size(126, 23);
            this.lblBloodStock.TabIndex = 8;
            this.lblBloodStock.Text = "Blood Stock";
            this.lblBloodStock.Click += new System.EventHandler(this.lblBloodStock_Click_1);
            // 
            // lblViewPatient
            // 
            this.lblViewPatient.AutoSize = true;
            this.lblViewPatient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPatient.ForeColor = System.Drawing.Color.White;
            this.lblViewPatient.Location = new System.Drawing.Point(34, 491);
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
            this.lblPatient.Location = new System.Drawing.Point(34, 420);
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
            this.lblViewDonor.Location = new System.Drawing.Point(34, 283);
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
            this.lblDonor.Location = new System.Drawing.Point(34, 220);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(70, 23);
            this.lblDonor.TabIndex = 4;
            this.lblDonor.Text = "Donor";
            this.lblDonor.Click += new System.EventHandler(this.lblDonor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(32, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 62);
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
            this.panelTop.TabIndex = 83;
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
            this.lblPatientList.Location = new System.Drawing.Point(642, 90);
            this.lblPatientList.Name = "lblPatientList";
            this.lblPatientList.Size = new System.Drawing.Size(487, 55);
            this.lblPatientList.TabIndex = 84;
            this.lblPatientList.Text = "Blood Transfer Form";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAvailable);
            this.panel2.Location = new System.Drawing.Point(468, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 433);
            this.panel2.TabIndex = 85;
            // 
            // BloodTransfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::blood_bank.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1548, 846);
            this.Controls.Add(this.lblPatientList);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.btnTransfert);
            this.Controls.Add(this.CbPatId);
            this.Controls.Add(this.lblDonorBloodGroup);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtBG);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodTransfert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Transfer Form";
            this.Load += new System.EventHandler(this.BloodTransfert_Load);
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
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.ComboBox CbPatId;
        private System.Windows.Forms.Label lblDonorBloodGroup;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Button btnTransfert;
        private System.Windows.Forms.TextBox txtBG;
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
        private System.Windows.Forms.Label lblPatientList;
        private System.Windows.Forms.Panel panel2;
    }
}