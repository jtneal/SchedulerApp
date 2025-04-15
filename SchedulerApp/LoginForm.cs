using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace SchedulerApp
{
    public partial class LoginForm : Form
    {
        private readonly DAL dal;

        public LoginForm()
        {
            InitializeComponent();
            dal = new DAL();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = usernameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = dal.GetUser(usernameTextBox.Text, passwordTextBox.Text);
            var isValid = user.userId > 0;
            errorLabel.Visible = !isValid;

            if (isValid)
            {
                // Open new form, passing in user to constructor
                Debug.WriteLine("YOU IN BRO!");
            }
        }
    }
}
