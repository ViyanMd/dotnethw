using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.CompilerServices;
using WinFormsApp.Domain;

namespace WinFormsApp.DB
{
    internal static class Users
    {
        private static string _filePath = "Users.xml";
        public static void Initialize()
        {
            if (!File.Exists(_filePath))
            {
                // If the file doesn't exist, create a new XML document
                CreateNewXmlDocument();
                Console.WriteLine("New XML document created.");
            }
            else
            {
                // If the file already exists, you can choose to do something else or just notify the user
                Console.WriteLine("XML document already exists.");
            }
        }
        public static void CreateNewXmlDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();

            // Create the root element
            XmlElement rootElement = xmlDoc.CreateElement("Users");
            xmlDoc.AppendChild(rootElement);

            // Save the XML document to the specified file
            xmlDoc.Save(_filePath);
        }

        static void Add(User newUser)
        {
            // Load the existing XML document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_filePath);


            // Serialize the User object to XML
            XmlSerializer serializer = new XmlSerializer(typeof(User));
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, newUser);
            string serializedUser = stringWriter.ToString();

            // Create a new User element and append the serialized XML to it
            XmlElement userElement = xmlDoc.CreateElement("User");
            userElement.InnerXml = serializedUser;

            // Append the User element to the "Users" root element
            XmlElement rootElement = xmlDoc.DocumentElement;
            rootElement.AppendChild(userElement);

            // Save the modified XML document
            xmlDoc.Save(_filePath);
        }

        static void ReadXmlFile(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNode rootElement = xmlDoc.SelectSingleNode("Users");

            if (rootElement != null)
            {
                foreach (XmlNode userNode in rootElement.ChildNodes)
                {
                    string username = userNode.SelectSingleNode("Username").InnerText;
                    string email = userNode.SelectSingleNode("Email").InnerText;

                    Console.WriteLine($"Username: {username}, Email: {email}");
                }
            }
            else
            {
                Console.WriteLine("Root element 'Users' not found.");
            }
        }
    }
}
