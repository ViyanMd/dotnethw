using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp.Domain
{
    internal static class UserCollection
    {

        public static Dictionary<string, User> _data = new Dictionary<string, User>();

        public static User AuthorizeUser(string username, string pass)
        {
            User authorizedUser;

            if (_data.TryGetValue(username, out authorizedUser))
                if (authorizedUser._password == pass)
                    return authorizedUser;
                else
                    return null;

            return null;
        }
        public static List<User> ToList()
        {
            var listOfUsers = new List<User>();

            if (_data.Values.Count != 0)
            {
                foreach (var user in _data.Values)
                {
                    listOfUsers.Add(user);
                }
            }
            else
            {
                listOfUsers = null;
            }

            return listOfUsers;
        }
    }
}
