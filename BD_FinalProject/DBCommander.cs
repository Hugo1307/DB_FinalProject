using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BD_FinalProject.Utils;

namespace BD_FinalProject
{
    public class DBCommander
    {

        private static DBCommander instance;

        private DBCommander() { }

        public List<Workspace> getUserWorkspaces()
        {
            DBManager dBManager = DBManager.getInstance();
            List<Workspace> workspacesList = new List<Workspace>();
            string userEmail = Properties.Settings.Default.UserEmail;

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();
            
            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.GetUserWorkspaces('" + userEmail + "')");

            while (dataReader.Read())
            {
                int workspaceId = Convert.ToInt32(dataReader["ID"]);
                string workspaceName = Convert.ToString(dataReader["Name"]);
                string workspaceAdmin = Convert.ToString(dataReader["Admin"]);
                DateTime creationDate = Convert.ToDateTime(dataReader["Date_Created"]);

                workspacesList.Add(new Workspace(workspaceId, workspaceName, workspaceAdmin, creationDate));
            }

            dBManager.close();

            return workspacesList;

        }

        public static DBCommander getInstance()
        {
            if (instance == null) instance = new DBCommander();
            return instance;
        }

    }

}
