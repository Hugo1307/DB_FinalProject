using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FinalProject.Utils
{
    public class User
    {
        private string name;
        private string email;
        private string password;
        private string imagePath;

        public User(string name, string email, string password, string imagePath)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.imagePath = imagePath;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
    }

}
