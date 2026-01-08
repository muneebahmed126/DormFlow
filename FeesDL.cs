using System;
using System.Data;
using System.Data.SqlClient;
using FormFlow.DL.Database;

namespace FormFlow.DL.Repositories
{
    public class FeesDL
    {
        // Fetch student details based on ContactNo (Mobile Number)
        public DataTable GetStudentForFee(string contact)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // We only want students with 'Living' status
                string query = "SELECT StudentId, FullName, RoomNo FROM Students WHERE ContactNo = @contact AND Status = 'Living'";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@contact", contact);
                adp.Fill(dt);
            }
            return dt;
        }



        // Save the fee record into the Fees table
        public void PayFee(int studentId, string month, int amount)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "INSERT INTO Fees (StudentId, FeeMonth, Amount) VALUES (@sId, @month, @amount)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@sId", studentId);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@amount", amount);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // STUDENT SIDE: Fetch pending fees using Contact Number
        public DataTable GetPendingFeesByContact(string contact)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // This query finds the fee for the student who was just added as 'Pending'
                string query = @"SELECT f.FeeId, s.FullName, f.FeeMonth, f.Amount, f.PaymentDate 
                         FROM Fees f 
                         INNER JOIN Students s ON f.StudentId = s.StudentId 
                         WHERE s.ContactNo = @contact AND f.PaymentDate IS NULL";

                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@contact", contact);
                con.Open();
                adp.Fill(dt);
            }
            return dt;
        }
        // Inside FeesDL.cs


        // ADMIN: Adds a bill to the Fees table (PaymentDate stays NULL)
        public void AddFeeBill(int studentId, string month, int amount)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                // Check if this month is already billed to avoid duplicates
                string checkQuery = "SELECT COUNT(*) FROM Fees WHERE StudentId = @sid AND FeeMonth = @month";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@sid", studentId);
                checkCmd.Parameters.AddWithValue("@month", month);

                conn.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0) throw new Exception("Fee for this month is already issued.");

                string query = "INSERT INTO Fees (StudentId, FeeMonth, Amount, PaymentDate) VALUES (@sid, @month, @amount, NULL)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();
            }
        }

        // STUDENT: Marks an existing bill as Paid
        public bool PayFeeBill(int feeId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                try
                {
                    // 1. Update the Fees table with the current date
                    string updateFee = "UPDATE Fees SET PaymentDate = GETDATE() WHERE FeeId = @fid";
                    SqlCommand cmd1 = new SqlCommand(updateFee, con, trans);
                    cmd1.Parameters.AddWithValue("@fid", feeId);
                    cmd1.ExecuteNonQuery();

                    // 2. Update the RoomBookings table so the Admin sees "Paid" in the grid
                    // We find the correct booking by linking the StudentId from the Fee record
                    string updateBooking = @"UPDATE RoomBookings 
                                     SET FeeStatus = 'Paid' 
                                     WHERE ContactNo = (
                                         SELECT s.ContactNo 
                                         FROM Students s 
                                         JOIN Fees f ON s.StudentId = f.StudentId 
                                         WHERE f.FeeId = @fid
                                     )";
                    SqlCommand cmd2 = new SqlCommand(updateBooking, con, trans);
                    cmd2.Parameters.AddWithValue("@fid", feeId);
                    cmd2.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }
    }
}