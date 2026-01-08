using System;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_NewEmployee : UserControl
    {
        EmployeeDL empDL = new EmployeeDL();

        public UC_NewEmployee()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text != "" && txtCNIC.Text != "")
                {
                    empDL.RegisterEmployee(
                        txtFullName.Text,
                        txtCNIC.Text,
                        txtMobile.Text,
                        txtEmail.Text,
                        txtDesignation.Text
                    );

                    MessageBox.Show("Employee Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please fill Name and CNIC fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtCNIC.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtDesignation.Clear();
        }
    }
}