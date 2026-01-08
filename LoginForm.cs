using System;
using System.Windows.Forms;
using FormFlow.BL.services;
using FormFlow.DL.Repositories;
using FormFlow.Model.Users;

namespace FormFlow.UI
{
    public partial class LoginForm : Form
    {
        private UserBL userBL;

        public LoginForm()
        {
            InitializeComponent();
            // Dependency Injection: BL is initialized with a concrete DL implementation
            userBL = new UserBL(new UserDL());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. UI Validation
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Authentication via Business Layer
                User user = userBL.SignIn(txtUsername.Text, txtPassword.Text);

                if (user != null)
                {
                    MessageBox.Show($"Login Successful! Welcome, {user.Name}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    Form dashboard;

                    // 3. Role-Based Redirection
                    // Using polymorphism: user.GetRole() returns the specific child class role
                    if (user is Admin)
                    {
                        dashboard = new AdminDashboard(user);
                    }
                    else if (user is Student)
                    {
                        dashboard = new StudentDashboard(user);
                    }
                    else
                    {
                        dashboard = new GuestDashboard(user);
                    }

                    dashboard.FormClosed += (s, args) => Application.Exit();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Critical Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm s1 = new SignUpForm();
            s1.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}