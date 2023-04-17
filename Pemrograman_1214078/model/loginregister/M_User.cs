using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model
{
    internal class M_User
    {
        string id, username, password, role;

        public M_User()
        {

        }

        public M_User(string id, string username, string password, string role)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }

}
