using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using WinFormsApp.DB;
using WinFormsApp.Domain;

namespace WinFormsApp
{
    public partial class Library : Form
    {
        private Form _form;
        public Library(Form form)
        {
            InitializeComponent();
            _form = form;
            _form.Hide();
        }

        private void updateUserList(List<Book> selection)
        {
            lbUserLibrary.DataSource = null;
            lbUserLibrary.DataSource = selection;
        }

        private void onLibraryLoad(object sender, EventArgs e)
        {
            btReturnBook.Visible = false;
            updateUserList(BookCollection._data.Values.ToList());
        }

        private void onLibraryClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btRentBook.Visible = true;
            btReturnBook.Visible = false;
            updateUserList(BookCollection._data.Values.ToList());
        }

        private void onRentedClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btRentBook.Visible = false;
            btReturnBook.Visible = true;
            updateUserList(ActiveUser._user._rentedBooks);
        }

        private void onSelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = lbUserLibrary.SelectedItem;

            if(selectedItem != null && selectedItem is Book selectedBook)
            {
                btRentBook.Enabled = selectedBook._isAvailable;

                if (ActiveUser._user._rentedBooks.Find(book => book._title == selectedBook._title) != null)
                    btReturnBook.Enabled = true;
            }
        }

        private void onRentBook(object sender, EventArgs e)
        {
            Book selectedBook = (Book)lbUserLibrary.SelectedItem;

            if (selectedBook._isAvailable)
            {
                Book bookToRent;
                BookCollection._data.TryGetValue(((Book)lbUserLibrary.SelectedItem)._title, out bookToRent);

                if (bookToRent != null)
                {
                    bookToRent._isAvailable = false;
                    ActiveUser._user._rentedBooks.Add(new Book(bookToRent));
                    updateUserList(BookCollection._data.Values.ToList());

                    MessageBox.Show($"You've rented a book!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            updateUserList(BookCollection._data.Values.ToList());
        }

        private void onReturnBook(object sender, EventArgs e)
        {
            Book selectedItem;

            ActiveUser._user._rentedBooks.Remove((Book)lbUserLibrary.SelectedItem);

            BookCollection._data.TryGetValue(((Book)lbUserLibrary.SelectedItem)._title, out selectedItem);

            selectedItem._isAvailable = true;

            updateUserList(ActiveUser._user._rentedBooks);
        }

        private void onLibraryClosing(object sender, FormClosingEventArgs e)
        {
            UsersDB.Save();
            BooksDB.Save();
        }
    }
}
