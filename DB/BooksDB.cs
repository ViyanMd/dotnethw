using System.Xml;
using System.Xml.Serialization;
using WinFormsApp.Domain;

namespace WinFormsApp.DB
{
    internal static class BooksDB
    {
        private static string _filePath = "Books.xml";

        public static void Load()
        {
            if (!File.Exists(_filePath))
            {
                XmlDocument newDoc = new XmlDocument();
                XmlElement root = newDoc.CreateElement("ArrayOfBook");
                newDoc.AppendChild(root);
                newDoc.Save(_filePath);
            }
            else 
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));

                using (FileStream fReader = new FileStream(_filePath, FileMode.OpenOrCreate))
                {
                    List<Book>? bookList = formatter.Deserialize(fReader) as List<Book>;

                    if (bookList != null)
                        foreach (var book in bookList)
                            BookCollection._data.Add(book._title, book);
                }
            } 
        }

        public static void Save()
        {
            List<Book> listOfBooks = new List<Book>(BookCollection._data.Values.ToList());

            using (FileStream fWriter = new FileStream(_filePath, FileMode.Create))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
                formatter.Serialize(fWriter, listOfBooks);
            }
        }
    }
}
