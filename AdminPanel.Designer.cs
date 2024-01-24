namespace WinFormsApp
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcAdminPanel = new TabControl();
            tpUsers = new TabPage();
            linkAllUsers = new LinkLabel();
            btDeleteUser = new Button();
            btViewUserActivity = new Button();
            lbUsers = new ListBox();
            tpLibrary = new TabPage();
            btAdminAddBook = new Button();
            lbAdminSearch = new Button();
            tbAdminSearch = new TextBox();
            tbNBISBN = new TextBox();
            tbNBYear = new TextBox();
            tbNBAuthor = new TextBox();
            tbNBTitle = new TextBox();
            cbNBGenre = new ComboBox();
            lbBookISBN = new Label();
            lbBookYear = new Label();
            lbBookGenre = new Label();
            lbBookAuthor = new Label();
            lbBookTitle = new Label();
            lbBooksCollection = new ListBox();
            tcAdminPanel.SuspendLayout();
            tpUsers.SuspendLayout();
            tpLibrary.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdminPanel
            // 
            tcAdminPanel.Controls.Add(tpUsers);
            tcAdminPanel.Controls.Add(tpLibrary);
            tcAdminPanel.Font = new Font("Century Gothic", 9.818182F);
            tcAdminPanel.Location = new Point(-5, -1);
            tcAdminPanel.Name = "tcAdminPanel";
            tcAdminPanel.SelectedIndex = 0;
            tcAdminPanel.Size = new Size(808, 458);
            tcAdminPanel.TabIndex = 0;
            // 
            // tpUsers
            // 
            tpUsers.Controls.Add(linkAllUsers);
            tpUsers.Controls.Add(btDeleteUser);
            tpUsers.Controls.Add(btViewUserActivity);
            tpUsers.Controls.Add(lbUsers);
            tpUsers.Location = new Point(4, 29);
            tpUsers.Name = "tpUsers";
            tpUsers.Padding = new Padding(3);
            tpUsers.Size = new Size(800, 425);
            tpUsers.TabIndex = 0;
            tpUsers.Text = "Users";
            tpUsers.UseVisualStyleBackColor = true;
            // 
            // linkAllUsers
            // 
            linkAllUsers.Anchor = AnchorStyles.None;
            linkAllUsers.AutoSize = true;
            linkAllUsers.Location = new Point(9, 18);
            linkAllUsers.Name = "linkAllUsers";
            linkAllUsers.Size = new Size(68, 20);
            linkAllUsers.TabIndex = 3;
            linkAllUsers.TabStop = true;
            linkAllUsers.Text = "All Users";
            linkAllUsers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btDeleteUser
            // 
            btDeleteUser.FlatStyle = FlatStyle.Flat;
            btDeleteUser.Location = new Point(659, 362);
            btDeleteUser.Name = "btDeleteUser";
            btDeleteUser.Size = new Size(124, 47);
            btDeleteUser.TabIndex = 2;
            btDeleteUser.Text = "Delete";
            btDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btViewUserActivity
            // 
            btViewUserActivity.FlatStyle = FlatStyle.Flat;
            btViewUserActivity.Location = new Point(529, 362);
            btViewUserActivity.Name = "btViewUserActivity";
            btViewUserActivity.Size = new Size(124, 47);
            btViewUserActivity.TabIndex = 1;
            btViewUserActivity.Text = "Select";
            btViewUserActivity.UseVisualStyleBackColor = true;
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 20;
            lbUsers.Location = new Point(9, 41);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(774, 304);
            lbUsers.TabIndex = 0;
            // 
            // tpLibrary
            // 
            tpLibrary.Controls.Add(btAdminAddBook);
            tpLibrary.Controls.Add(lbAdminSearch);
            tpLibrary.Controls.Add(tbAdminSearch);
            tpLibrary.Controls.Add(tbNBISBN);
            tpLibrary.Controls.Add(tbNBYear);
            tpLibrary.Controls.Add(tbNBAuthor);
            tpLibrary.Controls.Add(tbNBTitle);
            tpLibrary.Controls.Add(cbNBGenre);
            tpLibrary.Controls.Add(lbBookISBN);
            tpLibrary.Controls.Add(lbBookYear);
            tpLibrary.Controls.Add(lbBookGenre);
            tpLibrary.Controls.Add(lbBookAuthor);
            tpLibrary.Controls.Add(lbBookTitle);
            tpLibrary.Controls.Add(lbBooksCollection);
            tpLibrary.Location = new Point(4, 29);
            tpLibrary.Name = "tpLibrary";
            tpLibrary.Padding = new Padding(3);
            tpLibrary.Size = new Size(800, 425);
            tpLibrary.TabIndex = 1;
            tpLibrary.Text = "Library";
            tpLibrary.UseVisualStyleBackColor = true;
            // 
            // btAdminAddBook
            // 
            btAdminAddBook.Location = new Point(76, 287);
            btAdminAddBook.Name = "btAdminAddBook";
            btAdminAddBook.Size = new Size(257, 32);
            btAdminAddBook.TabIndex = 13;
            btAdminAddBook.Text = "Add Book";
            btAdminAddBook.UseVisualStyleBackColor = true;
            btAdminAddBook.Click += onAdminAddBook;
            // 
            // lbAdminSearch
            // 
            lbAdminSearch.Location = new Point(666, 29);
            lbAdminSearch.Name = "lbAdminSearch";
            lbAdminSearch.Size = new Size(121, 33);
            lbAdminSearch.TabIndex = 12;
            lbAdminSearch.Text = "Search";
            lbAdminSearch.UseVisualStyleBackColor = true;
            // 
            // tbAdminSearch
            // 
            tbAdminSearch.Location = new Point(410, 32);
            tbAdminSearch.Name = "tbAdminSearch";
            tbAdminSearch.PlaceholderText = "ex. \"Bible\"";
            tbAdminSearch.Size = new Size(246, 26);
            tbAdminSearch.TabIndex = 11;
            // 
            // tbNBISBN
            // 
            tbNBISBN.Location = new Point(144, 234);
            tbNBISBN.Margin = new Padding(6);
            tbNBISBN.Name = "tbNBISBN";
            tbNBISBN.Size = new Size(215, 26);
            tbNBISBN.TabIndex = 10;
            // 
            // tbNBYear
            // 
            tbNBYear.Location = new Point(144, 196);
            tbNBYear.Margin = new Padding(6);
            tbNBYear.Name = "tbNBYear";
            tbNBYear.Size = new Size(215, 26);
            tbNBYear.TabIndex = 9;
            // 
            // tbNBAuthor
            // 
            tbNBAuthor.Location = new Point(144, 118);
            tbNBAuthor.Margin = new Padding(6);
            tbNBAuthor.Name = "tbNBAuthor";
            tbNBAuthor.Size = new Size(215, 26);
            tbNBAuthor.TabIndex = 8;
            // 
            // tbNBTitle
            // 
            tbNBTitle.Location = new Point(144, 80);
            tbNBTitle.Margin = new Padding(6);
            tbNBTitle.Name = "tbNBTitle";
            tbNBTitle.Size = new Size(215, 26);
            tbNBTitle.TabIndex = 7;
            // 
            // cbNBGenre
            // 
            cbNBGenre.FormattingEnabled = true;
            cbNBGenre.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Romance", "Thriller", "Fantasy", "Horror", "Poetry", "Children", "Historical", "Finance", "Biography" });
            cbNBGenre.Location = new Point(144, 156);
            cbNBGenre.Margin = new Padding(6);
            cbNBGenre.Name = "cbNBGenre";
            cbNBGenre.Size = new Size(215, 28);
            cbNBGenre.TabIndex = 6;
            // 
            // lbBookISBN
            // 
            lbBookISBN.AutoSize = true;
            lbBookISBN.Location = new Point(52, 240);
            lbBookISBN.Name = "lbBookISBN";
            lbBookISBN.Size = new Size(41, 20);
            lbBookISBN.TabIndex = 5;
            lbBookISBN.Text = "ISBN";
            // 
            // lbBookYear
            // 
            lbBookYear.AutoSize = true;
            lbBookYear.Location = new Point(52, 202);
            lbBookYear.Name = "lbBookYear";
            lbBookYear.Size = new Size(41, 20);
            lbBookYear.TabIndex = 4;
            lbBookYear.Text = "Year";
            // 
            // lbBookGenre
            // 
            lbBookGenre.AutoSize = true;
            lbBookGenre.Location = new Point(52, 164);
            lbBookGenre.Name = "lbBookGenre";
            lbBookGenre.Size = new Size(56, 20);
            lbBookGenre.TabIndex = 3;
            lbBookGenre.Text = "Genre";
            // 
            // lbBookAuthor
            // 
            lbBookAuthor.AutoSize = true;
            lbBookAuthor.Location = new Point(50, 124);
            lbBookAuthor.Name = "lbBookAuthor";
            lbBookAuthor.Size = new Size(58, 20);
            lbBookAuthor.TabIndex = 2;
            lbBookAuthor.Text = "Author";
            // 
            // lbBookTitle
            // 
            lbBookTitle.AutoSize = true;
            lbBookTitle.Location = new Point(52, 86);
            lbBookTitle.Name = "lbBookTitle";
            lbBookTitle.Size = new Size(35, 20);
            lbBookTitle.TabIndex = 1;
            lbBookTitle.Text = "Title";
            // 
            // lbBooksCollection
            // 
            lbBooksCollection.BorderStyle = BorderStyle.None;
            lbBooksCollection.FormattingEnabled = true;
            lbBooksCollection.ItemHeight = 20;
            lbBooksCollection.Location = new Point(410, 80);
            lbBooksCollection.Name = "lbBooksCollection";
            lbBooksCollection.Size = new Size(387, 340);
            lbBooksCollection.TabIndex = 0;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(tcAdminPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminPanel";
            Text = "AdminPanel";
            Load += onAdminPanelLoad;
            tcAdminPanel.ResumeLayout(false);
            tpUsers.ResumeLayout(false);
            tpUsers.PerformLayout();
            tpLibrary.ResumeLayout(false);
            tpLibrary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdminPanel;
        private TabPage tpUsers;
        private TabPage tpLibrary;
        private Button btDeleteUser;
        private Button btViewUserActivity;
        private ListBox lbUsers;
        private LinkLabel linkAllUsers;
        private Label lbBookTitle;
        private ListBox lbBooksCollection;
        private Label lbBookISBN;
        private Label lbBookYear;
        private Label lbBookGenre;
        private Label lbBookAuthor;
        private TextBox tbNBAuthor;
        private TextBox tbNBTitle;
        private ComboBox cbNBGenre;
        private Button lbAdminSearch;
        private TextBox tbAdminSearch;
        private TextBox tbNBISBN;
        private TextBox tbNBYear;
        private Button btAdminAddBook;
    }
}