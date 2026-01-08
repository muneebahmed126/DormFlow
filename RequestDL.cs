using System.Data;
using System.Data.SqlClient;
using FormFlow.DL.Database;
public class RequestDL
{
    // STUDENT: Post a new request
    public void AddRequest(int studentId, string text)
    {
        using (SqlConnection con = DbConnection.GetConnection())
        {
            string query = "INSERT INTO HostelRequests (StudentId, RequestText, RequestDate, IsViewedByAdmin, IsFulfilled) " +
                           "VALUES (@sid, @text, GETDATE(), 0, 0)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@sid", studentId);
            cmd.Parameters.AddWithValue("@text", text);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
    // STUDENT: Get requests for a specific student (by Contact)
    public DataTable GetRequestsByContact(string contact)
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = DbConnection.GetConnection())
        {
            string query = @"SELECT r.RequestId, r.RequestText, r.RequestDate, 
                             r.IsViewedByAdmin, r.IsFulfilled, r.IsCompletedByStudent 
                             FROM HostelRequests r 
                             JOIN Students s ON r.StudentId = s.StudentId 
                             WHERE s.ContactNo = @contact";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            adp.SelectCommand.Parameters.AddWithValue("@contact", contact);
            adp.Fill(dt);
        }
        return dt;
    }


    public DataTable GetRequestsByStudentId(int studentId)
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = DbConnection.GetConnection())
        {
            string query = "SELECT RequestId, RequestText, RequestDate, IsViewedByAdmin, IsFulfilled FROM HostelRequests WHERE StudentId = @sid";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            adp.SelectCommand.Parameters.AddWithValue("@sid", studentId);
            adp.Fill(dt);
        }
        return dt;
    }
    public void UpdateFulfilledStatus(int requestId, int status)
    {
        using (SqlConnection con = DbConnection.GetConnection())
        {
            // Updates the status: 1 for Fulfilled, 0 for Pending
            string query = "UPDATE HostelRequests SET IsFulfilled = @status WHERE RequestId = @rid";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@rid", requestId);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // ADMIN: View all requests and mark them as 'Viewed'
    public DataTable GetAllRequestsForAdmin()
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = DbConnection.GetConnection())
        {
            con.Open();

            // Mark all as seen by admin first
            string updateSql = "UPDATE HostelRequests SET IsViewedByAdmin = 1 WHERE IsViewedByAdmin = 0";
            new SqlCommand(updateSql, con).ExecuteNonQuery();

            // Fetch the data including the Fulfilled status
            string selectSql = @"SELECT r.RequestId, s.FullName, r.RequestText, 
                             r.RequestDate, r.IsFulfilled 
                             FROM HostelRequests r 
                             JOIN Students s ON r.StudentId = s.StudentId 
                             ORDER BY r.RequestDate DESC";

            SqlDataAdapter adp = new SqlDataAdapter(selectSql, con);
            adp.Fill(dt);
        }
        return dt;
    }
}