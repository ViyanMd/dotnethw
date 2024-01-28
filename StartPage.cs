using WinFormsApp.DB;
using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void onStartPageLoad(object sender, EventArgs e)
        {
            UsersDB.Load();
            BooksDB.Load();
        }
        private void onLogInClicked(object sender, EventArgs e)
        {
            var username = tbUsername.Text;
            var userPass = tbPassword.Text;

            var libUser = UserCollection.AuthorizeUser(username, userPass);

            if (libUser != null)
            {
                ActiveUser.Set(libUser);
                if (libUser._isAdmin)
                {
                    var adminPanel = new AdminPanel(this);
                    adminPanel.ShowDialog();
                }
                else
                {
                    var library = new Library(this);
                    library.ShowDialog();
                }

                this.Close();
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
