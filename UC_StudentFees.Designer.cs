namespace FormFlow.UI
{
    partial class UC_StudentFees
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();

            // label1 (Title)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Text = "STUDENT FEES";

            // label2 (Search Label)
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Text = "Search by Mobile Number";

            // txtSearchContact
            this.txtSearchContact.Location = new System.Drawing.Point(40, 120);
            this.txtSearchContact.Size = new System.Drawing.Size(300, 36);
            this.txtSearchContact.Name = "txtSearchContact";

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(350, 120);
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(255, 128, 0); // Orange
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // txtFullName
            this.label3.Text = "Student Name";
            this.label3.Location = new System.Drawing.Point(40, 180);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(40, 210);
            this.txtFullName.Size = new System.Drawing.Size(430, 31);
            this.txtFullName.ReadOnly = true; // Prevents manual editing of name

            // txtRoomNo
            this.label4.Text = "Room Number";
            this.label4.Location = new System.Drawing.Point(40, 260);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.txtRoomNo.Location = new System.Drawing.Point(40, 290);
            this.txtRoomNo.Size = new System.Drawing.Size(430, 31);
            this.txtRoomNo.ReadOnly = true;

            // dtpMonth
            this.label5.Text = "Select Month";
            this.label5.Location = new System.Drawing.Point(40, 340);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.dtpMonth.Location = new System.Drawing.Point(40, 370);
            this.dtpMonth.Size = new System.Drawing.Size(430, 31);
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.CustomFormat = "MMMM yyyy";

            // txtAmount
            this.label6.Text = "Amount to Pay";
            this.label6.Location = new System.Drawing.Point(40, 420);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(40, 450);
            this.txtAmount.Size = new System.Drawing.Size(430, 31);

            // btnPay
            this.btnPay.Location = new System.Drawing.Point(40, 510);
            this.btnPay.Size = new System.Drawing.Size(430, 50);
            this.btnPay.Text = "REGISTER PAYMENT";
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(0, 192, 0); // Green
            this.btnPay.BorderRadius = 15;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);

            // UC_StudentFees Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(151, 48, 103); // Purple Theme
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_StudentFees";
            this.Size = new System.Drawing.Size(702, 601);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchContact;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2Button btnPay;

    }
}