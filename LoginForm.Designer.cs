namespace FormFlow.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtUsername = new TextBox();
            UserName = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.ImageAlign = ContentAlignment.TopLeft;
            lblTitle.Location = new Point(215, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DormFlow Login";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(279, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(181, 31);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(152, 156);
            UserName.Name = "UserName";
            UserName.Size = new Size(121, 30);
            UserName.TabIndex = 3;
            UserName.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(279, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(181, 31);
            txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(161, 226);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Algerian", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(255, 79, 0);
            btnLogin.Location = new Point(200, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(343, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "SIGN IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(152, 110);
            label2.Name = "label2";
            label2.Size = new Size(218, 29);
            label2.TabIndex = 7;
            label2.Text = "Welcome. Please Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(200, 401);
            label3.Name = "label3";
            label3.Size = new Size(128, 22);
            label3.TabIndex = 8;
            label3.Text = "Forget Password?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(334, 401);
            label4.Name = "label4";
            label4.Size = new Size(163, 22);
            label4.TabIndex = 9;
            label4.Text = "Dont Have an Account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(517, 401);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 22);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SignUp";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(862, 473);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(UserName);
            Controls.Add(txtUsername);
            Controls.Add(lblTitle);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtUsername;
        private Label UserName;
        private TextBox txtPassword;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}