using FormFlow.BL;
using FormFlow.BL; // Your Business Logic Layer
using System;
using System.Data;
using System.Windows.Forms;

namespace FormFlow.UI
{
    public partial class UC_ViewAllRooms : UserControl
    {
        public UC_ViewAllRooms()
        {
            InitializeComponent();
            // Assign the Load event
            this.Load += new EventHandler(UC_ViewAllRooms_Load);
        }

        private void UC_ViewAllRooms_Load(object sender, EventArgs e)
        {
            FetchRoomData();
        }

        public void FetchRoomData()
        {
            try
            {
                RoomBL bl = new RoomBL();
                DataTable dt = bl.ListAllRoomStatuses(); // Ensure this method exists in your BL

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvRooms.DataSource = dt;
                }
                else
                {
                    // Debugging message to see if DB is the problem
                    MessageBox.Show("DB connected, but no rooms found in the table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid: " + ex.Message);
            }
        }
    }
}