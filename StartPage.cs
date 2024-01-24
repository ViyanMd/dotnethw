using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class fLogin : Form
    {

        static private User activeUser;
        public fLogin()
        {
            InitializeComponent();
        }
        private void onStartPageLoad(object sender, EventArgs e)
        {
        }
        private void onLogInClicked(object sender, EventArgs e)
        {
            var username = tbUsername.Text;
            var userPass = tbPassword.Text;

            if (UserCollection._data.TryGetValue(username, out User libUser))
            {
                if (libUser._password == userPass)
                {
                    if (libUser._isAdmin)
                    {
                        var adminPanel = new AdminPanel();
                        adminPanel.ShowDialog();
                    }
                    else
                    {
                        var library = new Library();
                        library.ShowDialog();
                    }
                    activeUser = libUser;
                }
            }
            else
            {
                MessageBox.Show($"User with username '{username}' doesn't exist.");
            }
        }

        private void onQuitStartPage(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onRegisterClicked(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.ShowDialog();
        }
    }
}
