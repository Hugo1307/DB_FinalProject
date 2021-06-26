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

        public bool addExpense(Workspace workspace, string name, DateTime date, double value, bool visibility, string path, DateTime? paymentDate, int? entityId)
        {

            DBManager dBManager = DBManager.getInstance();
            DataCache dataCache = DataCache.getInstance();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter userEmailParam = new SqlParameter("@UserEmail", System.Data.SqlDbType.VarChar, 256);
            SqlParameter workspaceIdParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);
            SqlParameter billNameParam = new SqlParameter("@BillName", System.Data.SqlDbType.VarChar, 128);
            SqlParameter dateParam = new SqlParameter("@Date", System.Data.SqlDbType.DateTime);
            SqlParameter valueParam = new SqlParameter("@Value", System.Data.SqlDbType.Money);
            SqlParameter visibilityParam = new SqlParameter("@Visibility", System.Data.SqlDbType.Bit);
            SqlParameter pathParam = new SqlParameter("@Path", System.Data.SqlDbType.VarChar, 1024);
            SqlParameter paymentDateParam = new SqlParameter("@PaymentDate", System.Data.SqlDbType.DateTime);
            SqlParameter entityParam = new SqlParameter("@EntityID", System.Data.SqlDbType.Int);


            workspaceIdParam.Value = workspace.Id;
            userEmailParam.Value = dataCache.CurrentUser.Email;
            billNameParam.Value = name;
            dateParam.Value = date;
            valueParam.Value = value;
            visibilityParam.Value = visibility;
            pathParam.Value = path;
            entityParam.Value = entityId == null ? DBNull.Value : entityId;
            paymentDateParam.Value = paymentDate == null ? DBNull.Value : paymentDate;

            SqlParameter[] sqlParameters = {
                userEmailParam,
                workspaceIdParam,
                billNameParam,
                dateParam,
                valueParam,
                visibilityParam,
                pathParam,
                paymentDateParam,
                entityParam
            };

            SqlParameterCollection sqlParameter = dBManager.executeSP("Wellet.CreateBill", sqlParameters);

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
                string path = dataReader["Path"].ToString();
                
                Utils.Action currentAction = new Utils.Action(actionID, userEmail, actionDate, actionType);
                Document currentDocument = new Document(docID, actionID, docName, docDate, value, visibility, path, false);
                HistoryItem currentHistoryItem = new HistoryItem(currentDocument, currentAction);

                historyItems.Add(currentHistoryItem);

            }

            dBManager.close();

            return historyItems;

        }

        public bool addConsultAction(int documentID)
        {

            DBManager dBManager = DBManager.getInstance();
            DataCache dataCache = DataCache.getInstance();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter workspaceIDParam = new SqlParameter("@Workspace_ID", System.Data.SqlDbType.Int);
            SqlParameter userEmailParam = new SqlParameter("@User", System.Data.SqlDbType.VarChar, 256);
            SqlParameter documentIDParam = new SqlParameter("@Document_ID", System.Data.SqlDbType.Int);

            workspaceIDParam.Value = dataCache.CurrentWorkspace.Id;
            userEmailParam.Value = dataCache.CurrentUser.Email;
            documentIDParam.Value = documentID;

            SqlParameter[] sqlParameters = {
                workspaceIDParam,
                userEmailParam,
                documentIDParam
            };

            SqlParameterCollection parameterCollection = dBManager.executeSP("Wellet.AddConsultAction", sqlParameters);

            dBManager.close();

            if (parameterCollection == null) return false;
            return true;

        }

        public List<BillEntity> getBillEntities(string billCategory)
        {

            DBManager dBManager = DBManager.getInstance();
            List<BillEntity> billEntities = new List<BillEntity>();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter billCategoryParam = new SqlParameter("@BillCategory", System.Data.SqlDbType.VarChar, 256);

            billCategoryParam.Value = billCategory;

            SqlParameter[] sqlParameters = {
                billCategoryParam
            };

            SqlDataReader dataReader;

            if (billCategory != null)
            {
                dataReader = dBManager.executeQuery("SELECT * FROM Wellet.Entity WHERE Category=@BillCategory", sqlParameters);
            }
            else
            {
                dataReader = dBManager.executeQuery("SELECT * FROM Wellet.Entity", null);
            }

            while (dataReader.Read())
            {
                int entityId = Convert.ToInt32(dataReader["ID"]);
                string category = dataReader["Category"].ToString();
                string entityName = dataReader["Name"].ToString();
                string entityAddress = dataReader["Address"].ToString();
                string entityEmail = dataReader["Email"].ToString();

                billEntities.Add(new BillEntity(entityId, category, entityName, entityAddress, entityEmail));

            }

            dBManager.close();
            return billEntities;

        }

        public List<string> getBillCategories()
        {

            DBManager dBManager = DBManager.getInstance();
            List<string> billCategories = new List<string>();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.Bill_Category", null);

            while (dataReader.Read())
            {
                string category = dataReader["Name"].ToString();
                billCategories.Add(category);
            }

            dBManager.close();
            return billCategories;

        }

        public bool removeUserFromWorkspace(string userRemoving, string userToRemove, int workspaceID)
        {
            
            DBManager dBManager = DBManager.getInstance();
            List<string> billCategories = new List<string>();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter userRemovingParam = new SqlParameter("@UserRemoving", System.Data.SqlDbType.VarChar, 256);
            SqlParameter userToRemoveParam = new SqlParameter("@UserToRemove", System.Data.SqlDbType.VarChar, 256);
            SqlParameter workspaceIDParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);

            userRemovingParam.Value = userRemoving;
            userToRemoveParam.Value = userToRemove;
            workspaceIDParam.Value = workspaceID;

            SqlParameter[] sqlParameters = {
                userRemovingParam,
                userToRemoveParam,
                workspaceIDParam
            };

            SqlParameterCollection parameterCollection = dBManager.executeSP("Wellet.DeleteUserFromWorkspace", sqlParameters);
            dBManager.close();

            return parameterCollection != null;

        }

        public List<Goal> getGoals(Workspace workspace)
        {

            DBManager dBManager = DBManager.getInstance();
            List<Goal> workspaceGoals = new List<Goal>();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter workspaceIDParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);

            workspaceIDParam.Value = workspace.Id;

            SqlParameter[] sqlParameters = {
                workspaceIDParam
            };

            SqlDataReader dataReader= dBManager.executeQuery("SELECT * FROM Wellet.Goal WHERE Workspace_ID=@WorkspaceID", sqlParameters);
            
            while (dataReader.Read())
            {

                int goalId = Convert.ToInt32(dataReader["ID"]);
                string goalName = dataReader["Name"].ToString();
                string goalDescription = dataReader["Description"].ToString();
                double currentGoalValue = Convert.ToDouble(dataReader["Current_Value"]);
                double goalValue = Convert.ToDouble(dataReader["Goal_Value"]);
                string goalImage = dataReader["Image_Path"].ToString();
                DateTime goalDeadline = Convert.ToDateTime(dataReader["Deadline"]);
                int workspaceId = Convert.ToInt32(dataReader["Workspace_ID"]);
                string userEmail = dataReader["User"].ToString();

                workspaceGoals.Add(new Goal(goalId, goalName, goalImage, goalDescription, goalDeadline, currentGoalValue, goalValue, userEmail, workspaceId));

            }
            
            dBManager.close();

            return workspaceGoals;

        }

        public bool addGoal(Workspace workspace, string goalName, string goalDescription, DateTime goalDeadline, double currentValue, double goalValue, string imagePath)
        {

            DBManager dBManager = DBManager.getInstance();
            DataCache dataCache = DataCache.getInstance();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter workspaceIDParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);
            SqlParameter userEmailParam = new SqlParameter("@UserEmail", System.Data.SqlDbType.VarChar, 256);
            SqlParameter goalNameParam = new SqlParameter("@GoalName", System.Data.SqlDbType.VarChar, 128);
            SqlParameter goalDeadlineParam = new SqlParameter("@GoalDeadline", System.Data.SqlDbType.DateTime);
            SqlParameter goalDescriptionParam = new SqlParameter("@GoalDescription", System.Data.SqlDbType.VarChar, 512);
            SqlParameter currentValueParam = new SqlParameter("@CurrentValue", System.Data.SqlDbType.Money);
            SqlParameter goalValueParam = new SqlParameter("@GoalValue", System.Data.SqlDbType.Money);
            SqlParameter imagePathParam = new SqlParameter("@GoalImage", System.Data.SqlDbType.VarChar, 256);

            workspaceIDParam.Value = workspace.Id;
            userEmailParam.Value = dataCache.CurrentUser.Email;
            goalNameParam.Value = goalName;
            goalDeadlineParam.Value = goalDeadline;
            goalDescriptionParam.Value = goalDescription;
            currentValueParam.Value = currentValue;
            goalValueParam.Value = goalValue;
            imagePathParam.Value = imagePath;

            SqlParameter[] sqlParameters = {
                workspaceIDParam,
                userEmailParam,
                goalNameParam,
                goalDeadlineParam,
                goalDescriptionParam,
                currentValueParam,
                goalValueParam,
                imagePathParam
            };

            SqlDataReader dataReader = dBManager.executeQuery("INSERT INTO Wellet.Goal VALUES (@GoalName, @GoalDescription, @GoalDeadline, @CurrentValue, @GoalValue, @GoalImage, @UserEmail, @WorkspaceID)", sqlParameters);

            dBManager.close();

            return dataReader != null;

        }

        public bool updateGoal(Goal goal)
        {

            DBManager dBManager = DBManager.getInstance();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter goalIDParam = new SqlParameter("@Id", System.Data.SqlDbType.Int);
            SqlParameter goalDescriptionParam = new SqlParameter("@Description", System.Data.SqlDbType.VarChar, 512);
            SqlParameter goalBalanceParam = new SqlParameter("@CurrentValue", System.Data.SqlDbType.Money);

            goalIDParam.Value = goal.Id;
            goalDescriptionParam.Value = goal.Description;
            goalBalanceParam.Value = goal.CurrentValue;

            SqlParameter[] sqlParameters = {
                goalIDParam,
                goalDescriptionParam,
                goalBalanceParam
            };

            SqlDataReader dataReader = dBManager.executeQuery("UPDATE Wellet.Goal SET Description=@Description, Current_Value=@CurrentValue WHERE ID=@Id", sqlParameters);

            dBManager.close();

            if (dataReader.RecordsAffected == 0) return false;
            return true;

        } 

        public List<Report> getWorkspaceReports(Workspace workspace)
        {

            DBManager dBManager = DBManager.getInstance();
            DataCache dataCache = DataCache.getInstance();
            List<Report> allReports = new List<Report>();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter userEmailParam = new SqlParameter("@User", System.Data.SqlDbType.VarChar, 256);
            SqlParameter workspaceIDParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);

            userEmailParam.Value = dataCache.CurrentUser.Email;
            workspaceIDParam.Value = workspace.Id;

            SqlParameter[] sqlParameters = {
                userEmailParam,
                workspaceIDParam
            };

            SqlDataReader dataReader = dBManager.executeQuery("SELECT * FROM Wellet.Report WHERE [User]=@User AND Workspace_ID=@WorkspaceID", sqlParameters);

            while(dataReader.Read())
            {
                int reportId = Convert.ToInt32(dataReader["ID"]);
                string userEmail = dataReader["User"].ToString();
                int workspaceId = Convert.ToInt32(dataReader["Workspace_ID"]);
                DateTime startDate = Convert.ToDateTime(dataReader["Start_Date"]);
                DateTime endDate = Convert.ToDateTime(dataReader["End_Time"]);
                double totalValue = Convert.ToDouble(dataReader["Total_Monetary_Value"]);

                allReports.Add(new Report(reportId, userEmail, workspaceId, startDate, endDate, totalValue));

            }

            dBManager.close();

            return allReports;

        }

        public bool createReport(int workspaceId, DateTime startDate, DateTime endDate)
        {

            DBManager dBManager = DBManager.getInstance();
            DataCache dataCache = DataCache.getInstance();

            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            dBManager.open();

            SqlParameter userEmailParam = new SqlParameter("@User", System.Data.SqlDbType.VarChar, 256);
            SqlParameter workspaceIDParam = new SqlParameter("@WorkspaceID", System.Data.SqlDbType.Int);
            SqlParameter startDateParam = new SqlParameter("@StartDate", System.Data.SqlDbType.Date);
            SqlParameter endDateParam = new SqlParameter("@EndDate", System.Data.SqlDbType.Date);

            userEmailParam.Value = dataCache.CurrentUser.Email;
            workspaceIDParam.Value = workspaceId;
            startDateParam.Value = startDate;
            endDateParam.Value = endDate;

            SqlParameter[] sqlParameters = {
                userEmailParam,
                workspaceIDParam,
                startDateParam,
                endDateParam
            };

            SqlParameterCollection parameterCollection = dBManager.executeSP("Wellet.CreateReport", sqlParameters);

            dBManager.close();

            return parameterCollection != null;

        }

        public static DBCommander getInstance()
        {
            if (instance == null) instance = new DBCommander();
            return instance;
        }

    }

}
