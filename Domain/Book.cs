using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    [Serializable]
    public class Book
    {
        public string _title { get; set; }
        public string _author { get; set; }
        public string _year { get; set; }
        public string _genre { get; set; }
        public string _ISBN { get; set; }
        public bool _isAvailable { get; set; }


        public Book() 
        {
            _title = string.Empty;
            _author = string.Empty;
            _year = string.Empty;
            _genre = string.Empty;
            _ISBN = string.Empty;
            _isAvailable = false;
        }
        public Book(Book existingBook)
        {
            _title = existingBook._title;
            _author = existingBook._author;
            _year = existingBook._year;
            _genre = existingBook._genre;
            _ISBN = existingBook._ISBN;
            _isAvailable = existingBook._isAvailable;
        }
        public Book(string title, string author, string genre, string ISBN,bool available = true, string year = "")
        {
            _title = title.Trim();
            _author = author.Trim();
            _year = year.Trim();
            _genre = genre.Trim();
            _ISBN = ISBN.Trim();
            _isAvailable = available;
        }

        public override string ToString()
        {
            return $"'{_title}' by {_author}, {_year}, {_genre}, {(ActiveUser._user._isAdmin ? _ISBN : ' ')}  |  {(_isAvailable ? "Available" : "Out of stock")}";
        }
    }
}
