using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    [Serializable]
    public class User
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        public DateTime _dateOfBirth { get; set; }
        public int _age { get; set; }
        public string? _email { get; set; }
        public bool _isAdmin { get; set; }

        public User() 
        {
            _firstName = string.Empty;
            _lastName = string.Empty;   
            _username = string.Empty;
            _password = string.Empty;
            _dateOfBirth = DateTime.MinValue;
            _age = 0;
            _email = string.Empty;
            _isAdmin = false;
        }
        public User(string firstName, string lastName, string username, string password, DateTime dateOfBirth, string email = "")
        {
            _firstName = firstName;
            _lastName = lastName;
            _username = username;
            _password = password;
            _dateOfBirth = dateOfBirth;
            _age = DateTime.Now.Year - dateOfBirth.Year;
            _email = email;
            _isAdmin = true;
        }
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}  |  Username: {_username}  |  Age: {_age}, Email: {_email}";
        }
    }
}
