namespace FormFlow.UI
{
    partial class UC_UpdateDeleteStudent
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            txtSearchMobile = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(580, 54);
            label1.TabIndex = 0;
            label1.Text = "UPDATE OR DELETE STUDENT";
            // 
            // txtSearchMobile
            // 
            txtSearchMobile.CustomizableEdges = customizableEdges1;
            txtSearchMobile.DefaultText = "";
            txtSearchMobile.Font = new Font("Segoe UI", 9F);
            txtSearchMobile.Location = new Point(30, 100);
            txtSearchMobile.Margin = new Padding(4, 5, 4, 5);
            txtSearchMobile.Name = "txtSearchMobile";
            txtSearchMobile.PlaceholderText = "Enter Mobile Number";
            txtSearchMobile.SelectedText = "";
            txtSearchMobile.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchMobile.Size = new Size(300, 45);
            txtSearchMobile.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.FillColor = Color.FromArgb(255, 128, 0);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(350, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(150, 45);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.CustomizableEdges = customizableEdges5;
            txtName.DefaultText = "";
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.Location = new Point(30, 180);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Student Name";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtName.Size = new Size(600, 45);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.CustomizableEdges = customizableEdges7;
            txtEmail.DefaultText = "";
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(30, 250);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email ID";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtEmail.Size = new Size(600, 45);
            txtEmail.TabIndex = 4;
            // 
            // txtRoomNo
            // 
            txtRoomNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRoomNo.CustomizableEdges = customizableEdges9;
            txtRoomNo.DefaultText = "";
            txtRoomNo.Font = new Font("Segoe UI", 9F);
            txtRoomNo.Location = new Point(30, 320);
            txtRoomNo.Margin = new Padding(4, 5, 4, 5);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.PlaceholderText = "Room Number";
            txtRoomNo.ReadOnly = true;
            txtRoomNo.SelectedText = "";
            txtRoomNo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtRoomNo.Size = new Size(600, 45);
            txtRoomNo.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.CustomizableEdges = customizableEdges11;
            btnDelete.FillColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(85, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDelete.Size = new Size(425, 55);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE STUDENT";
            btnDelete.Click += btnDelete_Click;
            // 
            // UC_UpdateDeleteStudent
            // 
            BackColor = Color.FromArgb(151, 48, 103);
            Controls.Add(label1);
            Controls.Add(txtSearchMobile);
            Controls.Add(btnSearch);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtRoomNo);
            Controls.Add(btnDelete);
            Name = "UC_UpdateDeleteStudent";
            Size = new Size(1052, 698);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMobile;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}