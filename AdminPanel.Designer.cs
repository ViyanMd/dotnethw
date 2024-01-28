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
            lbUsers = new ListBox();
            tpLibrary = new TabPage();
            btAdminAddBook = new Button();
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
            tcAdminPanel.Location = new Point(-6, -1);
            tcAdminPanel.Name = "tcAdminPanel";
            tcAdminPanel.SelectedIndex = 0;
            tcAdminPanel.Size = new Size(1156, 585);
            tcAdminPanel.TabIndex = 0;
            // 
            // tpUsers
            // 
            tpUsers.Controls.Add(linkAllUsers);
            tpUsers.Controls.Add(btDeleteUser);
            tpUsers.Controls.Add(lbUsers);
            tpUsers.Location = new Point(4, 29);
            tpUsers.Name = "tpUsers";
            tpUsers.Padding = new Padding(3);
            tpUsers.Size = new Size(1148, 552);
            tpUsers.TabIndex = 0;
            tpUsers.Text = "Users";
            tpUsers.UseVisualStyleBackColor = true;
            // 
            // linkAllUsers
            // 
            linkAllUsers.Anchor = AnchorStyles.None;
            linkAllUsers.AutoSize = true;
            linkAllUsers.Location = new Point(124, 67);
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
            btDeleteUser.Location = new Point(855, 429);
            btDeleteUser.Name = "btDeleteUser";
            btDeleteUser.Size = new Size(140, 49);
            btDeleteUser.TabIndex = 2;
            btDeleteUser.Text = "Delete";
            btDeleteUser.UseVisualStyleBackColor = true;
            btDeleteUser.Click += onDeleteUser;
            // 
            // lbUsers
            // 
            lbUsers.Font = new Font("Century Gothic", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 17;
            lbUsers.Location = new Point(124, 91);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(870, 293);
            lbUsers.TabIndex = 0;
            // 
            // tpLibrary
            // 
            tpLibrary.Controls.Add(btAdminAddBook);
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
            tpLibrary.Size = new Size(1148, 552);
            tpLibrary.TabIndex = 1;
            tpLibrary.Text = "Library";
            tpLibrary.UseVisualStyleBackColor = true;
            // 
            // btAdminAddBook
            // 
            btAdminAddBook.Location = new Point(38, 302);
            btAdminAddBook.Name = "btAdminAddBook";
            btAdminAddBook.Size = new Size(289, 34);
            btAdminAddBook.TabIndex = 13;
            btAdminAddBook.Text = "Add Book";
            btAdminAddBook.UseVisualStyleBackColor = true;
            btAdminAddBook.Click += onAdminAddBook;
            // 
            // tbNBISBN
            // 
            tbNBISBN.Location = new Point(115, 246);
            tbNBISBN.Margin = new Padding(7, 6, 7, 6);
            tbNBISBN.Name = "tbNBISBN";
            tbNBISBN.Size = new Size(241, 26);
            tbNBISBN.TabIndex = 10;
            // 
            // tbNBYear
            // 
            tbNBYear.Location = new Point(115, 206);
            tbNBYear.Margin = new Padding(7, 6, 7, 6);
            tbNBYear.Name = "tbNBYear";
            tbNBYear.Size = new Size(241, 26);
            tbNBYear.TabIndex = 9;
            // 
            // tbNBAuthor
            // 
            tbNBAuthor.Location = new Point(115, 124);
            tbNBAuthor.Margin = new Padding(7, 6, 7, 6);
            tbNBAuthor.Name = "tbNBAuthor";
            tbNBAuthor.Size = new Size(241, 26);
            tbNBAuthor.TabIndex = 8;
            // 
            // tbNBTitle
            // 
            tbNBTitle.Location = new Point(115, 84);
            tbNBTitle.Margin = new Padding(7, 6, 7, 6);
            tbNBTitle.Name = "tbNBTitle";
            tbNBTitle.Size = new Size(241, 26);
            tbNBTitle.TabIndex = 7;
            // 
            // cbNBGenre
            // 
            cbNBGenre.FormattingEnabled = true;
            cbNBGenre.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Romance", "Thriller", "Fantasy", "Horror", "Poetry", "Children", "Historical", "Finance", "Biography" });
            cbNBGenre.Location = new Point(115, 164);
            cbNBGenre.Margin = new Padding(7, 6, 7, 6);
            cbNBGenre.Name = "cbNBGenre";
            cbNBGenre.Size = new Size(241, 28);
            cbNBGenre.TabIndex = 6;
            // 
            // lbBookISBN
            // 
            lbBookISBN.AutoSize = true;
            lbBookISBN.Location = new Point(11, 253);
            lbBookISBN.Name = "lbBookISBN";
            lbBookISBN.Size = new Size(41, 20);
            lbBookISBN.TabIndex = 5;
            lbBookISBN.Text = "ISBN";
            // 
            // lbBookYear
            // 
            lbBookYear.AutoSize = true;
            lbBookYear.Location = new Point(11, 213);
            lbBookYear.Name = "lbBookYear";
            lbBookYear.Size = new Size(41, 20);
            lbBookYear.TabIndex = 4;
            lbBookYear.Text = "Year";
            // 
            // lbBookGenre
            // 
            lbBookGenre.AutoSize = true;
            lbBookGenre.Location = new Point(11, 173);
            lbBookGenre.Name = "lbBookGenre";
            lbBookGenre.Size = new Size(56, 20);
            lbBookGenre.TabIndex = 3;
            lbBookGenre.Text = "Genre";
            // 
            // lbBookAuthor
            // 
            lbBookAuthor.AutoSize = true;
            lbBookAuthor.Location = new Point(9, 131);
            lbBookAuthor.Name = "lbBookAuthor";
            lbBookAuthor.Size = new Size(58, 20);
            lbBookAuthor.TabIndex = 2;
            lbBookAuthor.Text = "Author";
            // 
            // lbBookTitle
            // 
            lbBookTitle.AutoSize = true;
            lbBookTitle.Location = new Point(11, 91);
            lbBookTitle.Name = "lbBookTitle";
            lbBookTitle.Size = new Size(35, 20);
            lbBookTitle.TabIndex = 1;
            lbBookTitle.Text = "Title";
            // 
            // lbBooksCollection
            // 
            lbBooksCollection.BorderStyle = BorderStyle.None;
            lbBooksCollection.Font = new Font("Century Gothic", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBooksCollection.FormattingEnabled = true;
            lbBooksCollection.ItemHeight = 17;
            lbBooksCollection.Location = new Point(386, -1);
            lbBooksCollection.Name = "lbBooksCollection";
            lbBooksCollection.Size = new Size(766, 544);
            lbBooksCollection.TabIndex = 0;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 578);
            Controls.Add(tcAdminPanel);
            Font = new Font("Century Gothic", 9.818182F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminPanel";
            Text = "AdminPanel";
            FormClosing += onAdminPanelClosing;
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
        private TextBox tbNBISBN;
        private TextBox tbNBYear;
        private Button btAdminAddBook;
    }
}