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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void onRegister(object sender, EventArgs e)
        {
            try 
            {
                if (String.IsNullOrEmpty(tbRegisterFirstName.Text)) throw new Exception("First name can't be empty!");
                if (String.IsNullOrEmpty(tbRegisterLastName.Text)) throw new Exception("Last name can't be empty!");
                if (String.IsNullOrEmpty(tbRegisterUserName.Text)) throw new Exception("Username can't be empty!");
                if (String.IsNullOrEmpty(tbRegisterPassword.Text))  throw new Exception("Password can't be empty");
                if (String.IsNullOrEmpty(tbRegisterRepeatPassword.Text)) throw new Exception("Please, repeat password!");
                if (tbRegisterPassword.Text != tbRegisterRepeatPassword.Text) throw new Exception("Passwords don't match!");
                if (dtpRegisterAge.Value.Year > DateTime.Now.Year) throw new Exception("Birth date can't be in the future!");
                if (DateTime.Now.Year - dtpRegisterAge.Value.Year < 12) throw new Exception("You have to be older than 12!");

                var newUser = new User(tbRegisterFirstName.Text, tbRegisterLastName.Text, tbRegisterUserName.Text, tbRegisterPassword.Text, dtpRegisterAge.Value, tbRegisterEmail.Text);
                UserCollection._data.Add(newUser._username, newUser);
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onHaveAnAccountClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


    }
}
