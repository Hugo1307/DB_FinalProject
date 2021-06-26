using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FinalProject.Utils
{
    public class Report
    {
        private int id;
        private string userEmail;
        private int workspaceId;
        private DateTime startDate;
        private DateTime endDate;
        private double totalValue;

        public Report(int id, string userEmail, int workspaceId, DateTime startDate, DateTime endDate, double totalValue)
        {
            this.id = id;
            this.userEmail = userEmail;
            this.workspaceId = workspaceId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.totalValue = totalValue;
        }

        public int Id { get => id; set => id = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public int WorkspaceId { get => workspaceId; set => workspaceId = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public double TotalValue { get => totalValue; set => totalValue = value; }
    
    }

}
