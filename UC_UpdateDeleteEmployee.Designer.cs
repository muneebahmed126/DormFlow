namespace FormFlow.UI
{
    partial class UC_UpdateDeleteEmployee
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchCNIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();

            // Header
            this.label1.Text = "UPDATE / DELETE EMPLOYEE";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Size = new System.Drawing.Size(500, 45);

            // Search Section
            this.label2.Text = "Enter CNIC to Search";
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.txtSearchCNIC.Location = new System.Drawing.Point(40, 120);
            this.txtSearchCNIC.Size = new System.Drawing.Size(300, 36);

            this.btnSearch.Text = "SEARCH";
            this.btnSearch.Location = new System.Drawing.Point(350, 120);
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // Full Name
            this.label3.Text = "Full Name";
            this.label3.Location = new System.Drawing.Point(40, 180);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(40, 210);
            this.txtFullName.Size = new System.Drawing.Size(430, 31);

            // Mobile
            this.label4.Text = "Mobile Number";
            this.label4.Location = new System.Drawing.Point(40, 260);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.txtMobile.Location = new System.Drawing.Point(40, 290);
            this.txtMobile.Size = new System.Drawing.Size(430, 31);

            // Email
            this.label5.Text = "Email ID";
            this.label5.Location = new System.Drawing.Point(40, 340);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(40, 370);
            this.txtEmail.Size = new System.Drawing.Size(430, 31);

            // Designation
            this.label6.Text = "Designation";
            this.label6.Location = new System.Drawing.Point(40, 420);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.txtDesignation.Location = new System.Drawing.Point(40, 450);
            this.txtDesignation.Size = new System.Drawing.Size(430, 31);

            // Status Dropdown
            this.label7.Text = "Working Status";
            this.label7.Location = new System.Drawing.Point(40, 500);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.comboStatus.Items.AddRange(new object[] { "Working", "Resigned" });
            this.comboStatus.Location = new System.Drawing.Point(40, 530);
            this.comboStatus.Size = new System.Drawing.Size(430, 36);

            // Update Button
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Location = new System.Drawing.Point(500, 210);
            this.btnUpdate.Size = new System.Drawing.Size(150, 45);
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // Delete (Resign) Button
            this.btnDelete.Text = "MARK RESIGNED";
            this.btnDelete.Location = new System.Drawing.Point(500, 290);
            this.btnDelete.Size = new System.Drawing.Size(150, 45);
            this.btnDelete.FillColor = System.Drawing.Color.Crimson;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Final Setup
            this.BackColor = System.Drawing.Color.FromArgb(151, 48, 103);
            this.Controls.Add(btnDelete); this.Controls.Add(btnUpdate);
            this.Controls.Add(comboStatus); this.Controls.Add(label7);
            this.Controls.Add(txtDesignation); this.Controls.Add(label6);
            this.Controls.Add(txtEmail); this.Controls.Add(label5);
            this.Controls.Add(txtMobile); this.Controls.Add(label4);
            this.Controls.Add(txtFullName); this.Controls.Add(label3);
            this.Controls.Add(btnSearch); this.Controls.Add(txtSearchCNIC);
            this.Controls.Add(label2); this.Controls.Add(label1);
            this.Size = new System.Drawing.Size(702, 601);
            this.Name = "UC_UpdateDeleteEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCNIC;
        private Guna.UI2.WinForms.Guna2Button btnSearch, btnUpdate, btnDelete;
        private System.Windows.Forms.TextBox txtFullName, txtMobile, txtEmail, txtDesignation;
        private Guna.UI2.WinForms.Guna2ComboBox comboStatus;
    }
}