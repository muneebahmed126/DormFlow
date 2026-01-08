namespace FormFlow.UI
{
    partial class UC_ViewAllRooms
    {
        private System.ComponentModel.IContainer components = null;
        public Guna.UI2.WinForms.Guna2DataGridView dgvRooms;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlHeaderContainer; // Keeps header at the top

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlHeaderContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.pnlHeaderContainer.SuspendLayout();
            this.SuspendLayout();

            // pnlHeaderContainer
            this.pnlHeaderContainer.Controls.Add(this.lblHeader);
            this.pnlHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderContainer.Name = "pnlHeaderContainer";
            this.pnlHeaderContainer.Size = new System.Drawing.Size(800, 60);

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(125, 18, 100);
            this.lblHeader.Location = new System.Drawing.Point(15, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(225, 32);
            this.lblHeader.Text = "AVAILABLE ROOMS";

            // dgvRooms - The Dynamic Grid
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.ColumnHeadersHeight = 40;
            // Match your previous blue/purple style
            this.dgvRooms.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvRooms.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            // DOCK FILL: This is the key to seeing data in a minimized form
            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRooms.Location = new System.Drawing.Point(0, 60);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // UserControl Setup
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.pnlHeaderContainer);
            this.Name = "UC_ViewAllRooms";
            this.Size = new System.Drawing.Size(800, 500);
            this.BackColor = System.Drawing.Color.White;

            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.pnlHeaderContainer.ResumeLayout(false);
            this.pnlHeaderContainer.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}