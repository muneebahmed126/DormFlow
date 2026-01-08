using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_AdminManageBookings : UserControl
    {
        BookingDL _bookingDL = new BookingDL();

        public UC_AdminManageBookings()
        {
            InitializeComponent();
            LoadAllBookings();
        }

        private void LoadAllBookings()
        {
            // This method should exist in your BookingDL
            dgvBookings.DataSource = _bookingDL.GetAllBookingRequests();
        }

        // FIX FOR btnApprove_Click ERROR
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvBookings.SelectedRows[0];

                    int bId = Convert.ToInt32(row.Cells["BookingId"].Value);
                    string contact = row.Cells["ContactNo"].Value.ToString();
                    string name = row.Cells["FullName"].Value.ToString();
                    string room = row.Cells["RoomNo"].Value.ToString();
                    string cnic = row.Cells["CNIC"].Value.ToString(); // Pulling CNIC from the grid

                    if (string.IsNullOrWhiteSpace(txtFeeAmount.Text))
                    {
                        MessageBox.Show("Please enter a fee amount first.");
                        return;
                    }
                    decimal amount = Convert.ToDecimal(txtFeeAmount.Text);

                    // Pass all 6 arguments to the updated DL method
                    if (_bookingDL.ApproveAndAssignFee(bId, contact, amount, name, room, cnic))
                    {
                        MessageBox.Show("Booking Approved and Student Record Created!");
                        LoadAllBookings();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        // FIX FOR btnAllotRoom_Click ERROR
       private void btnAllotRoom_Click(object sender, EventArgs e)
{
    // Check if a row is selected in the grid
    if (dgvBookings.SelectedRows.Count > 0)
    {
        try
        {
            DataGridViewRow row = dgvBookings.SelectedRows[0];
            
            // Extract necessary data from the grid
            string contact = row.Cells["ContactNo"].Value.ToString();
            string roomNo = row.Cells["RoomNo"].Value.ToString(); // Ensure this is a string
            int bId = Convert.ToInt32(row.Cells["BookingId"].Value);
            string feeStatus = row.Cells["FeeStatus"].Value.ToString();

            // Only allow allotment if the fee is already paid
            if (feeStatus == "Paid")
            {
                // Call the DL method to update Room Status to 'Booked' and Student to 'Living'
                if (_bookingDL.FinalizeAllotment(contact, roomNo, bId))
                {
                    MessageBox.Show($"Room {roomNo} allotted successfully! Student status is now 'Living'.", "Success");
                    LoadAllBookings(); // Refresh the grid to show 'Allotted'
                }
                else
                {
                    MessageBox.Show("Failed to update database records.");
                }
            }
            else
            {
                MessageBox.Show("Cannot allot room. Fee is still Unpaid.", "Payment Required");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
    }
}