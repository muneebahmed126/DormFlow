using Microsoft.VisualBasic.Logging;
using System;
using System.Windows.Forms;

namespace FormFlow.UI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(object user)
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Optional: Start with no control visible, just background
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear(); // Removes the background picture
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Visible = true; // Force visibility
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            // 1. Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Login form instance 
                // Note: Change 'Login' to the exact name of your Login Form class
                LoginForm loginForm1 = new LoginForm();

                // 3. Show the login form
                loginForm1.Show();

                // 4. Hide and Close the current dashboard
                // We use Hide first for a smoother visual transition
                this.Hide();
                
            }
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            UC_StudentFees uc = new UC_StudentFees();
            addUserControl(uc); // Assuming you have a method to swap controls in the main panel
        }
        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            UC_AllStudents uc = new UC_AllStudents();
            addUserControl(uc);
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            UC_ManageRooms uc = new UC_ManageRooms();
            addUserControl(uc);
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            UC_NewStudent uc = new UC_NewStudent();
            addUserControl(uc);
        }

       
        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UC_UpdateDeleteStudent uc = new UC_UpdateDeleteStudent();
            addUserControl(uc);
        }


        private void btnNewEmployee_Click(object sender, EventArgs e)
        {

          
            UC_NewEmployee uc = new UC_NewEmployee();
            addUserControl(uc); // Your method that clears panelMain and adds the new control
        }


        private void btnViewRequests_Click(object sender, EventArgs e)
        {
            UC_AdminManageRequests uc = new UC_AdminManageRequests();
            addUserControl(uc);
        }
        private void btnAllEmployees_Click(object sender, EventArgs e)
        {
            // This creates the User Control we are about to build
            UC_AllEmployees uc = new UC_AllEmployees();
            addUserControl(uc);
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            // This loads the User Control for approving room requests
            UC_AdminManageBookings uc = new UC_AdminManageBookings();
            addUserControl(uc);
        }

        private void btnUpdateDeleteEmployee_Click(object sender, EventArgs e)
        {
            UC_UpdateDeleteEmployee uc = new UC_UpdateDeleteEmployee();
            addUserControl(uc);
        }
    }
}