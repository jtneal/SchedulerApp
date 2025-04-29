using MySql.Data.MySqlClient;
using SchedulerApp.Entities;
using SchedulerApp.Models;
using System.Diagnostics;

namespace SchedulerApp.DAL
{
    public class CustomerDAL(string _connectionString)
    {
        public CustomerModel GetCustomer(int customerId)
        {
            var nullCustomer = new CustomerModel()
            {
                customerId = int.MinValue,
                customerName = string.Empty,
                addressId = int.MinValue,
                address = new AddressModel()
                {
                    addressId = int.MinValue,
                    address = string.Empty,
                    address2 = string.Empty,
                    cityId = int.MinValue,
                    city = new CityModel()
                    {
                        cityId = int.MinValue,
                        city = string.Empty,
                        countryId = int.MinValue,
                        country = new Country()
                        {
                            countryId = int.MinValue,
                            country = string.Empty,
                            createDate = DateTime.MinValue,
                            createdBy = string.Empty,
                            lastUpdate = DateTime.MinValue,
                            lastUpdateBy = string.Empty,
                        },
                        createDate = DateTime.MinValue,
                        createdBy = string.Empty,
                        lastUpdate = DateTime.MinValue,
                        lastUpdateBy = string.Empty,
                    },
                    postalCode = string.Empty,
                    phone = string.Empty,
                    createDate = DateTime.MinValue,
                    createdBy = string.Empty,
                    lastUpdate = DateTime.MinValue,
                    lastUpdateBy = string.Empty,
                },
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
                var query = "SELECT * FROM customer c, address a, city i, country o " +
                    "WHERE c.customerId = @customerId AND c.addressId = a.addressId " +
                    "AND a.cityId = i.cityId AND i.countryId = o.countryId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new CustomerModel()
                    {
                        customerId = reader.GetInt32("customerId"),
                        customerName = reader.GetString("customerName"),
                        addressId = reader.GetInt32("addressId"),
                        address = new AddressModel()
                        {
                            address = reader.GetString("address"),
                            address2 = reader.GetString("address2"),
                            cityId = reader.GetInt32("cityId"),
                            city = new CityModel()
                            {
                                city = reader.GetString("city"),
                                countryId = reader.GetInt32("countryId"),
                                country = new Country()
                                {
                                    country = reader.GetString("country"),
                                },
                            },
                            postalCode = reader.GetString("postalCode"),
                            phone = reader.GetString("phone"),
                        },
                        active = reader.GetInt32("active"),
                    };
                }
                else
                {
                    throw new Exception("Customer not found");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return nullCustomer;
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

        public int CreateCustomer(Customer customer)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var query = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    "VALUES (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("customerName", customer.customerName);
                command.Parameters.AddWithValue("addressId", customer.addressId);
                command.Parameters.AddWithValue("active", customer.active);
                command.Parameters.AddWithValue("createDate", customer.createDate);
                command.Parameters.AddWithValue("createdBy", customer.createdBy);
                command.Parameters.AddWithValue("lastUpdate", customer.lastUpdate);
                command.Parameters.AddWithValue("lastUpdateBy", customer.lastUpdateBy);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT LAST_INSERT_ID()";

                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return 0;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var query = "UPDATE customer SET customerName = @customerName, addressId = @addressId, active = @active, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE customerId = @customerId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("customerName", customer.customerName);
                command.Parameters.AddWithValue("addressId", customer.addressId);
                command.Parameters.AddWithValue("active", customer.active);
                command.Parameters.AddWithValue("lastUpdate", customer.lastUpdate);
                command.Parameters.AddWithValue("lastUpdateBy", customer.lastUpdateBy);
                command.Parameters.AddWithValue("customerId", customer.customerId);
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return false;
            }
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
