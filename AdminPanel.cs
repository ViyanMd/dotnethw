using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void onAdminPanelLoad(object sender, EventArgs e)
        {
            updateUsersCollection();
            updateBookCollection();
        }
        private void updateUsersCollection()
        {
            lbUsers = null;
            lbUsers.DataSource = UserCollection.ToList();
            lbUsers.Update();
        }

        private void updateBookCollection()
        {
            lbBooksCollection = null;
            lbBooksCollection.DataSource = BookCollection.ToList();
            lbBooksCollection.Update();
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
    }
}
