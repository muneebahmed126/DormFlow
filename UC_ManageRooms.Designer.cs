namespace FormFlow.UI
{
    partial class UC_ManageRooms
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges edges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges edges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            label1 = new Label();
            txtRoomNo = new TextBox();
            chkActivate = new CheckBox();
            btnAddRoom = new Button();
            dgvRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSearchRoom = new TextBox();
            label2 = new Label();
            label3 = new Label();
            chkUpdateActivate = new CheckBox();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();

            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();

            // Background & Size
            this.BackColor = Color.FromArgb(151, 48, 103);
            this.Size = new Size(702, 601);

            // Title
            label1.Text = "MANAGE ROOMS";
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 20);
            label1.AutoSize = true;

            // --- ADD SECTION ---
            label2.Text = "Room Number"; label2.ForeColor = Color.White; label2.Location = new Point(40, 80);
            txtRoomNo.Location = new Point(160, 77); txtRoomNo.Size = new Size(120, 31);

            chkActivate.Text = "Active"; chkActivate.ForeColor = Color.White; chkActivate.Location = new Point(300, 79);

            btnAddRoom.Text = "ADD"; btnAddRoom.BackColor = Color.RoyalBlue; btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(400, 75); btnAddRoom.Size = new Size(90, 35);
            btnAddRoom.FlatStyle = FlatStyle.Flat; btnAddRoom.Click += btnAddRoom_Click;

            // --- SEARCH/UPDATE SECTION ---
            label3.Text = "Search Room"; label3.ForeColor = Color.White; label3.Location = new Point(40, 140);
            txtSearchRoom.Location = new Point(160, 137); txtSearchRoom.Size = new Size(120, 31);
            txtSearchRoom.TextChanged += txtSearchRoom_TextChanged; // Auto-Search feature

            chkUpdateActivate.Text = "Active"; chkUpdateActivate.ForeColor = Color.White; chkUpdateActivate.Location = new Point(300, 139);

            btnUpdate.Text = "UPDATE"; btnUpdate.BackColor = Color.SeaGreen; btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(400, 135); btnUpdate.Size = new Size(90, 35);
            btnUpdate.FlatStyle = FlatStyle.Flat; btnUpdate.Click += btnUpdate_Click;

            btnDelete.Text = "DELETE"; btnDelete.BackColor = Color.Crimson; btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(500, 135); btnDelete.Size = new Size(90, 35);
            btnDelete.FlatStyle = FlatStyle.Flat; btnDelete.Click += btnDelete_Click;

            // --- GRID VIEW ---
            dgvRooms.AllowUserToAddRows = true;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.Location = new Point(30, 200);
            dgvRooms.Size = new Size(640, 370);
            dgvRooms.ThemeStyle.RowsStyle.Height = 30;

            // --- EXIT ---
            btnExit.FillColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(650, 10);
            btnExit.Size = new Size(35, 35);
            btnExit.Text = "X";
            btnExit.Click += (s, e) => { this.Visible = false; };

            this.Controls.AddRange(new Control[] { label1, label2, txtRoomNo, chkActivate, btnAddRoom, dgvRooms, btnDelete, btnUpdate, txtSearchRoom, label3, chkUpdateActivate, btnExit });
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            this.Load += UC_ManageRooms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1, label2, label3;
        private TextBox txtRoomNo, txtSearchRoom;
        private CheckBox chkActivate, chkUpdateActivate;
        private Button btnAddRoom, btnUpdate, btnDelete;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRooms;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
    }
}