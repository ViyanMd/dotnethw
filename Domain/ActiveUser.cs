using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Domain
{
    internal static class ActiveUser
    {
        public static User _user;

        public static void Set(User user)
        {
            _user = user;
        }
    }
}
