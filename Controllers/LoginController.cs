using StudentApp.Models;
using System;
using System.Data.SqlClient; // Import for SQL Server connection

namespace StudentApp.Controllers
{
    internal class LoginController
    {
        public bool Login(string email, string password)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [students_management].[dbo].[login] WHERE email = @Email AND password = @Password", connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }

                reader.Close();
            }

            return false;
        }
    }
}