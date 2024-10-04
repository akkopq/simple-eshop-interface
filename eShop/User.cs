using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is User)) { return false;}
            User objUser = (User)obj;
            return objUser.UserName == UserName && objUser.Password == Password;
        }
        public override string ToString()
        {
            return $"{UserName};{Password}";
        }
    }
}
