namespace blood_bank
{
    partial class DonateBlood
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
            this.dgvDonorList = new System.Windows.Forms.DataGridView();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBGroup = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvBStock = new System.Windows.Forms.DataGridView();
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBStock)).BeginInit();
            this.panelleft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonorList
            // 
            this.dgvDonorList.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvDonorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonorList.GridColor = System.Drawing.Color.Black;
            this.dgvDonorList.Location = new System.Drawing.Point(639, 145);
            this.dgvDonorList.Name = "dgvDonorList";
            this.dgvDonorList.RowHeadersWidth = 51;
            this.dgvDonorList.RowTemplate.Height = 24;
            this.dgvDonorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonorList.Size = new System.Drawing.Size(870, 488);
            this.dgvDonorList.TabIndex = 16;
            this.dgvDonorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonorList_CellContentClick);
            // 
            // txtDName
            // 
            this.txtDName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDName.Location = new System.Drawing.Point(476, 680);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(357, 31);
            this.txtDName.TabIndex = 74;
            this.txtDName.TextChanged += new System.EventHandler(this.txtDPhone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(990, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 73;
            this.label1.Text = "Blood Group";
            // 
            // txtBGroup
            // 
            this.txtBGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBGroup.Location = new System.Drawing.Point(1162, 676);
            this.txtBGroup.Name = "txtBGroup";
            this.txtBGroup.Size = new System.Drawing.Size(347, 31);
            this.txtBGroup.TabIndex = 74;
            this.txtBGroup.TextChanged += new System.EventHandler(this.txtBGroup_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(337, 680);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 27);
            this.lblName.TabIndex = 75;
            this.lblName.Text = "Full Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(797, 774);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 60);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Donate";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBStock
            // 
            this.dgvBStock.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvBStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBStock.GridColor = System.Drawing.Color.Black;
            this.dgvBStock.Location = new System.Drawing.Point(293, 145);
            this.dgvBStock.Name = "dgvBStock";
            this.dgvBStock.RowHeadersWidth = 51;
            this.dgvBStock.RowTemplate.Height = 24;
            this.dgvBStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBStock.Size = new System.Drawing.Size(308, 368);
            this.dgvBStock.TabIndex = 16;
            this.dgvBStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonorList_CellContentClick);
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
            this.panelleft.TabIndex = 77;
            // 
            // lblBloodDonate
            // 
            this.lblBloodDonate.AutoSize = true;
            this.lblBloodDonate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodDonate.ForeColor = System.Drawing.Color.White;
            this.lblBloodDonate.Location = new System.Drawing.Point(40, 370);
            this.lblBloodDonate.Name = "lblBloodDonate";
            this.lblBloodDonate.Size = new System.Drawing.Size(141, 23);
            this.lblBloodDonate.TabIndex = 9;
            this.lblBloodDonate.Text = "Donate Blood";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(23, 157);
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
            this.lblBloodTransfert.Location = new System.Drawing.Point(23, 658);
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
            this.lblBloodStock.Location = new System.Drawing.Point(23, 586);
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
            this.lblViewPatient.Location = new System.Drawing.Point(23, 516);
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
            this.lblPatient.Location = new System.Drawing.Point(23, 449);
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
            this.lblViewDonor.Location = new System.Drawing.Point(23, 302);
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
            this.lblDonor.Location = new System.Drawing.Point(23, 228);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(70, 23);
            this.lblDonor.TabIndex = 4;
            this.lblDonor.Text = "Donor";
            this.lblDonor.Click += new System.EventHandler(this.lblDonor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(27, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 52);
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
            this.panelTop.TabIndex = 78;
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
            this.lblPatientList.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientList.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPatientList.Location = new System.Drawing.Point(334, 516);
            this.lblPatientList.Name = "lblPatientList";
            this.lblPatientList.Size = new System.Drawing.Size(218, 42);
            this.lblPatientList.TabIndex = 79;
            this.lblPatientList.Text = "Blood Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(897, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 42);
            this.label2.TabIndex = 79;
            this.label2.Text = "Donation Details";
            // 
            // DonateBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::blood_bank.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1548, 846);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPatientList);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBGroup);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBStock);
            this.Controls.Add(this.dgvDonorList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonateBlood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donate Blood";
            this.Load += new System.EventHandler(this.DonateBlood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBStock)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonorList;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvBStock;
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
        private System.Windows.Forms.Label label2;
    }
}