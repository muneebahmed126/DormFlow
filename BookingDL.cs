using System;
using System.Data;
using System.Data.SqlClient;
using FormFlow.DL.Database;
namespace FormFlow.DL.Repositories
{
    public class BookingDL
    {
        // 1. Student: Submit a booking request
        public bool SubmitBookingRequest(string name, string cnic, string contact, string roomNo)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO RoomBookings (FullName, CNIC, ContactNo, RoomNo, BookingStatus, FeeStatus) 
                                 VALUES (@name, @cnic, @contact, @room, 'Pending', 'Unpaid')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@room", roomNo);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 2. Student: View their own booking status
        public DataTable GetStudentBookingStatus(string contact)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT FullName, RoomNo, BookingStatus, FeeStatus FROM RoomBookings WHERE ContactNo = @contact";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@contact", contact);
                adp.Fill(dt);
            }
            return dt;
        }

        public bool FinalizeAllotment(string contact, string roomNo, int bookingId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                try
                {
                    // 1. Mark the Room as 'Booked' so it's no longer available
                    string updateRoom = "UPDATE Rooms SET Booked = 'Yes' WHERE RoomNo = @rno";
                    SqlCommand cmd1 = new SqlCommand(updateRoom, con, trans);
                    cmd1.Parameters.AddWithValue("@rno", roomNo);
                    cmd1.ExecuteNonQuery();

                    // 2. Change Student status to 'Living'
                    string updateStudent = "UPDATE Students SET Status = 'Living' WHERE ContactNo = @contact";
                    SqlCommand cmd2 = new SqlCommand(updateStudent, con, trans);
                    cmd2.Parameters.AddWithValue("@contact", contact);
                    cmd2.ExecuteNonQuery();

                    // 3. Update the Booking Request to 'Allotted'
                    string updateBooking = "UPDATE RoomBookings SET BookingStatus = 'Allotted' WHERE BookingId = @bid";
                    SqlCommand cmd3 = new SqlCommand(updateBooking, con, trans);
                    cmd3.Parameters.AddWithValue("@bid", bookingId);
                    cmd3.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        }

        // 1. Fetch all pending or approved bookings for the Admin Grid
        public DataTable GetAllBookings()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT BookingId, FullName, CNIC, ContactNo, RoomNo, BookingStatus, FeeStatus FROM RoomBookings";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                con.Open();
                adp.Fill(dt);
            }
            return dt;
        }

   
        public bool ApproveAndAssignFee(int bookingId, string contact, decimal amount, string fullName, string roomNo, string cnic)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                try
                {
                    // 1. Update RoomBookings Status
                    string updateBooking = "UPDATE RoomBookings SET BookingStatus = 'Approved' WHERE BookingId = @bid";
                    SqlCommand cmd1 = new SqlCommand(updateBooking, con, trans);
                    cmd1.Parameters.AddWithValue("@bid", bookingId);
                    cmd1.ExecuteNonQuery();

                    // 2. Create Pending Student WITH CNIC
                  
                    string insertStudent = @"INSERT INTO Students (FullName, ContactNo, RoomNo, CNIC, Status) 
                                     OUTPUT INSERTED.StudentId 
                                     VALUES (@name, @contact, @room, @cnic, 'Pending')";
                    SqlCommand cmd2 = new SqlCommand(insertStudent, con, trans);
                    cmd2.Parameters.AddWithValue("@name", fullName);
                    cmd2.Parameters.AddWithValue("@contact", contact);
                    cmd2.Parameters.AddWithValue("@room", roomNo);
                    cmd2.Parameters.AddWithValue("@cnic", cnic); 
                    int newStudentId = (int)cmd2.ExecuteScalar();

                    // 3. Insert Fee record
                    string insertFee = "INSERT INTO Fees (StudentId, FeeMonth, Amount, PaymentDate) VALUES (@sid, 'Booking Fee', @amt, NULL)";
                    SqlCommand cmd3 = new SqlCommand(insertFee, con, trans);
                    cmd3.Parameters.AddWithValue("@sid", newStudentId);
                    cmd3.Parameters.AddWithValue("@amt", amount);
                    cmd3.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        
        }


        public DataTable GetAllBookingRequests()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // Fetches pending bookings from the RoomBookings table
                string query = @"SELECT BookingId, FullName, CNIC, ContactNo, RoomNo, 
                         BookingStatus, FeeStatus, RequestDate 
                         FROM RoomBookings ORDER BY RequestDate DESC";

                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                con.Open();
                adp.Fill(dt);
            }
            return dt;
        }
    }
}