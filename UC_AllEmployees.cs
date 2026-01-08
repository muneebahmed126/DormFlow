using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_AllEmployees : UserControl
    {
        EmployeeDL empDL = new EmployeeDL();

        public UC_AllEmployees()
        {
            InitializeComponent();
        }

        // When the control loads, show 'Working' employees by default
        private void UC_AllEmployees_Load(object sender, EventArgs e)
        {
            comboFilter.SelectedIndex = 0; // Selects 'Working'
            LoadData("Working");
        }

        // When you change the Dropdown, the grid updates
        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(comboFilter.Text);
        }

        private void LoadData(string status)
        {
            DataTable dt = empDL.GetEmployeesByStatus(status);
            dgvEmployees.DataSource = dt;
        }
    }
}