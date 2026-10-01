using Microsoft.Data.SqlClient;

namespace SecureShield
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            @"Server=(localdb)\MSSQLLocalDB;Database=SecureShieldDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}