namespace FormFlow.UI
{
    partial class UC_StudentRequest
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TextBox txtRequestInput;
        private Guna.UI2.WinForms.Guna2Button btnSendRequest;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMyRequests;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHistory;

        private void InitializeComponent()
        {
            this.txtRequestInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSendRequest = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMyRequests = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "SUBMIT NEW REQUEST";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);

            // txtRequestInput (Multiline for typing details)
            this.txtRequestInput.Multiline = true;
            this.txtRequestInput.PlaceholderText = "Describe your request here (e.g., Maintenance, Room Issue)...";
            this.txtRequestInput.Location = new System.Drawing.Point(30, 60);
            this.txtRequestInput.Size = new System.Drawing.Size(800, 100);

            // btnSendRequest
            this.btnSendRequest.Text = "SEND TO ADMIN";
            this.btnSendRequest.FillColor = System.Drawing.Color.FromArgb(64, 0, 64);
            this.btnSendRequest.Location = new System.Drawing.Point(30, 170);
            this.btnSendRequest.Size = new System.Drawing.Size(200, 45);
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);

            // lblHistory
            this.lblHistory.Text = "YOUR REQUEST HISTORY & STATUS";
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHistory.Location = new System.Drawing.Point(30, 240);

            // dgvMyRequests
            this.dgvMyRequests.Location = new System.Drawing.Point(30, 270);
            this.dgvMyRequests.Size = new System.Drawing.Size(980, 400);
            this.dgvMyRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyRequests.ReadOnly = true;

            // UserControl
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtRequestInput);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dgvMyRequests);
            this.Size = new System.Drawing.Size(1052, 728);
            this.Load += new System.EventHandler(this.UC_StudentRequest_Load);
            this.ResumeLayout(false);
        }
    }
}