using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FinalProject.Utils
{
    public class Goal
    {

        private int id;
        private string name;
        private string imagePath;
        private string description;
        private double currentValue;
        private double goalValue;
        private DateTime goalDeadline;
        private string userEmail;
        private int workspaceId;

        public Goal(int id, string name, string imagePath, string description, DateTime deadline, double currentValue, double goalValue, string userEmail, int workspaceId)
        {
            this.id = id;
            this.name = name;
            this.imagePath = imagePath;
            this.description = description;
            this.currentValue = currentValue;
            this.goalDeadline = deadline;
            this.goalValue = goalValue;
            this.userEmail = userEmail;
            this.workspaceId = workspaceId;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string Description { get => description; set => description = value; }
        public double CurrentValue { get => currentValue; set => currentValue = value; }
        public double GoalValue { get => goalValue; set => goalValue = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public int WorkspaceId { get => workspaceId; set => workspaceId = value; }
        public DateTime GoalDeadline { get => goalDeadline; set => goalDeadline = value; }
    }

}
