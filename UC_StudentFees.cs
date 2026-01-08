using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_StudentFees : UserControl
    {
        FeesDL feesDL = new FeesDL();
        int currentStudentId = -1;

        public UC_StudentFees()
        {
            InitializeComponent();
        }

        // Search for student by mobile number
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 1. Validation to prevent empty search errors
            if (string.IsNullOrWhiteSpace(txtSearchContact.Text))
            {
                MessageBox.Show("Please enter a contact number.");
                return;
            }

            try
            {
                // 2. Call your existing function
                DataTable dt = feesDL.GetStudentForFee(txtSearchContact.Text);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // 3. Exact column mapping based on your query
                    txtFullName.Text = dt.Rows[0]["FullName"].ToString();
                    txtRoomNo.Text = dt.Rows[0]["RoomNo"].ToString();

                    // Store the ID for the 'Pay' button logic
                    currentStudentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
                }
                else
                {
                    MessageBox.Show("No active student found with this contact number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                // This will catch SQL errors like "Invalid Column Name"
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Admin registers a fee requirement (Student will pay this later)
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (currentStudentId == -1)
            {
                MessageBox.Show("Please search and select a student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter the fee amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string month = dtpMonth.Value.ToString("MMMM yyyy");

                // Validate if amount is a valid number
                if (int.TryParse(txtAmount.Text, out int amount))
                {
                    // Call DL to add record to 'Fees' table with PaymentDate as NULL
                    feesDL.AddFeeBill(currentStudentId, month, amount);

                    MessageBox.Show($"Fee bill of {amount} for {month} issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric amount.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error issuing fee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAll()
        {
            txtFullName.Clear();
            txtRoomNo.Clear();
            txtAmount.Clear();
            txtSearchContact.Clear();
            currentStudentId = -1;
        }
    }
}