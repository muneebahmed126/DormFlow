using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_UpdateDeleteEmployee : UserControl
    {
        EmployeeDL empDL = new EmployeeDL();

        public UC_UpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = empDL.GetEmployeeByCNIC(txtSearchCNIC.Text);
            if (dt.Rows.Count > 0)
            {
                txtFullName.Text = dt.Rows[0]["FullName"].ToString();
                txtMobile.Text = dt.Rows[0]["MobileNo"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtDesignation.Text = dt.Rows[0]["Designation"].ToString();
                comboStatus.Text = dt.Rows[0]["Status"].ToString();
            }
            else
            {
                MessageBox.Show("Employee not found.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            empDL.UpdateEmployee(txtSearchCNIC.Text, txtFullName.Text, txtMobile.Text, txtEmail.Text, txtDesignation.Text, comboStatus.Text);
            MessageBox.Show("Employee Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mark this employee as Resigned?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                empDL.UpdateEmployee(txtSearchCNIC.Text, txtFullName.Text, txtMobile.Text, txtEmail.Text, txtDesignation.Text, "Resigned");
                MessageBox.Show("Status updated to Resigned.");
                ClearAll();
            }
        }

        private void ClearAll()
        {
            txtSearchCNIC.Clear();
            txtFullName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtDesignation.Clear();
            comboStatus.SelectedIndex = -1;
        }
    }
}