using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.BL;

namespace FormFlow.UI
{
    public partial class UC_ManageRooms : UserControl
    {
        RoomBL roomBL = new RoomBL();

        public UC_ManageRooms()
        {
            InitializeComponent();
        }

        private void UC_ManageRooms_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            dgvRooms.DataSource = roomBL.GetAllRooms();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "")
            {
                int rNo = int.Parse(txtRoomNo.Text);
                string status = chkActivate.Checked ? "Yes" : "No";
                
                roomBL.AddRoom(rNo, status);
                MessageBox.Show("Room Added!", "Success");
                txtRoomNo.Clear();
                RefreshGrid();
            }
        }

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchRoom.Text != "")
            {
                DataTable dt = roomBL.SearchRoom(int.Parse(txtSearchRoom.Text));
                if (dt.Rows.Count > 0)
                {
                    chkUpdateActivate.Checked = (dt.Rows[0]["RoomStatus"].ToString() == "Yes");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rNo = int.Parse(txtSearchRoom.Text);
            string status = chkUpdateActivate.Checked ? "Yes" : "No";
            roomBL.UpdateRoom(rNo, status);
            RefreshGrid();
            MessageBox.Show("Room Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            roomBL.DeleteRoom(int.Parse(txtSearchRoom.Text));
            RefreshGrid();
            MessageBox.Show("Room Deleted!");
        }
    }
}