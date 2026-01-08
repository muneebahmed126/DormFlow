using System;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_HostelBooking : UserControl
    {
        BookingDL _bookingDL = new BookingDL();

        public UC_HostelBooking()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please fill all details.");
                return;
            }

            bool success = _bookingDL.SubmitBookingRequest(txtName.Text, txtCNIC.Text, txtContact.Text, txtRoomNo.Text);

            if (success)
            {
                MessageBox.Show("Request Sent! Admin will assign fees soon.");
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            dgvStatus.DataSource = _bookingDL.GetStudentBookingStatus(txtContact.Text);
        }
    }
}