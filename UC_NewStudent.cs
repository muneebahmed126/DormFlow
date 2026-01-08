using FormFlow.BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace FormFlow.UI
{
    public partial class UC_NewStudent : UserControl
    {
        StudentBL studentBL = new StudentBL();
        RoomBL roomBL = new RoomBL();

        public UC_NewStudent()
        {
            InitializeComponent();
        }

        // Fixes the 'btnSave_Click' error
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text != "" && txtCNIC.Text != "" && comboRoomNo.Text != "")
                {
                    string name = txtFullName.Text;
                    string contact = txtContact.Text;
                    string email = txtEmail.Text;
                    string cnic = txtCNIC.Text;
                    int roomNo = int.Parse(comboRoomNo.Text);

                    // Call your BL to save
                    studentBL.RegisterStudent(name, cnic, contact, roomNo);

                    MessageBox.Show("Student Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ClearFields()
        {
            txtFullName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtCNIC.Clear();

            // For the ComboBox, we reset it to no selection
            if (comboRoomNo.Items.Count > 0)
            {
                comboRoomNo.SelectedIndex = -1;
            }
        }

        // Fixes the 'btnExit_Click' error
        private void btnExit_Click(object sender, EventArgs e)
        {
            // This will hide the user control or clear the main panel
            this.Visible = false;
        }


        private void UC_NewStudent_Load(object sender, EventArgs e)
        {
            // Fetch only available rooms from your Rooms table
            DataTable dt = roomBL.GetAvailableRooms();

            comboRoomNo.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboRoomNo.Items.Add(row["RoomNo"].ToString());
            }
        }
    }
}