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

        public Workspace getWorkspaceByID(int workspaceID)
        {

            DBManager dBManager = DBManager.getInstance();
            Workspace gatheredWorkspace = null;

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.Workspace WHERE ID=" + workspaceID);

            while (dataReader.Read())
            {
                int workspaceId = Convert.ToInt32(dataReader["ID"]);
                string workspaceName = Convert.ToString(dataReader["Name"]);
                string workspaceAdmin = Convert.ToString(dataReader["Admin"]);
                DateTime creationDate = Convert.ToDateTime(dataReader["Date_Created"]);

                gatheredWorkspace = new Workspace(workspaceId, workspaceName, workspaceAdmin, creationDate);
            }

            dBManager.close();

            return gatheredWorkspace;

        }

        public List<User> getWorkspaceUsers(int workspaceID)
        {

            DBManager dBManager = DBManager.getInstance();
            List<User> gatheredUsers = new List<User>();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.GetUsersInWorkspace(" + workspaceID + ")");

            while (dataReader.Read())
            {
                string userName = Convert.ToString(dataReader["Name"]);
                string userEmail = Convert.ToString(dataReader["Email"]);
                string imagePath = Convert.ToString(dataReader["Image_Path"]);

                gatheredUsers.Add(new User(userName, userEmail, null, imagePath));
            }

            dBManager.close();

            return gatheredUsers;

        }

        public List<User> searchUser(string searchStr)
        {
            DBManager dBManager = DBManager.getInstance();
            List<User> resultUsers = new List<User>();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.SearchUser('" + searchStr + "')");

            while (dataReader.Read())
            {
                string userName = Convert.ToString(dataReader["Name"]);
                string userEmail = Convert.ToString(dataReader["Email"]);
                string imagePath = Convert.ToString(dataReader["Image_Path"]);

                resultUsers.Add(new User(userName, userEmail, null, imagePath));
            }

            dBManager.close();

            return resultUsers;

        }

        public static DBCommander getInstance()
        {
            if (instance == null) instance = new DBCommander();
            return instance;
        }

    }

}
