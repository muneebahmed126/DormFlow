using System;
using System.Data;
using System.Windows.Forms;

namespace FormFlow.UI
{
    public partial class UC_ContactDirectory : UserControl
    {
        public UC_ContactDirectory()
        {
            InitializeComponent();
            LoadContacts();
        }

        private void LoadContacts()
        {
            // Create a manual table for quick access
            DataTable dt = new DataTable();
            dt.Columns.Add("Service/Name", typeof(string));
            dt.Columns.Add("Contact Number", typeof(string));
            dt.Columns.Add("Type", typeof(string));

            // Adding your requested data
            dt.Rows.Add("Police Helpline", "15", "Emergency");
            dt.Rows.Add("Medical Emergency", "1122", "Health");
            dt.Rows.Add("Hostel Incharge (Muneeb)", "03328379597", "Hostel Management");

            dgvContacts.DataSource = dt;
        }
    }
}