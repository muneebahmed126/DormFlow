namespace FormFlow.UI
{
    partial class UC_PayFees
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchId;
        private Guna.UI2.WinForms.Guna2Button btnFetch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFeesDisplay;
        private Guna.UI2.WinForms.Guna2Button btnSubmitPayment;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlTopControls;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFetch = new Guna.UI2.WinForms.Guna2Button();
            this.dgvFeesDisplay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSubmitPayment = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlTopControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeesDisplay)).BeginInit();
            this.pnlTopControls.SuspendLayout();
            this.SuspendLayout();

            // pnlTopControls
            this.pnlTopControls.Controls.Add(this.lblHeaderTitle);
            this.pnlTopControls.Controls.Add(this.txtSearchId);
            this.pnlTopControls.Controls.Add(this.btnFetch);
            this.pnlTopControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopControls.Location = new System.Drawing.Point(0, 0);
            this.pnlTopControls.Name = "pnlTopControls";
            this.pnlTopControls.Size = new System.Drawing.Size(1052, 130);

            // lblHeaderTitle
            this.lblHeaderTitle.Text = "FEE PAYMENT & STATUS";
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(125, 18, 100);
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 15);
            this.lblHeaderTitle.Size = new System.Drawing.Size(400, 40);

            // txtSearchId
            this.txtSearchId.Location = new System.Drawing.Point(25, 75);
            this.txtSearchId.PlaceholderText = "Enter Contact No to find Booking Fee...";
            this.txtSearchId.Size = new System.Drawing.Size(300, 36);

            // btnFetch
            this.btnFetch.Location = new System.Drawing.Point(340, 75);
            this.btnFetch.Size = new System.Drawing.Size(130, 36);
            this.btnFetch.Text = "SEARCH";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);

            // dgvFeesDisplay
            this.dgvFeesDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeesDisplay.ColumnHeadersHeight = 40;
            this.dgvFeesDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeesDisplay.Location = new System.Drawing.Point(0, 130);
            this.dgvFeesDisplay.Name = "dgvFeesDisplay";
            this.dgvFeesDisplay.RowHeadersVisible = false;
            this.dgvFeesDisplay.Size = new System.Drawing.Size(1052, 538);
            this.dgvFeesDisplay.ThemeStyle.RowsStyle.Height = 35;
            this.dgvFeesDisplay.ReadOnly = true;

            // btnSubmitPayment
            this.btnSubmitPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmitPayment.Height = 60;
            this.btnSubmitPayment.FillColor = System.Drawing.Color.FromArgb(0, 182, 122);
            this.btnSubmitPayment.Text = "PAY SELECTED FEE";
            this.btnSubmitPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitPayment.Click += new System.EventHandler(this.btnSubmitPayment_Click);

            // Main User Control
            this.Controls.Add(this.dgvFeesDisplay);
            this.Controls.Add(this.btnSubmitPayment);
            this.Controls.Add(this.pnlTopControls);
            this.Size = new System.Drawing.Size(1052, 728);
            this.BackColor = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeesDisplay)).EndInit();
            this.pnlTopControls.ResumeLayout(false);
            this.pnlTopControls.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}