using MySql.Data.MySqlClient;
using SchedulerApp.Entities;
using System.Diagnostics;

namespace SchedulerApp.DAL
{
    public class UserDAL(string _connectionString)
    {
        public User GetUser(string username, string password)
        {
            var nullUser = new User()
            {
                userId = int.MinValue,
                userName = string.Empty,
                password = string.Empty,
                active = int.MinValue,
                createDate = DateTime.MinValue,
                createdBy = string.Empty,
                lastUpdate = DateTime.MinValue,
                lastUpdateBy = string.Empty,
            };

            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                var query = "SELECT * FROM user WHERE active = 1 AND userName = @username AND password = @password LIMIT 1";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new User()
                    {
                        userId = reader.GetInt32("userId"),
                        userName = reader.GetString("userName"),
                        password = reader.GetString("password"),
                        active = reader.GetInt32("active"),
                        createDate = reader.GetDateTime("createDate"),
                        createdBy = reader.GetString("createdBy"),
                        lastUpdate = reader.GetDateTime("lastUpdate"),
                        lastUpdateBy = reader.GetString("lastUpdateBy"),
                    };
                }
                else
                {
                    throw new Exception("User not found");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return nullUser;
            }
        }
    }
}
