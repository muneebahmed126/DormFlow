using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_AdminManageRequests : UserControl
    {
        // Ensure RequestDL is created in your DL project
        private RequestDL _reqDL = new RequestDL();

        public UC_AdminManageRequests()
        {
            InitializeComponent();
        }

        private void UC_AdminManageRequests_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                // This method should update IsViewedByAdmin = 1 and return the table
                DataTable dt = _reqDL.GetAllRequestsForAdmin();
                dgvAdminRequests.DataSource = dt;

                // Formatting columns if needed
                if (dgvAdminRequests.Columns["RequestId"] != null)
                    dgvAdminRequests.Columns["RequestId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnMarkFulfilled_Click(object sender, EventArgs e)
        {
            if (dgvAdminRequests.SelectedRows.Count > 0)
            {
                int requestId = Convert.ToInt32(dgvAdminRequests.SelectedRows[0].Cells["RequestId"].Value);

                // Update IsFulfilled = 1 in DB
                _reqDL.UpdateFulfilledStatus(requestId, 1);

                MessageBox.Show("Request has been fulfilled!");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please select a request from the list first.");
            }
        }
    }
}