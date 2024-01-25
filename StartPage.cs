using WinFormsApp.DB;
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
            //UsersDB.Load();
        }
        private void onLogInClicked(object sender, EventArgs e)
        {
            var username = tbUsername.Text;
            var userPass = tbPassword.Text;

            var libUser = UsersDB.AuthorizeUser(username, userPass);

            if (libUser != null)
            {
                activeUser = libUser;
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
