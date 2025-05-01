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
            using var sw = File.AppendText(@"..\..\..\Login_History.txt");

            if (user.userId > 0)
            {
                sw.WriteLine($"{DateTimeOffset.Now.ToUnixTimeSeconds()}\t{usernameTextBox.Text}\tsuccess");

                var form = new MainScreen(dal, user);

                Hide();
                form.Closed += (s, args) => Close();
                form.Show();
            }
            else
            {
                sw.WriteLine($"{DateTimeOffset.Now.ToUnixTimeSeconds()}\t{usernameTextBox.Text}\tfail");
                errorLabel.Visible = true;
            }
        }
    }
}
