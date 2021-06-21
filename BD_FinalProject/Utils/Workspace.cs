using System;

namespace BD_FinalProject.Utils
{
    public class Workspace
    {

        private int id;
        private string name;
        private string admin;
        private DateTime creationDate;

        public Workspace(int id, string name, string admin, DateTime creationDate)
        {
            this.id = id;
            this.name = name;
            this.admin = admin;
            this.creationDate = creationDate;
        }

        public int Id { get => id; }
        public string Name { get => name; }
        public DateTime CreationDate { get => creationDate; }
        public string Admin { get => admin; set => admin = value; }

        public bool isAdmin(string admin)
        {
            if (this.admin == admin) return true;
            return false;
        }

    }

}
