namespace FormFlow.UI
{
    partial class UC_ContactDirectory
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2DataGridView dgvContacts;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlTopHeader; // Container for the label

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvContacts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.pnlTopHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlTopHeader - This keeps the label at the top regardless of window size
            this.pnlTopHeader.Controls.Add(this.lblHeader);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(800, 60);

            // lblHeader - Anchored to Top-Left
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(125, 18, 100);
            this.lblHeader.Location = new System.Drawing.Point(15, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(280, 32);
            this.lblHeader.Text = "CONTACT DIRECTORY";

            // dgvContacts - Dock Fill makes it take all remaining space
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.BackgroundColor = System.Drawing.Color.White;
            this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContacts.ColumnHeadersHeight = 40;
            this.dgvContacts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvContacts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill; // IMPORTANT: This fixes the minimize/maximize issue
            this.dgvContacts.Location = new System.Drawing.Point(0, 60);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // UC_ContactDirectory Setup
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.pnlTopHeader); // Header stays on top
            this.Name = "UC_ContactDirectory";
            this.Size = new System.Drawing.Size(800, 500);
            this.BackColor = System.Drawing.Color.White;

            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}