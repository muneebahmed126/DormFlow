using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_StudentRequest : UserControl
    {


        RequestDL _reqDL = new RequestDL();
        int studentId = 1; // This should be the ID of the logged-in student

        public UC_StudentRequest()
        {
            InitializeComponent();
        }

        private void UC_StudentRequest_Load(object sender, EventArgs e)
        {
            LoadRequestHistory();
        }

        private void LoadRequestHistory()
        {
            // Fetch requests just for this student
            DataTable dt = _reqDL.GetRequestsByStudentId(studentId);
            dgvMyRequests.DataSource = dt;
            FormatGrid();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            // 1. Validation: Ensure the box isn't empty
            if (string.IsNullOrWhiteSpace(txtRequestInput.Text))
            {
                MessageBox.Show("Please describe your request before sending.");
                return;
            }

            try
            {
                // 2. Ensure studentId is valid (You should set this during Login)
                if (studentId <= 0)
                {
                    MessageBox.Show("Error: Student session not found. Please log in again.");
                    return;
                }

                // 3. Call the DL to save the request
                _reqDL.AddRequest(studentId, txtRequestInput.Text);

                MessageBox.Show("Request sent successfully!", "Success");
                txtRequestInput.Clear();
                LoadRequestHistory(); // Refresh the grid to show the new request
            }
            catch (Exception ex)
            {
                // This will tell you if there is a SQL error (like a missing column)
                MessageBox.Show("Technical Error: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            foreach (DataGridViewRow row in dgvMyRequests.Rows)
            {
                bool isViewed = Convert.ToBoolean(row.Cells["IsViewedByAdmin"].Value);
                bool isFulfilled = Convert.ToBoolean(row.Cells["IsFulfilled"].Value);

                if (isFulfilled)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (isViewed)
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }
            }
        }
    }
}