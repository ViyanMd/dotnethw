namespace WinFormsApp
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void onLogInClicked(object sender, EventArgs e)
        {

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
