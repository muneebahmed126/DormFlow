namespace FormFlow.UI
{
    partial class AdminDashboard
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            btnManageRooms = new Guna.UI2.WinForms.Guna2Button();
            btnNewStudent = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            btnStudentFees = new Guna.UI2.WinForms.Guna2Button();
            btnAllStudents = new Guna.UI2.WinForms.Guna2Button();
            btnNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnEmployeePayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewRequests = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageBookings = new Guna.UI2.WinForms.Guna2Button();

            pnlSidebar = new Panel();
            label2 = new Label();
            panelTop = new Panel();
            pnlMain = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Guna.UI2.WinForms.Guna2Button();

            pnlSidebar.SuspendLayout();
            panelTop.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // --- NAVIGATION SIDEBAR ---
            pnlSidebar.BackColor = Color.FromArgb(64, 0, 64);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(btnManageRooms);
            pnlSidebar.Controls.Add(btnNewStudent);
            pnlSidebar.Controls.Add(btnUpdateDeleteStudent);
            pnlSidebar.Controls.Add(btnStudentFees);
            pnlSidebar.Controls.Add(btnAllStudents);
            pnlSidebar.Controls.Add(btnNewEmployee);
            pnlSidebar.Controls.Add(btnUpdateDeleteEmployee);
            pnlSidebar.Controls.Add(btnEmployeePayment);
            pnlSidebar.Controls.Add(btnViewRequests);
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Size = new Size(312, 848);
            this.pnlSidebar.Controls.Add(this.btnManageBookings);

            label1.AutoSize = true;
            label1.Font = new Font("Mistral", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 25);
            label1.Text = "NAVIGATOR";



            // Helper for Styling
            void ApplyStyle(Guna.UI2.WinForms.Guna2Button b, string text, int y)
            {
                b.Text = text;
                b.Location = new Point(0, y);
                b.Size = new Size(312, 55);
                b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                b.CustomBorderThickness = new Padding(5, 0, 0, 0);
                b.CustomBorderColor = Color.Transparent;
                b.CheckedState.FillColor = Color.White;
                b.CheckedState.ForeColor = Color.FromArgb(151, 48, 103);
                b.CheckedState.CustomBorderColor = Color.FromArgb(255, 128, 0);
                b.FillColor = Color.Transparent;
                b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                b.ForeColor = Color.White;
                b.HoverState.FillColor = Color.FromArgb(100, 48, 103);
                b.TextAlign = HorizontalAlignment.Left;
                b.TextOffset = new Point(20, 0);
            }

            // --- BUTTON REGISTRATION (MODIFIED) ---
            ApplyStyle(btnManageRooms, "Manage Rooms", 120);
            btnManageRooms.Click += btnManageRooms_Click;

            // 3. Apply the style (Using Y-position 720 to follow your All Employees button at 600)
            ApplyStyle(btnManageBookings, "Manage Bookings", 720);
            btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);

            ApplyStyle(btnViewRequests, "Student Requests", 660); // 660 places it below All Employees
            btnViewRequests.Click += new System.EventHandler(this.btnViewRequests_Click);

            ApplyStyle(btnNewStudent, "New Student", 180);
            btnNewStudent.Click += btnNewStudent_Click;

            ApplyStyle(btnUpdateDeleteStudent, "Update/Delete Student", 240);
            btnUpdateDeleteStudent.Click += btnUpdateDeleteStudent_Click; // LINKED

            ApplyStyle(btnStudentFees, "Student Fees", 300);
            btnStudentFees.Click += btnStudentFees_Click;

            ApplyStyle(btnAllStudents, "All Students Living", 360);
            btnAllStudents.Click += btnAllStudents_Click; // LINKED

            ApplyStyle(btnNewEmployee, "New Employee", 420);
            btnNewEmployee.Click += btnNewEmployee_Click;

            ApplyStyle(btnUpdateDeleteEmployee, "Update/Delete Employee", 480);
            btnUpdateDeleteEmployee.Click += btnUpdateDeleteEmployee_Click;

            ApplyStyle(btnEmployeePayment, "Employee Payment", 540);



            // Create the object
            this.btnAllEmployees = new Guna.UI2.WinForms.Guna2Button();

            // Apply the style using your existing ApplyStyle helper
            ApplyStyle(btnAllEmployees, "All Employees", 600); // 600 is the Y-position
            btnAllEmployees.Click += btnAllEmployees_Click;

            // Add it to the sidebar controls
            this.pnlSidebar.Controls.Add(this.btnAllEmployees);

            // Exit Button
            btnExit.Text = "Logout";
            btnExit.FillColor = Color.Crimson;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(0, 790);
            btnExit.Size = new Size(312, 50);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // --- PANELS ---
            panelTop.BackColor = Color.FromArgb(151, 48, 103);
            panelTop.Controls.Add(label2);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(312, 0);
            panelTop.Size = new Size(1052, 120);

            label2.AutoSize = true;
            label2.Font = new Font("Mistral", 26F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(250, 35);
            label2.Text = "DORM FLOW - Smart Management";

            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(312, 120);
            pnlMain.Size = new Size(1052, 728);

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.hostel;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pnlMain.Controls.Add(pictureBox1);

            // --- FORM ---
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 848);
            Controls.Add(pnlMain);
            Controls.Add(panelTop);
            Controls.Add(pnlSidebar);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel pnlSidebar;
        private Panel panelTop;
        private Panel pnlMain;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnManageRooms;
        private Guna.UI2.WinForms.Guna2Button btnNewStudent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteStudent;
        private Guna.UI2.WinForms.Guna2Button btnStudentFees;
        private Guna.UI2.WinForms.Guna2Button btnAllStudents;
        private Guna.UI2.WinForms.Guna2Button btnNewEmployee;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteEmployee;
        private Guna.UI2.WinForms.Guna2Button btnEmployeePayment;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnAllEmployees;
        private Guna.UI2.WinForms.Guna2Button btnViewRequests;
        private Guna.UI2.WinForms.Guna2Button btnManageBookings;

    }
}