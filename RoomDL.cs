using System.Data;
using System.Data.SqlClient;
using FormFlow.DL.Database;

namespace FormFlow.DL.Repositories
{
    public class RoomDL
    {
        // 1. ADD ROOM
        public void AddRoom(int roomNo, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // 'No' is hardcoded for Booked because a new room starts empty
                string query = "INSERT INTO Rooms (RoomNo, RoomStatus, Booked) VALUES (@No, @Status, 'No')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@No", roomNo);
                cmd.Parameters.AddWithValue("@Status", status);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 2. GET ALL ROOMS (To fill your DataGridView)
        public DataTable GetAllRooms()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Rooms";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAvailableRoomsFromDB()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                // query filters by 'No' based on your SQL table schema
                string query = "SELECT RoomNo, RoomStatus, Booked FROM Rooms";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 3. SEARCH ROOM (To find a room for Updating/Deleting)
        public DataTable SearchRoom(int roomNo)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Rooms WHERE RoomNo = @No";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@No", roomNo);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        // 4. UPDATE ROOM STATUS
        public void UpdateRoom(int roomNo, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "UPDATE Rooms SET RoomStatus = @Status WHERE RoomNo = @No";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@No", roomNo);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 5. DELETE ROOM
        public void DeleteRoom(int roomNo)
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    string query = "DELETE FROM Rooms WHERE RoomNo = @roomNo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@roomNo", roomNo);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Error number 547 is specific to Foreign Key violations
                if (ex.Number == 547)
                {
                    throw new Exception("Cannot delete this room because students are currently assigned to it!");
                }
                throw ex;
            }
        }

        // 1. Fetch only rooms that are Active ('Yes') and not yet Booked ('No')
        public DataTable GetAvailableRooms()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT RoomNo FROM Rooms WHERE RoomStatus = 'Yes' AND Booked = 'No'";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        // 2. Change the booking status of a specific room
        public void UpdateRoomBookingStatus(int roomNo, string bookedStatus)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                // Start a transaction to ensure both tables update together
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    // 1. Update the Rooms table (As per your original logic)
                    string roomQuery = "UPDATE Rooms SET Booked = @Status WHERE RoomNo = @No";
                    SqlCommand cmd1 = new SqlCommand(roomQuery, con, trans);
                    cmd1.Parameters.AddWithValue("@Status", bookedStatus);
                    cmd1.Parameters.AddWithValue("@No", roomNo);
                    cmd1.ExecuteNonQuery();

                    // 2. Update the Students table 
                    // If bookedStatus is 'No', it means the student has 'Leaved'
                    if (bookedStatus == "No")
                    {
                        string studentQuery = "UPDATE Students SET Status = 'Leaved', RoomNo = NULL WHERE RoomNo = @No";
                        SqlCommand cmd2 = new SqlCommand(studentQuery, con, trans);
                        cmd2.Parameters.AddWithValue("@No", roomNo);
                        cmd2.ExecuteNonQuery();
                    }

                    // Commit the changes to the database
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    // If anything fails, undo all changes
                    trans.Rollback();
                    throw ex;
                }
            }
        }



        // Inside RoomDL.cs
        public DataTable GetFeesByStudentId(int studentId)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                // Fetches fee details for the specific student
                string query = "SELECT FeeId, FeeMonth, Amount, PaymentDate FROM Fees WHERE StudentId = @sid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", studentId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool MarkFeeAsPaid(int feeId)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                // Updates the PaymentDate to the current system time
                string query = "UPDATE Fees SET PaymentDate = GETDATE() WHERE FeeId = @fid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fid", feeId);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}