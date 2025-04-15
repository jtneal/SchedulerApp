using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace SchedulerApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = usernameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Move this to a repo or some other pattern
            var connStr = "server=localhost;user=root;database=client_schedule;port=3306;password=root";
            var conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                var sql = "SELECT * FROM user WHERE active = 1 AND userName = @username AND password = @password LIMIT 1";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("password", passwordTextBox.Text);
                var rdr = cmd.ExecuteReader();
                var isValid = rdr.Read();
                errorLabel.Visible = !isValid;
                rdr.Close();

                if (isValid)
                {
                    Debug.WriteLine("YOU IN BRO!");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
