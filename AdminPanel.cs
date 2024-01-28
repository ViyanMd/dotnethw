
using WinFormsApp.DB;
using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class AdminPanel : Form
    {
        private Form _form;
        public AdminPanel(Form form)
        {
            InitializeComponent();
            _form = form;
            _form.Hide();
        }
        private void onAdminPanelLoad(object sender, EventArgs e)
        {
            updateUsersCollection();
            updateBookCollection();
        }
        private void updateUsersCollection()
        {
            lbUsers.DataSource = null;
            lbUsers.DataSource = UserCollection._data.Values.ToList();
        }

        private void updateBookCollection()
        {
            lbBooksCollection.DataSource = null;
            lbBooksCollection.DataSource = BookCollection._data.Values.ToList();
        }
        private void onAdminAddBook(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbNBTitle.Text)) throw new Exception("Name can't be empty!");
                if (String.IsNullOrEmpty(tbNBAuthor.Text)) throw new Exception("Author can't be empty!");
                if (String.IsNullOrEmpty(cbNBGenre.SelectedItem.ToString())) throw new Exception("Genre can't be empty");
                if (String.IsNullOrEmpty(tbNBISBN.Text)) throw new Exception("ISBN can't be empty");

                var newBook = new Book(tbNBTitle.Text, tbNBAuthor.Text, cbNBGenre.SelectedItem.ToString(), tbNBISBN.Text, true, tbNBYear.Text);
                BookCollection._data.Add(newBook._title, newBook);

                updateBookCollection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onAdminPanelClosing(object sender, FormClosingEventArgs e)
        {
            UsersDB.Save();
            BooksDB.Save();
        }

        private void onDeleteUser(object sender, EventArgs e)
        {
            UserCollection._data.Remove(((User)lbUsers.SelectedItem)._username);
            updateUsersCollection();
        }
    }
}
