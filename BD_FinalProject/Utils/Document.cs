using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FinalProject.Utils
{
    public class Document
    {

        private int id;
        private int actionId;
        private string name;
        private DateTime date;
        private double value;
        private bool visibility;
        private string path;
        private bool deleted;

        public Document(int id, int actionId, string name, DateTime date, double value, bool visibility, string path, bool deleted)
        {
            this.id = id;
            this.actionId = actionId;
            this.name = name;
            this.date = date;
            this.value = value;
            this.visibility = visibility;
            this.path = path;
            this.deleted = deleted;
        }

        public int Id { get => id; set => id = value; }
        public int ActionId { get => actionId; set => actionId = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Value { get => value; set => this.value = value; }
        public bool Visibility { get => visibility; set => visibility = value; }
        public string Path { get => path; set => path = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
