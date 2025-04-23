using MySql.Data.MySqlClient;
using SchedulerApp.Entities;
using SchedulerApp.Models;
using System.Diagnostics;

namespace SchedulerApp.DAL
{
    public class AppointmentDAL(string _connectionString)
    {
        public Appointment GetAppointment(int appointmentId)
        {
            var nullAppointment = new Appointment()
            {
                appointmentId = int.MinValue,
                customerId = int.MinValue,
                userId = int.MinValue,
                type = string.Empty,
                start = DateTime.MinValue,
                end = DateTime.MinValue,
                createDate = DateTime.MinValue,
                createdBy = string.Empty,
                lastUpdate = DateTime.MinValue,
                lastUpdateBy = string.Empty,
            };

            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                var query = "SELECT * FROM appointment WHERE appointmentId = @appointmentId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("appointmentId", appointmentId);
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Appointment()
                    {
                        appointmentId = reader.GetInt32("appointmentId"),
                        customerId = reader.GetInt32("customerId"),
                        userId = reader.GetInt32("userId"),
                        type = reader.GetString("type"),
                        start = reader.GetDateTime("start"),
                        end = reader.GetDateTime("end"),
                        createDate = reader.GetDateTime("createDate"),
                        createdBy = reader.GetString("createdBy"),
                        lastUpdate = reader.GetDateTime("lastUpdate"),
                        lastUpdateBy = reader.GetString("lastUpdateBy"),
                    };
                }
                else
                {
                    throw new Exception("Appointment not found");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return nullAppointment;
            }
        }

        public bool HasConflict(int appointmentId, DateTime start, DateTime end)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                var query = "SELECT COUNT(appointmentId) as count FROM appointment WHERE appointmentId <> @appointmentId AND start < @end AND end > @start";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("appointmentId", appointmentId);
                command.Parameters.AddWithValue("end", end);
                command.Parameters.AddWithValue("start", start);
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetInt32("count") > 0;
                }
                else
                {
                    throw new Exception("Could not determine appointment count");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return true;
            }
        }

        public List<Appointment> GetAppointments()
        {
            var appointments = new List<Appointment>();

            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                var query = "SELECT appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM appointment";
                using var command = new MySqlCommand(query, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    appointments.Add(new Appointment()
                    {
                        appointmentId = reader.GetInt32("appointmentId"),
                        customerId = reader.GetInt32("customerId"),
                        userId = reader.GetInt32("userId"),
                        type = reader.GetString("type"),
                        start = reader.GetDateTime("start"),
                        end = reader.GetDateTime("end"),
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

            return appointments;
        }

        public int CreateAppointment(Appointment appointment)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var query = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    "VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end,  @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("customerId", appointment.customerId);
                command.Parameters.AddWithValue("userId", appointment.userId);
                command.Parameters.AddWithValue("title", "not needed");
                command.Parameters.AddWithValue("description", "not needed");
                command.Parameters.AddWithValue("location", "not needed");
                command.Parameters.AddWithValue("contact", "not needed");
                command.Parameters.AddWithValue("type", appointment.type);
                command.Parameters.AddWithValue("url", "not needed");
                command.Parameters.AddWithValue("start", appointment.start);
                command.Parameters.AddWithValue("end", appointment.end);
                command.Parameters.AddWithValue("createDate", appointment.createDate);
                command.Parameters.AddWithValue("createdBy", appointment.createdBy);
                command.Parameters.AddWithValue("lastUpdate", appointment.lastUpdate);
                command.Parameters.AddWithValue("lastUpdateBy", appointment.lastUpdateBy);
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

        public bool UpdateAppointment(Appointment appointment)
        {
            using var connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();

                var query = "UPDATE appointment SET customerId = @customerId, userId = @userId, title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end, createDate = @createDate, createdBy = @createdBy, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE appointmentId = @appointmentId";
                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("customerId", appointment.customerId);
                command.Parameters.AddWithValue("userId", appointment.userId);
                command.Parameters.AddWithValue("title", "not needed");
                command.Parameters.AddWithValue("description", "not needed");
                command.Parameters.AddWithValue("location", "not needed");
                command.Parameters.AddWithValue("contact", "not needed");
                command.Parameters.AddWithValue("type", appointment.type);
                command.Parameters.AddWithValue("url", "not needed");
                command.Parameters.AddWithValue("start", appointment.start);
                command.Parameters.AddWithValue("end", appointment.end);
                command.Parameters.AddWithValue("createDate", appointment.createDate);
                command.Parameters.AddWithValue("createdBy", appointment.createdBy);
                command.Parameters.AddWithValue("lastUpdate", appointment.lastUpdate);
                command.Parameters.AddWithValue("lastUpdateBy", appointment.lastUpdateBy);
                command.Parameters.AddWithValue("appointmentId", appointment.appointmentId);
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return false;
            }
        }

        public void DeleteAppointment(int appointmentId)
        {
            using var connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();

                var query = "DELETE FROM appointment WHERE appointmentId = @appointmentId";

                using var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("appointmentId", appointmentId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
