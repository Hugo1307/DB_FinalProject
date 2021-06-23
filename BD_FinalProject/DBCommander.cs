using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BD_FinalProject.Utils;
using System.Windows.Forms;

namespace BD_FinalProject
{
    public class DBCommander
    {

        private static DBCommander instance;

        private DBCommander() { }

        public User getUserByEmail(string userEmail)
        {

            DBManager dBManager = DBManager.getInstance();
            User userGathered = null;

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter userEmailParam = new SqlParameter("@UserEmail", System.Data.SqlDbType.VarChar, 256);
            userEmailParam.Value = userEmail;

            SqlParameter[] sqlParameters = {
                userEmailParam
            };

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.[User] WHERE [Email]=@UserEmail", sqlParameters);

            while (dataReader.Read())
            {
                string userName = Convert.ToString(dataReader["Name"]);
                //string workspaceAdmin = Convert.ToString(dataReader["Password"]);
                string userImage = Convert.ToString(dataReader["Image_Path"]);

                userGathered = new User(userName, userEmail, null, userImage);
            }

            dBManager.close();
            return userGathered;

        }

        public List<Workspace> getUserWorkspaces()
        {
            DBManager dBManager = DBManager.getInstance();
            List<Workspace> workspacesList = new List<Workspace>();
            string userEmail = Properties.Settings.Default.UserEmail;

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter userEmailParam = new SqlParameter("@UserEmail", System.Data.SqlDbType.VarChar, 256);

            userEmailParam.Value = userEmail;

            SqlParameter[] sqlParameters = {
                userEmailParam
            };

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.GetUserWorkspaces(@UserEmail)", sqlParameters);

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

            SqlParameter workspaceIdParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);

            workspaceIdParam.Value = workspaceID;

            SqlParameter[] sqlParameters = { workspaceIdParam };

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.Workspace WHERE ID=@WorkspaceID", sqlParameters);

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

            SqlParameter workspaceIdParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);

            workspaceIdParam.Value = workspaceID;

            SqlParameter[] sqlParameters = { workspaceIdParam };

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.GetUsersInWorkspace(@WorkspaceID)", sqlParameters);

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

            SqlParameter searchStrParam = new SqlParameter("@SearchStr", System.Data.SqlDbType.VarChar, 256);
            
            searchStrParam.Value = searchStr;

            SqlParameter[] sqlParameters = { searchStrParam };

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.SearchUser(@SearchStr)", sqlParameters);

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

        public bool addUserToWorkspace(User user, Workspace workspace)
        {

            DBManager dBManager = DBManager.getInstance();
            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter userEmailParam = new SqlParameter("@UserEmail", System.Data.SqlDbType.VarChar, 256);
            SqlParameter workspaceIdParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);
            
            userEmailParam.Value = user.Email;
            workspaceIdParam.Value = workspace.Id;

            SqlParameter[] sqlParameters = {
                userEmailParam,
                workspaceIdParam
            };

            SqlDataReader dataReader = dBManager.executeQuery("INSERT INTO Wellet.User_Workspace VALUES (@UserEmail, @WorkspaceID)", sqlParameters);

            if (dataReader.RecordsAffected == 0)
            {
                dBManager.close();
                return false;
            }

