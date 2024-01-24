using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    internal class Book
    {
        public string _title { get; set; }
        public string _author { get; set; }
        public string _year { get; set; }
        public string _genre { get; set; }
        public string _ISBN { get; set; }
        public bool _available { get; set; }


        public Book(string title, string author, string genre, string ISBN,bool available, string year = "")
        {
            _title = title;
            _author = author;
            _year = year;
            _genre = genre;
            _ISBN = ISBN;
            _available = available;
        }
    }
}
