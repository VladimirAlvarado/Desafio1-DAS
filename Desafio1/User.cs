using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    public class User
    {
        public string UserName { get; }
        public string Password { get; }
        public string Theme { get; }


        public User(string userName, string password, string theme)
        {
            UserName = userName;
            Password = password;
            Theme = theme;
        }
    }
}
