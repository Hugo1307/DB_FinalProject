using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FinalProject.Utils
{
    public class BillEntity
    {

        private int id;
        private string category;
        private string name;
        private string address;
        private string email;

        public BillEntity(int id, string category, string name, string address, string email)
        {
            this.id = id;
            this.category = category;
            this.name = name;
            this.address = address;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Category { get => category; set => category = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

    }
}
