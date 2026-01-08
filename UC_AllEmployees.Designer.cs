namespace FormFlow.UI
{
    partial class UC_AllEmployees
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();

            // label1 (Header)
            this.label1.Text = "EMPLOYEE RECORDS";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Size = new System.Drawing.Size(400, 45);

            // comboFilter (Dropdown)
            this.comboFilter.Items.AddRange(new object[] { "Working", "Resigned" });
            this.comboFilter.Location = new System.Drawing.Point(400, 25);
            this.comboFilter.Size = new System.Drawing.Size(250, 36);
            this.comboFilter.BorderRadius = 10;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.comboFilter_SelectedIndexChanged);

            // dgvEmployees (The Modern Table)
            this.dgvEmployees.Location = new System.Drawing.Point(30, 90);
            this.dgvEmployees.Size = new System.Drawing.Size(950, 580);
            this.dgvEmployees.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(151, 48, 103);
            this.dgvEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(64, 0, 64);

            // Control Setup
            this.BackColor = System.Drawing.Color.FromArgb(151, 48, 103);
            this.Controls.Add(label1);
            this.Controls.Add(comboFilter);
            this.Controls.Add(dgvEmployees);
            this.Size = new System.Drawing.Size(1052, 728);
            this.Load += new System.EventHandler(this.UC_AllEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployees;
        private Guna.UI2.WinForms.Guna2ComboBox comboFilter;
        private System.Windows.Forms.Label label1;
    }
}