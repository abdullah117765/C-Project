using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2._0.backend
{

    [Serializable]
    internal class User
    {

        private string username;
        private string password;
        private string email;
        private string name;


        public User(string username1, string password1, string email1, string name1)
        {
            username = username1;
            password = password1;
            email = email1;
            name = name1;

        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }



       





    }
}
