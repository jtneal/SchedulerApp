using MySql.Data.MySqlClient;
using SchedulerApp.Entities;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchedulerApp
{
    public class DAL
    {
        private readonly string _connectionString;

        public DAL()
        {
            //_connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";
            _connectionString = "server=localhost;user=root;database=client_schedule;port=3306;password=root";
        }

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

        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                var query = "SELECT * FROM customer";
                using var command = new MySqlCommand(query, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    customers.Add(new Customer()
                    {
                        customerId = reader.GetInt32("customerId"),
                        customerName = reader.GetString("customerName"),
                        addressId = reader.GetInt32("addressId"),
                        active = reader.GetInt32("active"),
                        createDate = reader.GetDateTime("createDate"),
                        createdBy = reader.GetString("createdBy"),
                        lastUpdate = reader.GetDateTime("lastUpdate"),
                        lastUpdateBy = reader.GetString("lastUpdateBy"),
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return customers;
        }

        public void DeleteCustomer(int customerId)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var queries = new List<string>
                {
                    "DELETE FROM appointment WHERE customerId = @customerId",
                    "DELETE FROM customer WHERE customerId = @customerId"
                };

                foreach (var query in queries)
                {
                    using var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("customerId", customerId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
