namespace FormFlow.UI
{
    partial class UC_AdminManageRequests
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAdminRequests;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnMarkFulfilled;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAdminRequests = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnMarkFulfilled = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRequests)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Text = "Student Hostel Requests";

            // dgvAdminRequests
            this.dgvAdminRequests.AllowUserToAddRows = false;
            this.dgvAdminRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminRequests.ColumnHeadersHeight = 40;
            this.dgvAdminRequests.Location = new System.Drawing.Point(30, 80);
            this.dgvAdminRequests.Size = new System.Drawing.Size(980, 520);
            this.dgvAdminRequests.ThemeStyle.RowsStyle.Height = 35;
            this.dgvAdminRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // btnRefresh
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.Location = new System.Drawing.Point(700, 620);
            this.btnRefresh.Size = new System.Drawing.Size(140, 45);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // btnMarkFulfilled
            this.btnMarkFulfilled.Text = "Mark as Fulfilled";
            this.btnMarkFulfilled.FillColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.btnMarkFulfilled.Location = new System.Drawing.Point(860, 620);
            this.btnMarkFulfilled.Size = new System.Drawing.Size(150, 45);
            this.btnMarkFulfilled.Click += new System.EventHandler(this.btnMarkFulfilled_Click);

            // UC_AdminManageRequests
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAdminRequests);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMarkFulfilled);
            this.Name = "UC_AdminManageRequests";
            this.Size = new System.Drawing.Size(1052, 728); // Matches your pnlMain size
            this.Load += new System.EventHandler(this.UC_AdminManageRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}