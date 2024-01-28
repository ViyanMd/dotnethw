namespace WinFormsApp
{
    partial class Library
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
            lbUserLibrary = new ListBox();
            linkLibrary = new LinkLabel();
            linkRented = new LinkLabel();
            btReturnBook = new Button();
            btRentBook = new Button();
            SuspendLayout();
            // 
            // lbUserLibrary
            // 
            lbUserLibrary.Font = new Font("Century Gothic", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserLibrary.FormattingEnabled = true;
            lbUserLibrary.ItemHeight = 17;
            lbUserLibrary.Location = new Point(-1, 37);
            lbUserLibrary.Name = "lbUserLibrary";
            lbUserLibrary.Size = new Size(724, 463);
            lbUserLibrary.Sorted = true;
            lbUserLibrary.TabIndex = 0;
            lbUserLibrary.SelectedValueChanged += onSelectedValueChanged;
            // 
            // linkLibrary
            // 
            linkLibrary.AutoSize = true;
            linkLibrary.Location = new Point(14, 9);
            linkLibrary.Name = "linkLibrary";
            linkLibrary.Size = new Size(57, 20);
            linkLibrary.TabIndex = 1;
            linkLibrary.TabStop = true;
            linkLibrary.Text = "Library";
            linkLibrary.LinkClicked += onLibraryClicked;
            // 
            // linkRented
            // 
            linkRented.AutoSize = true;
            linkRented.Location = new Point(97, 9);
            linkRented.Name = "linkRented";
            linkRented.Size = new Size(62, 20);
            linkRented.TabIndex = 2;
            linkRented.TabStop = true;
            linkRented.Text = "Rented";
            linkRented.LinkClicked += onRentedClicked;
            // 
            // btReturnBook
            // 
            btReturnBook.Enabled = false;
            btReturnBook.Location = new Point(557, 513);
            btReturnBook.Margin = new Padding(10);
            btReturnBook.Name = "btReturnBook";
            btReturnBook.Size = new Size(145, 48);
            btReturnBook.TabIndex = 3;
            btReturnBook.Text = "Return";
            btReturnBook.UseVisualStyleBackColor = true;
            btReturnBook.Click += onReturnBook;
            // 
            // btRentBook
            // 
            btRentBook.Enabled = false;
            btRentBook.Location = new Point(557, 513);
            btRentBook.Margin = new Padding(10);
            btRentBook.Name = "btRentBook";
            btRentBook.Size = new Size(145, 48);
            btRentBook.TabIndex = 4;
            btRentBook.Text = "Rent";
            btRentBook.UseVisualStyleBackColor = true;
            btRentBook.Click += onRentBook;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 578);
            Controls.Add(btRentBook);
            Controls.Add(btReturnBook);
            Controls.Add(linkRented);
            Controls.Add(linkLibrary);
            Controls.Add(lbUserLibrary);
            Font = new Font("Century Gothic", 9.818182F);
            Name = "Library";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            FormClosing += onLibraryClosing;
            Load += onLibraryLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbUserLibrary;
        private LinkLabel linkLibrary;
        private LinkLabel linkRented;
        private Button btReturnBook;
        private Button btRentBook;
    }
}