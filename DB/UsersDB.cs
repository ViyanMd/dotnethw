using System.Xml;
using System.Xml.Serialization;
using WinFormsApp.Domain;

namespace WinFormsApp.DB
{
    internal static class UsersDB
    {
        private static string _filePath = "Users.xml";

        public static void Load()
        {
            if (!File.Exists(_filePath))
            {
                XmlDocument newDoc = new XmlDocument();
                XmlElement root = newDoc.CreateElement("ArrayOfUser");
                newDoc.AppendChild(root);
                newDoc.Save(_filePath);
            } else
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
                using (FileStream fReader = new FileStream(_filePath, FileMode.OpenOrCreate))
                {
                    List<User>? usersList = formatter.Deserialize(fReader) as List<User>;

                    if (usersList != null)
                        foreach (var user in usersList)
                            UserCollection._data.Add(user._username, user);
                }
            }
        }

        public static void Save() 
        {
            List<User> listOfUsers = new List<User>(UserCollection._data.Values.ToList());

            using (FileStream fWriter = new FileStream(_filePath, FileMode.Create))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
                formatter.Serialize(fWriter, listOfUsers);
            }
        }
    }
}
