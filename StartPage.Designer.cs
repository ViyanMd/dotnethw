namespace WinFormsApp
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUsername = new Label();
            lbUserPass = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            linkRegister = new LinkLabel();
            btLogIn = new Button();
            btQuitStartPage = new Button();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Century Gothic", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(93, 71);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(83, 20);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbUserPass
            // 
            lbUserPass.AutoSize = true;
            lbUserPass.Font = new Font("Century Gothic", 9.818182F);
            lbUserPass.Location = new Point(93, 125);
            lbUserPass.Name = "lbUserPass";
            lbUserPass.Size = new Size(79, 20);
            lbUserPass.TabIndex = 1;
            lbUserPass.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Century Gothic", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(205, 65);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(187, 25);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Century Gothic", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(205, 119);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(187, 25);
            tbPassword.TabIndex = 3;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Century Gothic", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegister.Location = new Point(264, 255);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(62, 19);
            linkRegister.TabIndex = 4;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.Click += onRegisterClicked;
            // 
            // btLogIn
            // 
            btLogIn.Font = new Font("Century Gothic", 9.163636F);
            btLogIn.Location = new Point(205, 170);
            btLogIn.Name = "btLogIn";
            btLogIn.Size = new Size(187, 30);
            btLogIn.TabIndex = 5;
            btLogIn.Text = "Log In";
            btLogIn.UseVisualStyleBackColor = true;
            btLogIn.Click += onLogInClicked;
            // 
            // btQuitStartPage
            // 
            btQuitStartPage.Font = new Font("Century Gothic", 9.163636F);
            btQuitStartPage.Location = new Point(205, 206);
            btQuitStartPage.Name = "btQuitStartPage";
            btQuitStartPage.Size = new Size(187, 30);
            btQuitStartPage.TabIndex = 6;
            btQuitStartPage.Text = "Quit";
            btQuitStartPage.UseVisualStyleBackColor = true;
            btQuitStartPage.Click += onQuitStartPage;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 329);
            Controls.Add(btQuitStartPage);
            Controls.Add(btLogIn);
            Controls.Add(linkRegister);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbUserPass);
            Controls.Add(lbUsername);
            Font = new Font("Century Gothic", 9.818182F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbUserPass;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private LinkLabel linkRegister;
        private Button btLogIn;
        private Button btQuitStartPage;
    }
}
