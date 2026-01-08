using FormFlow.DL.Database;
using System.Data;
using System.Data.SqlClient;

namespace FormFlow.DL.Repositories
{
    public class EmployeeDL
    {

        public DataTable GetEmployeesByStatus(string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // We select FullName, Designation (Profession), and other details
                string query = "SELECT FullName, Designation, MobileNo, Email, Status FROM Employees WHERE Status = @status";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@status", status);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }
        public DataTable GetEmployeeByCNIC(string cnic)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Employees WHERE CNIC = @cnic";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.SelectCommand.Parameters.AddWithValue("@cnic", cnic);
                adp.Fill(dt);
            }
            return dt;
        }

        public void UpdateEmployee(string cnic, string name, string mobile, string email, string desig, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "UPDATE Employees SET FullName=@name, MobileNo=@mobile, Email=@email, Designation=@desig, Status=@status WHERE CNIC=@cnic";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@desig", desig);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void RegisterEmployee(string name, string cnic, string mobile, string email, string desig)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "INSERT INTO Employees (FullName, CNIC, MobileNo, Email, Designation, Status) " +
                               "VALUES (@name, @cnic, @mobile, @email, @desig, 'Working')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@desig", desig);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}