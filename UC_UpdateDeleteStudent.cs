using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.BL; // This links to your Business Layer

namespace FormFlow.UI
{
    public partial class UC_UpdateDeleteStudent : UserControl
    {
        // Reference to your Logic classes
        RoomBL roomBL = new RoomBL();
        StudentBL studentBL = new StudentBL();

        public UC_UpdateDeleteStudent()
        {
            InitializeComponent();
            this.Visible = true;
            this.Dock = DockStyle.Fill; // Ensures it stretches to full screen
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchMobile.Text != "")
            {
                try
                {
                    long mobile = long.Parse(txtSearchMobile.Text);
                    // We call the method in StudentBL (The code we modified earlier)
                    DataTable dt = studentBL.GetStudentByMobile(mobile);

                    if (dt.Rows.Count > 0)
                    {
                        txtName.Text = dt.Rows[0]["FullName"].ToString();
                        txtEmail.Text = dt.Rows[0]["CNIC"].ToString();
                        txtRoomNo.Text = dt.Rows[0]["RoomNo"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No student found with this mobile number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid mobile number: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update logic here
            if (txtRoomNo.Text != "")
            {
                int rNo = int.Parse(txtRoomNo.Text);
                roomBL.UpdateRoomBookingStatus(rNo, "No"); // Marks room as free
                MessageBox.Show("Student removed and Room " + rNo + " is now free!");
            }
            MessageBox.Show("Student details updated !");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Important: This frees the room too
            if (txtRoomNo.Text != "")
            {
                int rNo = int.Parse(txtRoomNo.Text);
                roomBL.UpdateRoomBookingStatus(rNo, "No"); // Marks room as free
                MessageBox.Show("Student removed and Room " + rNo + " is now free!");
            }
        }
    }
}