            dBManager.close();
            return true;

        }

        public bool createWorkspace(string workspaceName, User whoCreates)
        {

            DBManager dBManager = DBManager.getInstance();
            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter workspaceNameParam = new SqlParameter("@WorkspaceName", System.Data.SqlDbType.VarChar, 128);
            SqlParameter workspaceAdminParam = new SqlParameter("@Admin", System.Data.SqlDbType.VarChar, 256);

            workspaceNameParam.Value = workspaceName;
            workspaceAdminParam.Value = whoCreates.Email;

            SqlParameter[] sqlParameters = {
                workspaceNameParam,
                workspaceAdminParam
            };

            SqlParameterCollection returnedParameters = dBManager.executeSP("Wellet.CreateWorkspace", sqlParameters);

            dBManager.close();

            if (returnedParameters == null)
                return false;
            return true;

        }

        public bool deleteWorkspace(int workspaceID)
        {

            DBManager dBManager = DBManager.getInstance();
            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter workspaceIdParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);

            workspaceIdParam.Value = workspaceID;

            SqlParameter[] sqlParameters = { workspaceIdParam };

            SqlDataReader dataReader = dBManager.executeQuery("UPDATE Wellet.[Workspace] SET Deleted=1 WHERE ID=@WorkspaceID", sqlParameters);

            if (dataReader.RecordsAffected == 0)
            {
                dBManager.close();
                return false;
            }

            dBManager.close();
            return true;

        }

        public bool addIncome(Workspace workspace, string name, DateTime date, double value, bool visibility, string path, string category)
        {

            DBManager dBManager = DBManager.getInstance();
            DataCache dataCache = DataCache.getInstance();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter userEmailParam = new SqlParameter("@UserEmail", System.Data.SqlDbType.VarChar, 256);
            SqlParameter workspaceIdParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);
            SqlParameter incomeNameParam = new SqlParameter("@IncomeName", System.Data.SqlDbType.VarChar, 128);
            SqlParameter dateParam = new SqlParameter("@Date", System.Data.SqlDbType.DateTime);
            SqlParameter valueParam = new SqlParameter("@Value", System.Data.SqlDbType.Money);
            SqlParameter visibilityParam = new SqlParameter("@Visibility", System.Data.SqlDbType.Bit);
            SqlParameter pathParam = new SqlParameter("@Path", System.Data.SqlDbType.VarChar, 1024);
            SqlParameter categoryParam = new SqlParameter("@Category", System.Data.SqlDbType.VarChar, 256);

            workspaceIdParam.Value = workspace.Id;
            userEmailParam.Value = dataCache.CurrentUser.Email;
            incomeNameParam.Value = name;
            dateParam.Value = date;
            valueParam.Value = value;
            visibilityParam.Value = visibility;
            pathParam.Value = path;
            categoryParam.Value = category;

            SqlParameter[] sqlParameters = { 
                userEmailParam,
                workspaceIdParam,
                incomeNameParam,
                dateParam,
                valueParam,
                visibilityParam,
                pathParam,
                categoryParam
            };

            SqlParameterCollection sqlParameter = dBManager.executeSP("Wellet.CreateIncome", sqlParameters);

            if (sqlParameter == null)
            {
                dBManager.close();
                return false;
            }

            dBManager.close();
            return true;

        } 

        public List<HistoryItem> getHistory(int workspaceID, DateTime startDate, DateTime endDate)
        {

            DBManager dBManager = DBManager.getInstance();
            List<HistoryItem> historyItems = new List<HistoryItem>();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter workspaceIDParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);
            SqlParameter startDateParam = new SqlParameter("@StartDate", System.Data.SqlDbType.DateTime);
            SqlParameter endDateParam = new SqlParameter("@EndDate", System.Data.SqlDbType.DateTime);

            workspaceIDParam.Value = workspaceID;
            startDateParam.Value = startDate;
            endDateParam.Value = endDate;

            SqlParameter[] sqlParameters = { 
                workspaceIDParam,
                startDateParam,
                endDateParam
            };

            MessageBox.Show("Workspace ID: " + workspaceID);

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.GetHistory(@WorkspaceID, @StartDate, @EndDate)", sqlParameters);

            while (dataReader.Read())
            {

                int actionID = Convert.ToInt32(dataReader["Action_ID"]);
                DateTime actionDate = Convert.ToDateTime(dataReader["Action_Date"]);
                ActionType actionType = ActionTypeMethods.convert(dataReader["Type"].ToString());
                string userEmail = Convert.ToString(dataReader["User"]);
                int docID = dataReader["Doc_ID"].ToString() == "" ? 0 : Convert.ToInt32(dataReader["Doc_ID"]);
                DateTime docDate = dataReader["Doc_Date"].ToString() == "" ? new DateTime() : Convert.ToDateTime(dataReader["Doc_Date"]);
                string docName = dataReader["Doc_Name"].ToString();
                double value = dataReader["Monetary_Value"].ToString() == "" ? 0 : Convert.ToDouble(dataReader["Monetary_Value"]);
                bool visibility = dataReader["Visibility"].ToString() == "" ? false : Convert.ToBoolean(dataReader["Visibility"]);
                string path = dataReader["Visibility"].ToString();
                
                Utils.Action currentAction = new Utils.Action(actionID, userEmail, actionDate, actionType);
                Document currentDocument = new Document(docID, actionID, docName, docDate, value, visibility, path, false);
                HistoryItem currentHistoryItem = new HistoryItem(currentDocument, currentAction);

                historyItems.Add(currentHistoryItem);

            }

            dBManager.close();

            return historyItems;

        }

        public static DBCommander getInstance()
        {
            if (instance == null) instance = new DBCommander();
            return instance;
        }

    }

}
