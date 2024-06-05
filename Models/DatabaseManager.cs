using System.Data.SqlClient;

namespace StudentApp.Models
{
    internal class DatabaseManager
    {
        private static string connectionString = "Data Source=DESKTOP-USR0LGV\\SQLEXPRESS;Initial Catalog=students_management;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
