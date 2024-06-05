using System;
using System.Data.SqlClient;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    internal class UserController
    {
        public async Task<User> GetUserById(int id)
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM [students_management].[dbo].[user] WHERE id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        User user = new User
                        {
                            Id = reader.GetInt32(0), 
                            Name = reader.GetString(1), 
                            Email = reader.GetString(2), 
                            DateOfBirth = reader.GetString(3),
                            UserId = reader.GetString(4),
                            Major = reader.GetString(5),
                            ImgUrl = reader.GetString(6)
                        };

                        reader.Close();
                        return user;
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Database error: {ex.Message}");
                    return null;
                }
            }

            return null;
        }
    }
}
