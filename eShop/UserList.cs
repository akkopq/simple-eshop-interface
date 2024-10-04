using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eShop
{
    public class UserList
    {
        public List<User> Users;

        public UserList()
        {
            Users = new List<User>();
        }

        public void Add(User user)
        {
            if (!Users.Contains(user))
            {
                Users.Add(user);
            }
        }

        public void Remove(User user)
        {
            if (Users.Contains(user))
            {
                Users.Remove(user);
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (User user in Users)
            {
                result = result + user.ToString() + Environment.NewLine;
            }
            return result;
        }

        public User GetByUser(string id)
        {
            foreach (User c in Users)
            {
                if (c.UserName == id)
                {
                    return c;
                }
            }
            return null;
        }

        public User GetByPass(string id)
        {
            foreach (User c in Users)
            {
                if (c.Password == id)
                {
                    return c;
                }
            }
            return null;
        }

        public void SaveUser()
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            var jsonText = JsonConvert.SerializeObject(Users);

            File.WriteAllText(Path.Combine(filePath, "UserList.json"), jsonText);
        }

        public void LoadUser()
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];
            string jsonFilePath = Path.Combine(filePath, "UserList.json");

            if (!File.Exists(jsonFilePath))
            {
                return;
            }

            Users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(jsonFilePath));
        }
    }
}
