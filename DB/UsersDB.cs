using System.Xml.Linq;
using System.Xml.Serialization;
using WinFormsApp.Domain;

namespace WinFormsApp.DB
{
    internal static class UsersDB
    {
        private static string _filePath = "Users.xml";

        public static User AuthorizeUser(string username, string pass)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<User>));

            using (FileStream fReader = new FileStream(_filePath, FileMode.Open))
            {
                List<User>? usersList = formatter.Deserialize(fReader) as List<User>;

                return usersList.Find(user => user._username == username && user._password == pass);
            }

        }
        public static void Load()
        {

                XmlSerializer formatter = new XmlSerializer(typeof(List<User>));

                using (FileStream fReader = new FileStream(_filePath, FileMode.Open))
                {
                    List<User>? usersList = formatter.Deserialize(fReader) as List<User>;

                    if (usersList != null)
                        foreach (var user in usersList)
                            UserCollection._data.Add(user._username, user);
                    else
                    {
                        MessageBox.Show("list is empty!", "Error!");
                    }
                }
        }


        public static void AddUser(User newUser)
        {
            List<User> userList;

            if (File.Exists(_filePath))
            {
                using (FileStream fileStream = new FileStream(_filePath, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    userList = (List<User>)serializer.Deserialize(fileStream);
                }
            }
            else
            {
                // If the file doesn't exist, create a new list of users
                userList = new List<User>();
            }

            // Add the new user to the list
            userList.Add(newUser);

            // Serialize the updated list and write it back to the file
            using (FileStream fileStream = new FileStream(_filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                serializer.Serialize(fileStream, userList);
            }
        }

        /*   public static void Save()
           {
               using System.Xml;

               XmlDocument xDoc = new XmlDocument();
               xDoc.Load("people.xml");
               XmlElement? xRoot = xDoc.DocumentElement;

               // создаем новый элемент person
               XmlElement personElem = xDoc.CreateElement("person");

               // создаем атрибут name
               XmlAttribute nameAttr = xDoc.CreateAttribute("name");

               // создаем элементы company и age
               XmlElement companyElem = xDoc.CreateElement("company");
               XmlElement ageElem = xDoc.CreateElement("age");

               // создаем текстовые значения для элементов и атрибута
               XmlText nameText = xDoc.CreateTextNode("Mark");
               XmlText companyText = xDoc.CreateTextNode("Facebook");
               XmlText ageText = xDoc.CreateTextNode("30");

               //добавляем узлы
               nameAttr.AppendChild(nameText);
               companyElem.AppendChild(companyText);
               ageElem.AppendChild(ageText);

               // добавляем атрибут name
               personElem.Attributes.Append(nameAttr);
               // добавляем элементы company и age
               personElem.AppendChild(companyElem);
               personElem.AppendChild(ageElem);
               // добавляем в корневой элемент новый элемент person
               xRoot?.AppendChild(personElem);
               // сохраняем изменения xml-документа в файл
               xDoc.Save("people.xml");
           }
        */
    }
}
