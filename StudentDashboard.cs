using FormFlow.Model.Users; // This is the key!
using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.BL;

namespace FormFlow.UI
{
    public partial class StudentDashboard : Form
    {
        private User _student;

        // The constructor now accepts the logged-in student
        public StudentDashboard(User user)
        {
            InitializeComponent();
            _student = user;
            this.Text = "Student Portal - " + _student.Name;
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void ShowScreen(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill; // Force it to take the full space of pnlMain
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront(); // Ensures it stays above pnlMain's background
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_ViewAllRooms roomsForm = new UC_ViewAllRooms();
            addUserControl(roomsForm);


        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_PayFees feesForm = new UC_PayFees();

            // 2. Use your existing helper method to display it in pnlMain
            addUserControl(feesForm);
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            UC_ContactDirectory contactForm = new UC_ContactDirectory();
            addUserControl(contactForm); // Using 
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_StudentRequest uc = new UC_StudentRequest();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_HostelBooking uc = new UC_HostelBooking();
            addUserControl(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
