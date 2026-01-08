namespace FormFlow.UI
{
    partial class UC_AdminManageBookings
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBookings;
        private Guna.UI2.WinForms.Guna2Button btnApprove, btnAllotRoom, btnRefresh;
        private Guna.UI2.WinForms.Guna2TextBox txtFeeAmount;

        private void InitializeComponent()
        {
            this.dgvBookings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnApprove = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllotRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txtFeeAmount = new Guna.UI2.WinForms.Guna2TextBox();

            // Grid setup
            this.dgvBookings.Location = new System.Drawing.Point(30, 80);
            this.dgvBookings.Size = new System.Drawing.Size(980, 450);
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Fee Input
            this.txtFeeAmount.PlaceholderText = "Enter Fee Amount";
            this.txtFeeAmount.Location = new System.Drawing.Point(30, 550);
            this.txtFeeAmount.Size = new System.Drawing.Size(200, 40);

            // Approve Button
            this.btnApprove.Text = "APPROVE & ASSIGN FEE";
            this.btnApprove.Location = new System.Drawing.Point(250, 550);
            this.btnApprove.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);

            // Final Allotment Button
            this.btnAllotRoom.Text = "FINALIZE ALLOTMENT";
            this.btnAllotRoom.Location = new System.Drawing.Point(810, 550);
            this.btnAllotRoom.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAllotRoom.Click += new System.EventHandler(this.btnAllotRoom_Click);

            this.Controls.Add(dgvBookings); this.Controls.Add(txtFeeAmount);
            this.Controls.Add(btnApprove); this.Controls.Add(btnAllotRoom);
            this.Size = new System.Drawing.Size(1052, 728);
        }
    }
}