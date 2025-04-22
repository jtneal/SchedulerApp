using SchedulerApp.DAL;

namespace SchedulerApp
{
    public partial class LoginForm : Form
    {
        private readonly CompositeDAL dal;

        public LoginForm()
        {
            InitializeComponent();
            dal = new CompositeDAL();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = usernameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = dal.user.GetUser(usernameTextBox.Text, passwordTextBox.Text);

            if (user.userId > 0)
            {
                // Successful login!
                var form = new MainScreen(dal, user);

                Hide();
                form.Closed += (s, args) => Close();
                form.Show();
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}
