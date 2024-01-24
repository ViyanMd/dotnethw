using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    internal static class BookCollection
    {
        public static Dictionary<string, Book> _data = new Dictionary<string, Book>();

        public static List<Book> ToList()
        {
            var listOfBooks = new List<Book>();

            if (_data.Values.Count != 0)
            {
                foreach (var book in _data.Values)
                {
                    listOfBooks.Add(book);
                }
            } else
            {
                listOfBooks = null;
            }

            return listOfBooks;
        }
    }
}
