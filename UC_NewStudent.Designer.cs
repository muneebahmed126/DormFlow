namespace FormFlow.UI
{
    partial class UC_NewStudent
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            txtContact = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            comboRoomNo = new ComboBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnExit = new Button();
            label6 = new Label();
            txtCNIC = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 20);
            label1.Name = "label1";
            label1.Size = new Size(540, 48);
            label1.TabIndex = 0;
            label1.Text = "NEW STUDENT REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 90);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 11;
            label2.Text = "Student Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(40, 120);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 31);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 170);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 10;
            label3.Text = "Mobile Number";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(40, 200);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(350, 31);
            txtContact.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 250);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 9;
            label4.Text = "Email ID";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 280);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 31);
            txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 410);
            label5.Name = "label5";
            label5.Size = new Size(246, 25);
            label5.TabIndex = 8;
            label5.Text = "Assign Room (Available Only)";
            // 
            // comboRoomNo
            // 
            comboRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRoomNo.FormattingEnabled = true;
            comboRoomNo.Location = new Point(40, 440);
            comboRoomNo.Name = "comboRoomNo";
            comboRoomNo.Size = new Size(350, 33);
            comboRoomNo.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 15;
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(0, 192, 0);
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(40, 506);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(350, 55);
            btnSave.TabIndex = 6;
            btnSave.Text = "REGISTER STUDENT";
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Brown;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(650, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 7;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 330);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 5;
            label6.Text = "ID Proof";
            // 
            // txtCNIC
            // 
            txtCNIC.Location = new Point(40, 360);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(350, 31);
            txtCNIC.TabIndex = 4;
            // 
            // UC_NewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(151, 48, 103);
            Controls.Add(txtCNIC);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(comboRoomNo);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtContact);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_NewStudent";
            Size = new Size(702, 601);
            Load += UC_NewStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFullName;
        private Label label3;
        private TextBox txtContact;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private ComboBox comboRoomNo;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Button btnExit;
        private Label label6;
        private TextBox txtCNIC;
    }
}