namespace FormFlow.UI
{
    partial class SignUpForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblSignUpTitle = new Label();
            lblHeaderName = new Label();
            lblHeaderCNIC = new Label();
            lblHeaderUser = new Label();
            lblHeaderPass = new Label();
            lblRoleTag = new Label();
            txtName = new TextBox();
            txtCNIC = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            SuspendLayout();
            // 
            // lblSignUpTitle
            // 
            lblSignUpTitle.AutoSize = true;
            lblSignUpTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSignUpTitle.Location = new Point(280, 20);
            lblSignUpTitle.Name = "lblSignUpTitle";
            lblSignUpTitle.Size = new Size(240, 48);
            lblSignUpTitle.TabIndex = 0;
            lblSignUpTitle.Text = "SignUp Form";
            // 
            // lblHeaderName
            // 
            lblHeaderName.AutoSize = true;
            lblHeaderName.Location = new Point(180, 100);
            lblHeaderName.Name = "lblHeaderName";
            lblHeaderName.Size = new Size(63, 25);
            lblHeaderName.TabIndex = 1;
            lblHeaderName.Text = "Name:";
            // 
            // lblHeaderCNIC
            // 
            lblHeaderCNIC.AutoSize = true;
            lblHeaderCNIC.Location = new Point(180, 150);
            lblHeaderCNIC.Name = "lblHeaderCNIC";
            lblHeaderCNIC.Size = new Size(56, 25);
            lblHeaderCNIC.TabIndex = 3;
            lblHeaderCNIC.Text = "CNIC:";
            // 
            // lblHeaderUser
            // 
            lblHeaderUser.AutoSize = true;
            lblHeaderUser.Location = new Point(180, 200);
            lblHeaderUser.Name = "lblHeaderUser";
            lblHeaderUser.Size = new Size(95, 25);
            lblHeaderUser.TabIndex = 5;
            lblHeaderUser.Text = "Username:";
            // 
            // lblHeaderPass
            // 
            lblHeaderPass.AutoSize = true;
            lblHeaderPass.Location = new Point(180, 250);
            lblHeaderPass.Name = "lblHeaderPass";
            lblHeaderPass.Size = new Size(91, 25);
            lblHeaderPass.TabIndex = 7;
            lblHeaderPass.Text = "Password:";
            // 
            // lblRoleTag
            // 
            lblRoleTag.AutoSize = true;
            lblRoleTag.Location = new Point(180, 300);
            lblRoleTag.Name = "lblRoleTag";
            lblRoleTag.Size = new Size(50, 25);
            lblRoleTag.TabIndex = 9;
            lblRoleTag.Text = "Role:";
            // 
            // txtName
            // 
            txtName.Location = new Point(300, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 31);
            txtName.TabIndex = 2;
            // 
            // txtCNIC
            // 
            txtCNIC.Location = new Point(300, 147);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(200, 31);
            txtCNIC.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(300, 197);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(300, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 8;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Location = new Point(300, 297);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 33);
            cmbRole.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSteelBlue;
            btnRegister.Location = new Point(220, 370);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 45);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(370, 370);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(130, 45);
            btnBackToLogin.TabIndex = 12;
            btnBackToLogin.Text = "Back";
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(750, 480);
            Controls.Add(lblSignUpTitle);
            Controls.Add(lblHeaderName);
            Controls.Add(txtName);
            Controls.Add(lblHeaderCNIC);
            Controls.Add(txtCNIC);
            Controls.Add(lblHeaderUser);
            Controls.Add(txtUsername);
            Controls.Add(lblHeaderPass);
            Controls.Add(txtPassword);
            Controls.Add(lblRoleTag);
            Controls.Add(cmbRole);
            Controls.Add(btnRegister);
            Controls.Add(btnBackToLogin);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFlow - Create Account";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignUpTitle;
        private Label lblHeaderName;
        private Label lblHeaderCNIC;
        private Label lblHeaderUser;
        private Label lblHeaderPass;
        private Label lblRoleTag;
        private TextBox txtName;
        private TextBox txtCNIC;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private Button btnRegister;
        private Button btnBackToLogin;
    }
}