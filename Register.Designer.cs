namespace WinFormsApp
{
    partial class Register
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
            lbRegisterFirstName = new Label();
            lbRegisterLastName = new Label();
            lbRegisterUsername = new Label();
            lbRegisterDateOfBirth = new Label();
            lbRegisterEmail = new Label();
            dtpRegisterAge = new DateTimePicker();
            tbRegisterFirstName = new TextBox();
            tbRegisterLastName = new TextBox();
            tbRegisterUserName = new TextBox();
            tbRegisterEmail = new TextBox();
            btRegister = new Button();
            linkHaveAnAccount = new LinkLabel();
            tbRegisterRepeatPassword = new TextBox();
            tbRegisterPassword = new TextBox();
            lbRegisterRepeatPassword = new Label();
            lbRegisterPassword = new Label();
            SuspendLayout();
            // 
            // lbRegisterFirstName
            // 
            lbRegisterFirstName.AutoSize = true;
            lbRegisterFirstName.Font = new Font("Century Gothic", 9.818182F);
            lbRegisterFirstName.Location = new Point(223, 117);
            lbRegisterFirstName.Name = "lbRegisterFirstName";
            lbRegisterFirstName.Size = new Size(81, 20);
            lbRegisterFirstName.TabIndex = 0;
            lbRegisterFirstName.Text = "First name";
            // 
            // lbRegisterLastName
            // 
            lbRegisterLastName.AutoSize = true;
            lbRegisterLastName.Font = new Font("Century Gothic", 9.818182F);
            lbRegisterLastName.Location = new Point(223, 149);
            lbRegisterLastName.Name = "lbRegisterLastName";
            lbRegisterLastName.Size = new Size(83, 20);
            lbRegisterLastName.TabIndex = 1;
            lbRegisterLastName.Text = "Last name";
            // 
            // lbRegisterUsername
            // 
            lbRegisterUsername.AutoSize = true;
            lbRegisterUsername.Font = new Font("Century Gothic", 9.818182F);
            lbRegisterUsername.Location = new Point(223, 181);
            lbRegisterUsername.Name = "lbRegisterUsername";
            lbRegisterUsername.Size = new Size(83, 20);
            lbRegisterUsername.TabIndex = 2;
            lbRegisterUsername.Text = "Username";
            // 
            // lbRegisterDateOfBirth
            // 
            lbRegisterDateOfBirth.AutoSize = true;
            lbRegisterDateOfBirth.Font = new Font("Century Gothic", 9.818182F);
            lbRegisterDateOfBirth.Location = new Point(223, 303);
            lbRegisterDateOfBirth.Name = "lbRegisterDateOfBirth";
            lbRegisterDateOfBirth.Size = new Size(100, 20);
            lbRegisterDateOfBirth.TabIndex = 3;
            lbRegisterDateOfBirth.Text = "Date of birth";
            // 
            // lbRegisterEmail
            // 
            lbRegisterEmail.AutoSize = true;
            lbRegisterEmail.Font = new Font("Century Gothic", 9.818182F);
            lbRegisterEmail.Location = new Point(223, 277);
            lbRegisterEmail.Name = "lbRegisterEmail";
            lbRegisterEmail.Size = new Size(46, 20);
            lbRegisterEmail.TabIndex = 4;
            lbRegisterEmail.Text = "Email";
            // 
            // dtpRegisterAge
            // 
            dtpRegisterAge.Location = new Point(371, 303);
            dtpRegisterAge.Name = "dtpRegisterAge";
            dtpRegisterAge.Size = new Size(229, 26);
            dtpRegisterAge.TabIndex = 5;
            // 
            // tbRegisterFirstName
            // 
            tbRegisterFirstName.Location = new Point(371, 111);
            tbRegisterFirstName.Name = "tbRegisterFirstName";
            tbRegisterFirstName.Size = new Size(229, 26);
            tbRegisterFirstName.TabIndex = 6;
            // 
            // tbRegisterLastName
            // 
            tbRegisterLastName.Location = new Point(371, 143);
            tbRegisterLastName.Name = "tbRegisterLastName";
            tbRegisterLastName.Size = new Size(229, 26);
            tbRegisterLastName.TabIndex = 7;
            // 
            // tbRegisterUserName
            // 
            tbRegisterUserName.Location = new Point(371, 175);
            tbRegisterUserName.Name = "tbRegisterUserName";
            tbRegisterUserName.Size = new Size(229, 26);
            tbRegisterUserName.TabIndex = 8;
            // 
            // tbRegisterEmail
            // 
            tbRegisterEmail.Location = new Point(371, 271);
            tbRegisterEmail.Name = "tbRegisterEmail";
            tbRegisterEmail.Size = new Size(229, 26);
            tbRegisterEmail.TabIndex = 9;
            // 
            // btRegister
            // 
            btRegister.Font = new Font("Century Gothic", 9.163636F);
            btRegister.Location = new Point(413, 351);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(187, 30);
            btRegister.TabIndex = 10;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += onRegister;
            // 
            // linkHaveAnAccount
            // 
            linkHaveAnAccount.AutoSize = true;
            linkHaveAnAccount.Location = new Point(282, 426);
            linkHaveAnAccount.Name = "linkHaveAnAccount";
            linkHaveAnAccount.Size = new Size(235, 19);
            linkHaveAnAccount.TabIndex = 11;
            linkHaveAnAccount.TabStop = true;
            linkHaveAnAccount.Text = "Already have an account ? Click here.";
            linkHaveAnAccount.MouseClick += onHaveAnAccountClick;
            // 
            // tbRegisterRepeatPassword
            // 
            tbRegisterRepeatPassword.Location = new Point(371, 239);
            tbRegisterRepeatPassword.Name = "tbRegisterRepeatPassword";
            tbRegisterRepeatPassword.Size = new Size(229, 26);
            tbRegisterRepeatPassword.TabIndex = 15;
            // 
            // tbRegisterPassword
            // 
            tbRegisterPassword.Location = new Point(371, 207);
            tbRegisterPassword.Name = "tbRegisterPassword";
            tbRegisterPassword.Size = new Size(229, 26);
            tbRegisterPassword.TabIndex = 14;
            // 
            // lbRegisterRepeatPassword
            // 
            lbRegisterRepeatPassword.AutoSize = true;
            lbRegisterRepeatPassword.Font = new Font("Century Gothic", 9.818182F);
            lbRegisterRepeatPassword.Location = new Point(223, 245);
            lbRegisterRepeatPassword.Name = "lbRegisterRepeatPassword";
            lbRegisterRepeatPassword.Size = new Size(137, 20);
            lbRegisterRepeatPassword.TabIndex = 13;
            lbRegisterRepeatPassword.Text = "Repeat Password";
            // 
            // lbRegisterPassword
            // 
            lbRegisterPassword.AutoSize = true;
            lbRegisterPassword.Font = new Font("Century Gothic", 9.818182F);
            lbRegisterPassword.Location = new Point(223, 213);
            lbRegisterPassword.Name = "lbRegisterPassword";
            lbRegisterPassword.Size = new Size(79, 20);
            lbRegisterPassword.TabIndex = 12;
            lbRegisterPassword.Text = "Password";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(tbRegisterRepeatPassword);
            Controls.Add(tbRegisterPassword);
            Controls.Add(lbRegisterRepeatPassword);
            Controls.Add(lbRegisterPassword);
            Controls.Add(linkHaveAnAccount);
            Controls.Add(btRegister);
            Controls.Add(tbRegisterEmail);
            Controls.Add(tbRegisterUserName);
            Controls.Add(tbRegisterLastName);
            Controls.Add(tbRegisterFirstName);
            Controls.Add(dtpRegisterAge);
            Controls.Add(lbRegisterEmail);
            Controls.Add(lbRegisterDateOfBirth);
            Controls.Add(lbRegisterUsername);
            Controls.Add(lbRegisterLastName);
            Controls.Add(lbRegisterFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRegisterFirstName;
        private Label lbRegisterLastName;
        private Label lbRegisterUsername;
        private Label lbRegisterDateOfBirth;
        private Label lbRegisterEmail;
        private DateTimePicker dtpRegisterAge;
        private TextBox tbRegisterFirstName;
        private TextBox tbRegisterLastName;
        private TextBox tbRegisterUserName;
        private TextBox tbRegisterEmail;
        private Button btRegister;
        private LinkLabel linkHaveAnAccount;
        private TextBox tbRegisterRepeatPassword;
        private TextBox tbRegisterPassword;
        private Label lbRegisterRepeatPassword;
        private Label lbRegisterPassword;
    }
}