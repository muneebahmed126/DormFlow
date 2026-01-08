using System;
using System.Data;
using System.Data.SqlClient;
using FormFlow.DL.Database;
namespace FormFlow.Dl.Repositories
{
    public class StudentDL
    {
        public void RegisterStudent(string name, string cnic, string contact, int roomNo)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                // Start a transaction to keep data synchronized
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    // 1. Insert the Student into your specific table
                    // Note: We do NOT include StudentId because it is IDENTITY(1,1)
                    string studentQuery = @"INSERT INTO Students (FullName, CNIC, ContactNo, RoomNo, Status) 
                                    VALUES (@name, @cnic, @contact, @room, 'Living')";

                    SqlCommand cmd1 = new SqlCommand(studentQuery, con, trans);
                    cmd1.Parameters.AddWithValue("@name", name);
                    cmd1.Parameters.AddWithValue("@cnic", cnic);
                    cmd1.Parameters.AddWithValue("@contact", contact);
                    cmd1.Parameters.AddWithValue("@room", roomNo);
                    cmd1.ExecuteNonQuery();

                    // 2. IMPORTANT: Update the 'Rooms' table so 'Manage Rooms' reflects the change
                    // We set 'Booked' status or increment an occupancy counter
                    string roomQuery = "UPDATE Rooms SET Booked = 'Yes' WHERE RoomNo = @roomNo";

                    SqlCommand cmd2 = new SqlCommand(roomQuery, con, trans);
                    cmd2.Parameters.AddWithValue("@roomNo", roomNo);
                    cmd2.ExecuteNonQuery();

                    // Commit both changes
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
            }
        }

        // Inside StudentDL.cs
        public DataTable GetStudentDetails(long mobile)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Students WHERE MobileNo = @mobile";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@mobile", mobile);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        public DataTable GetStudentByMobile(long mobile)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // Selects student details based on mobile number
                string query = "SELECT FullName, CNIC, RoomNo FROM Students WHERE ContactNo = @mobile";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@mobile", mobile);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAllLivingStudents()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // Matches your schema: selecting only those with Status 'Living'
                string query = "SELECT FullName, CNIC, ContactNo, RoomNo FROM Students WHERE Status = 'Living'";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.Fill(dt);
            }
            return dt;
        }

        public DataTable GetStudentByMobile(string contact)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // Using ContactNo as the search parameter based on your schema
                string query = "SELECT FullName, CNIC, RoomNo, Status FROM Students WHERE ContactNo = @contact";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@contact", contact);
                adp.Fill(dt);
            }
            return dt;
        }

        public DataTable GetStudentProfile(int studentId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Students WHERE StudentId = @id";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@id", studentId);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        public DataTable GetStudentFeeHistory(int studentId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT FeeMonth, Amount, PaymentDate FROM Fees WHERE StudentId = @id ORDER BY PaymentDate DESC";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@id", studentId);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }
        public void UpdateStudent(long mobile, string name, string email)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "UPDATE Students SET StudentName = @name, Email = @email WHERE MobileNo = @mobile";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobile", mobile);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}