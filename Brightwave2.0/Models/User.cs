using System;
using SQLite;

namespace Brightwave2.Models
{
    public class User
    {
        [PrimaryKey]
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        public User() { }
        public User(string user, string password)
        {
            this.user = user;
            this.password = password;

        }

        public bool CheckInfo()
        {
            if (!this.user.Equals("") && !this.password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
