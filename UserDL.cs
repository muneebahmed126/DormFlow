using System;
using System.Data.SqlClient;
using FormFlow.Model.Users;
using FormFlow.DL.Interfaces;
using FormFlow.DL.Database;

namespace FormFlow.DL.Repositories
{
    public class UserDL : IUserDL
    {
        public void SignUp(User user, string username, string password)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                // Updated table name to AppUsers
                string query =
                    "INSERT INTO AppUsers (FullName, CNIC, Role, Username, Password) " +
                    "VALUES (@Name, @CNIC, @Role, @Username, @Password)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@CNIC", user.CNIC);
                cmd.Parameters.AddWithValue("@Role", user.GetRole());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public User SignIn(string username, string password)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            { 
                
                string query =
                    "SELECT * FROM AppUsers WHERE Username=@Username AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    int id = Convert.ToInt32(reader["UserId"]);
                    string name = reader["FullName"].ToString();
                    string cnic = reader["CNIC"].ToString();

                    // Polymorphism based on role
                    if (role == "Admin")
                        return new Admin(id, name, cnic);
                    else if (role == "Student")
                        return new Student(id, name, cnic, "", "");
                    else
                        return new Guest(id, name, cnic, "");
                }
            }
            return null;
        }
    }
}