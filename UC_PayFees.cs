using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormFlow.DL.Repositories;

namespace FormFlow.UI
{
    public partial class UC_PayFees : UserControl
    {
        private FeesDL _feesDL = new FeesDL();

        public UC_PayFees()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string contact = txtSearchId.Text.Trim();

            if (!string.IsNullOrEmpty(contact))
            {
                try
                {
                    // Fetch pending fees using the contact number provided in booking
                    DataTable dt = _feesDL.GetPendingFeesByContact(contact);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgvFeesDisplay.DataSource = dt;

                        // Ensure columns are named correctly for logic to work
                        if (dgvFeesDisplay.Columns["FeeId"] != null)
                            dgvFeesDisplay.Columns["FeeId"].Visible = false;

                        UpdateUIColors();
                    }
                    else
                    {
                        dgvFeesDisplay.DataSource = null;
                        MessageBox.Show("No pending fees found. Ensure the Admin has approved your request.", "Notification");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving fee records: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter the Contact Number used during booking.");
            }
        }

        private void UpdateUIColors()
        {
            foreach (DataGridViewRow row in dgvFeesDisplay.Rows)
            {
                // Check if the PaymentDate column exists and has a value
                if (row.Cells["PaymentDate"].Value != DBNull.Value && row.Cells["PaymentDate"].Value != null)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            if (dgvFeesDisplay.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvFeesDisplay.SelectedRows[0];

                // Prevent double payment
                if (row.Cells["PaymentDate"].Value != DBNull.Value)
                {
                    MessageBox.Show("This record is already marked as Paid.");
                    return;
                }

                int feeId = Convert.ToInt32(row.Cells["FeeId"].Value);

                if (_feesDL.PayFeeBill(feeId))
                {
                    MessageBox.Show("Payment Successful! Your room allotment will now be finalized by the Admin.");
                    btnFetch_Click(sender, e); // Refresh the grid
                }
            }
            else
            {
                MessageBox.Show("Please select a fee record from the table to pay.");
            }
        }
    }
}