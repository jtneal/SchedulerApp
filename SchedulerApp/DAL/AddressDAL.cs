using MySql.Data.MySqlClient;
using SchedulerApp.Entities;
using System.Diagnostics;

namespace SchedulerApp.DAL
{
    public class AddressDAL(string _connectionString)
    {
        public Address GetAddress(int addressId)
        {
            var nullAddress = new Address()
            {
                addressId = int.MinValue,
                address = string.Empty,
                address2 = string.Empty,
                cityId = int.MinValue,
                postalCode = string.Empty,
                phone = string.Empty,
                createDate = DateTime.MinValue,
                createdBy = string.Empty,
                lastUpdate = DateTime.MinValue,
                lastUpdateBy = string.Empty,
            };

            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                var query = "SELECT * FROM address WHERE addressId = @addressId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("addressId", addressId);
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Address()
                    {
                        addressId = reader.GetInt32("addressId"),
                        address = reader.GetString("address"),
                        address2 = reader.GetString("address2"),
                        cityId = reader.GetInt32("cityId"),
                        postalCode = reader.GetString("postalCode"),
                        phone = reader.GetString("phone"),
                        createDate = reader.GetDateTime("createDate"),
                        createdBy = reader.GetString("createdBy"),
                        lastUpdate = reader.GetDateTime("lastUpdate"),
                        lastUpdateBy = reader.GetString("lastUpdateBy"),
                    };
                }
                else
                {
                    throw new Exception("Address not found");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return nullAddress;
            }
        }

        public int CreateAddress(Address address)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var query = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    "VALUES (@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("address", address.address);
                command.Parameters.AddWithValue("address2", address.address2);
                command.Parameters.AddWithValue("cityId", address.cityId);
                command.Parameters.AddWithValue("postalCode", address.postalCode);
                command.Parameters.AddWithValue("phone", address.phone);
                command.Parameters.AddWithValue("createDate", address.createDate);
                command.Parameters.AddWithValue("createdBy", address.createdBy);
                command.Parameters.AddWithValue("lastUpdate", address.lastUpdate);
                command.Parameters.AddWithValue("lastUpdateBy", address.lastUpdateBy);
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

        public bool UpdateAddress(Address address)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var query = "UPDATE address SET address = @address, address2 = @address2, cityId = @cityId, postalCode = @postalCode, phone = @phone, createDate = @createDate, createdBy = @createdBy, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE addressId = @addressId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("address", address.address);
                command.Parameters.AddWithValue("address2", address.address2);
                command.Parameters.AddWithValue("cityId", address.cityId);
                command.Parameters.AddWithValue("postalCode", address.postalCode);
                command.Parameters.AddWithValue("phone", address.phone);
                command.Parameters.AddWithValue("createDate", address.createDate);
                command.Parameters.AddWithValue("createdBy", address.createdBy);
                command.Parameters.AddWithValue("lastUpdate", address.lastUpdate);
                command.Parameters.AddWithValue("lastUpdateBy", address.lastUpdateBy);
                command.Parameters.AddWithValue("addressId", address.addressId);
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return false;
            }
        }

        public City GetCityByName(string cityName)
        {
            var nullCity = new City()
            {
                cityId = int.MinValue,
                city = string.Empty,
                countryId = int.MinValue,
                createDate = DateTime.MinValue,
                createdBy = string.Empty,
                lastUpdate = DateTime.MinValue,
                lastUpdateBy = string.Empty,
    };

            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                var query = "SELECT * FROM city WHERE cityName = @cityName";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("cityName", cityName);
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new City()
                    {
                        cityId = reader.GetInt32("cityId"),
                        city = reader.GetString("city"),
                        countryId = reader.GetInt32("countryId"),
                        createDate = reader.GetDateTime("createDate"),
                        createdBy = reader.GetString("createdBy"),
                        lastUpdate = reader.GetDateTime("lastUpdate"),
                        lastUpdateBy = reader.GetString("lastUpdateBy"),
                    };
                }
                else
                {
                    throw new Exception("City not found");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return nullCity;
            }
        }

        public int CreateCity(City city)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var query = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    "VALUES (@city, @countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("city", city.city);
                command.Parameters.AddWithValue("countryId", city.countryId);
                command.Parameters.AddWithValue("createDate", city.createDate);
                command.Parameters.AddWithValue("createdBy", city.createdBy);
                command.Parameters.AddWithValue("lastUpdate", city.lastUpdate);
                command.Parameters.AddWithValue("lastUpdateBy", city.lastUpdateBy);
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

        public Country GetCountryByName(string countryName)
        {
            var nullCountry = new Country()
            {
                countryId = int.MinValue,
                country = string.Empty,
                createDate = DateTime.MinValue,
                createdBy = string.Empty,
                lastUpdate = DateTime.MinValue,
                lastUpdateBy = string.Empty,
            };

            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                var query = "SELECT * FROM country WHERE countryName = @countryName";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("countryName", countryName);
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Country()
                    {
                        countryId = reader.GetInt32("countryId"),
                        country = reader.GetString("country"),
                        createDate = reader.GetDateTime("createDate"),
                        createdBy = reader.GetString("createdBy"),
                        lastUpdate = reader.GetDateTime("lastUpdate"),
                        lastUpdateBy = reader.GetString("lastUpdateBy"),
                    };
                }
                else
                {
                    throw new Exception("Country not found");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return nullCountry;
            }
        }

        public int CreateCountry(Country country)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var query = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    "VALUES (@country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("country", country.country);
                command.Parameters.AddWithValue("createDate", country.createDate);
                command.Parameters.AddWithValue("createdBy", country.createdBy);
                command.Parameters.AddWithValue("lastUpdate", country.lastUpdate);
                command.Parameters.AddWithValue("lastUpdateBy", country.lastUpdateBy);
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
    }
}
