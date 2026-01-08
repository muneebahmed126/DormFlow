using FormFlow.Model.Users;
using FormFlow.BL.services;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class SignUpForm : Form
    {
        private UserBL _userBL = new UserBL(new UserDL());

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            if (cmbRole.Items.Count == 0)
            {
                cmbRole.Items.Add("Admin");
                cmbRole.Items.Add("Student");
                cmbRole.Items.Add("Guest");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser;
                string role = cmbRole.SelectedItem?.ToString() ?? "Guest";

                if (role == "Admin") newUser = new Admin();
                else if (role == "Student") newUser = new Student();
                else newUser = new Guest();

                newUser.Name = txtName.Text;
                newUser.CNIC = txtCNIC.Text;

                _userBL.SignUp(newUser, txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Registered successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}