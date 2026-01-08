namespace FormFlow.UI
{
    partial class UC_HostelBooking
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TextBox txtName, txtCNIC, txtContact, txtRoomNo;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStatus;
        private System.Windows.Forms.Label lblHeader;

        private void InitializeComponent()
        {
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCNIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.dgvStatus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Styling Helpers
            void SetStyle(Guna.UI2.WinForms.Guna2TextBox t, string hint, int y)
            {
                t.PlaceholderText = hint;
                t.Location = new System.Drawing.Point(50, y);
                t.Size = new System.Drawing.Size(300, 40);
            }

            SetStyle(txtName, "Full Name", 80);
            SetStyle(txtCNIC, "CNIC Number", 130);
            SetStyle(txtContact, "Contact Number", 180);
            SetStyle(txtRoomNo, "Preferred Room No", 230);

            this.btnSubmit.Text = "REQUEST BOOKING";
            this.btnSubmit.Location = new System.Drawing.Point(50, 290);
            this.btnSubmit.Size = new System.Drawing.Size(300, 45);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.dgvStatus.Location = new System.Drawing.Point(400, 80);
            this.dgvStatus.Size = new System.Drawing.Size(600, 255);
            this.dgvStatus.ThemeStyle.RowsStyle.Height = 30;

            this.lblHeader.Text = "HOSTEL ROOM BOOKING";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(45, 20);

            this.Controls.Add(txtName); this.Controls.Add(txtCNIC);
            this.Controls.Add(txtContact); this.Controls.Add(txtRoomNo);
            this.Controls.Add(btnSubmit); this.Controls.Add(dgvStatus);
            this.Controls.Add(lblHeader);
            this.Size = new System.Drawing.Size(1052, 728);
            this.ResumeLayout(false);
        }
    }
}