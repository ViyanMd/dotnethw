
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
        public List<Book> _rentedBooks { get; set; }

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
            _rentedBooks = new List<Book>();
        }
        public User(string firstName, string lastName, string username, string password, DateTime dateOfBirth, string email = "")
        {
            _firstName = firstName.Trim();
            _lastName = lastName.Trim();
            _username = username.Trim();
            _password = password.Trim();
            _dateOfBirth = dateOfBirth;
            _age = DateTime.Now.Year - dateOfBirth.Year;
            _email = email.Trim();
            _isAdmin = false;
            _rentedBooks = new List<Book>();
        }
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}  |  Username: {_username}  |  Age: {_age}  |  Email: {_email}  |  Rented Books: {_rentedBooks.Count}";
        }
    }
}
