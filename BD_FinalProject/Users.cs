using BD_FinalProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_FinalProject
{
    public partial class Users : UserControl, Route
    {

        private int userCardsCount;
        private List<User> allUsersInWorkspace;
        private List<Workspace> allUserWorkspaces;
        private Workspace selectedWorkspace;

        public Users()
        {
            InitializeComponent();
            this.userCardsCount = 0;
        }

        private void addUserCard(User user)
        {

            UserPanel userPanel = new UserPanel(user);
            Point cardLocation = new Point((userPanel.Width+40)*userCardsCount++, 0);

            userPanel.Parent = P_User_Cards;
            userPanel.Location = cardLocation;
            userPanel.BringToFront();

        }

        private void Users_Load(object sender, EventArgs e)
        {

            DBCommander dBCommander = DBCommander.getInstance();
            allUserWorkspaces = dBCommander.getUserWorkspaces();

            foreach (Workspace workspace in allUserWorkspaces)
            {
                Cb_WorkspaceSelection.Items.Add(workspace.Name);
            }

            Cb_WorkspaceSelection.SelectedIndex = 0;

            selectedWorkspace = allUserWorkspaces.ElementAt(Cb_WorkspaceSelection.SelectedIndex);
            allUsersInWorkspace = dBCommander.getWorkspaceUsers(selectedWorkspace.Id);

            foreach (User user in allUsersInWorkspace)
            {
                addUserCard(user);
            }

        }

        public RouteName getName()
        {
            return RouteName.USERS;
        }

        public UserControl getNewInstance()
        {
            return new Users();
        }

        private void Pb_AddUser_Click(object sender, EventArgs e)
        {
            RouteHandler routeHandler = RouteHandler.getInstance();
            routeHandler.showRoute(new AddUser());
        }
    }

}
