namespace FormFlow.UI
{
    partial class UC_NewEmployee
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();

            // label1 (Header)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 45);
            this.label1.Text = "NEW EMPLOYEE";

            // Student Name / Full Name
            this.label2.Text = "Full Name";
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.txtFullName.Location = new System.Drawing.Point(40, 120);
            this.txtFullName.Size = new System.Drawing.Size(450, 31);
            this.txtFullName.Name = "txtFullName";

            // Mobile
            this.label3.Text = "Mobile Number";
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 170);
            this.txtMobile.Location = new System.Drawing.Point(40, 200);
            this.txtMobile.Size = new System.Drawing.Size(450, 31);
            this.txtMobile.Name = "txtMobile";

            // Email
            this.label4.Text = "Email ID";
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 250);
            this.txtEmail.Location = new System.Drawing.Point(40, 280);
            this.txtEmail.Size = new System.Drawing.Size(450, 31);
            this.txtEmail.Name = "txtEmail";

            // CNIC
            this.label5.Text = "CNIC (ID Card)";
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 330);
            this.txtCNIC.Location = new System.Drawing.Point(40, 360);
            this.txtCNIC.Size = new System.Drawing.Size(450, 31);
            this.txtCNIC.Name = "txtCNIC";

            // Designation
            this.label6.Text = "Designation (e.g. Warden, Security, Cleaner)";
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 410);
            this.txtDesignation.Location = new System.Drawing.Point(40, 440);
            this.txtDesignation.Size = new System.Drawing.Size(450, 31);
            this.txtDesignation.Name = "txtDesignation";

            // btnSave (Register Button)
            this.btnSave.BorderRadius = 15;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(0, 192, 0); // Green
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(40, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(450, 55);
            this.btnSave.Text = "SAVE EMPLOYEE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // UC_NewEmployee
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(151, 48, 103); // Purple theme
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_NewEmployee";
            this.Size = new System.Drawing.Size(702, 601);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesignation;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}