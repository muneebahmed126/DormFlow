using System;
using System.Data.SqlClient;

namespace FormFlow.DL.Database
{
    public class DbConnection
    {
        // Added 'TrustServerCertificate=True' to prevent modern SSL connection errors
        private static string connectionString =
      "Data Source=localhost;Initial Catalog=FormFlowSystemDB;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}