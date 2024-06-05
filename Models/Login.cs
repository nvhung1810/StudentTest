using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentApp.Models
{
    internal class Login
    {
        private readonly string connectionString;

        public Login(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool IsValidCredentials(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(1) FROM [students_management].[dbo].[login] WHERE email = @Email AND password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while checking credentials: " + ex.Message);
            }
        }
    }
}
