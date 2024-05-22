namespace blood_bank
{
    partial class DonorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorView));
            this.dgvDonorList = new System.Windows.Forms.DataGridView();
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorList)).BeginInit();
            this.panelleft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonorList
            // 
            this.dgvDonorList.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgvDonorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonorList.GridColor = System.Drawing.Color.Black;
            this.dgvDonorList.Location = new System.Drawing.Point(364, 193);
            this.dgvDonorList.Name = "dgvDonorList";
            this.dgvDonorList.RowHeadersWidth = 51;
            this.dgvDonorList.RowTemplate.Height = 24;
            this.dgvDonorList.Size = new System.Drawing.Size(1050, 551);
            this.dgvDonorList.TabIndex = 15;
            this.dgvDonorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonorList_CellContentClick);
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
            this.panelleft.TabIndex = 79;
            // 
            // lblBloodDonate
            // 
            this.lblBloodDonate.AutoSize = true;
            this.lblBloodDonate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodDonate.ForeColor = System.Drawing.Color.White;
            this.lblBloodDonate.Location = new System.Drawing.Point(34, 385);
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
            this.lblDashboard.Location = new System.Drawing.Point(34, 178);
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
            this.lblBloodTransfert.Location = new System.Drawing.Point(34, 681);
            this.lblBloodTransfert.Name = "lblBloodTransfert";
            this.lblBloodTransfert.Size = new System.Drawing.Size(163, 23);
            this.lblBloodTransfert.TabIndex = 8;
            this.lblBloodTransfert.Text = "Blood Transfert";
            this.lblBloodTransfert.Click += new System.EventHandler(this.lblBloodTransfert_Click_1);
            // 
            // lblBloodStock
            // 
            this.lblBloodStock.AutoSize = true;
            this.lblBloodStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodStock.ForeColor = System.Drawing.Color.White;
            this.lblBloodStock.Location = new System.Drawing.Point(34, 609);
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
            this.lblViewPatient.Location = new System.Drawing.Point(34, 529);
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
            this.lblPatient.Location = new System.Drawing.Point(34, 458);
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
            this.lblViewDonor.Location = new System.Drawing.Point(56, 313);
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
            this.lblDonor.Location = new System.Drawing.Point(34, 240);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(70, 23);
            this.lblDonor.TabIndex = 4;
            this.lblDonor.Text = "Donor";
            this.lblDonor.Click += new System.EventHandler(this.lblDonor_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(38, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 62);
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
            this.lblPatientList.Location = new System.Drawing.Point(676, 104);
            this.lblPatientList.Name = "lblPatientList";
            this.lblPatientList.Size = new System.Drawing.Size(351, 55);
            this.lblPatientList.TabIndex = 47;
            this.lblPatientList.Text = "All Donor View";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Blue;
            this.btnPrint.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(809, 749);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(165, 60);
            this.btnPrint.TabIndex = 101;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // DonorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::blood_bank.Properties.Resources.all_page_background_image;
            this.ClientSize = new System.Drawing.Size(1548, 846);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblPatientList);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.dgvDonorList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonorView";
            this.Load += new System.EventHandler(this.DonorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorList)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDonorList;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}