using System;
using System.Data;
using System.Windows.Forms;
using FormFlow.BL;

namespace FormFlow.UI
{
    public partial class UC_AllStudents : UserControl
    {
        StudentBL studentBL = new StudentBL();

        public UC_AllStudents()
        {
            InitializeComponent();
        }

        private void UC_AllStudents_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        public void LoadStudentData()
        {
            try
            {
                // 1. Fetch data based on your specific table schema
                DataTable dt = studentBL.GetAllLivingStudents();

                if (dt != null && dt.Rows.Count > 0)
                {
                    // 2. Bind data to the grid
                    dgvStudents.DataSource = dt;

                    // 3. Rename headers for a professional UI (Matches your SQL Schema)
                    if (dgvStudents.Columns.Contains("FullName"))
                        dgvStudents.Columns["FullName"].HeaderText = "Student Name";

                    if (dgvStudents.Columns.Contains("CNIC"))
                        dgvStudents.Columns["CNIC"].HeaderText = "CNIC / ID";

                    if (dgvStudents.Columns.Contains("ContactNo"))
                        dgvStudents.Columns["ContactNo"].HeaderText = "Contact Number";

                    if (dgvStudents.Columns.Contains("RoomNo"))
                        dgvStudents.Columns["RoomNo"].HeaderText = "Room #";

                    // 4. Final UI Tweaks
                    dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No active students found in the 'Living' status.", "Records Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // This will now specifically tell you if a SQL column name is wrong
                MessageBox.Show("UI Error: " + ex.Message, "Database Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}