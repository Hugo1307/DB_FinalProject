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
    public partial class Dashboard : UserControl, Route
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Pb_AddTransaction_Click(object sender, EventArgs e)
        {
            RouteHandler routeHandler = RouteHandler.getInstance();
            routeHandler.showRoute(new AddIncome());
        }

        public RouteName getName()
        {
            return RouteName.DASHBOARD;
        }

        public UserControl getNewInstance()
        {
            return new Dashboard();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataCache dataCache = DataCache.getInstance();
            refreshWorkspaces();
            dataCache.CurrentWorkspace = dataCache.AllUserWorkspaces.ElementAtOrDefault(0);
        }

        private void refreshWorkspaces()
        {
            DataCache dataCache = DataCache.getInstance();
            dataCache.AllUserWorkspaces = DBCommander.getInstance().getUserWorkspaces();

            Lbx_AllWorkspaces.Items.Clear();

            foreach (Workspace workspace in dataCache.AllUserWorkspaces)
            {
                bool isUserAdmin = workspace.isAdmin(dataCache.CurrentUser.Email);
                if (isUserAdmin)
                    Lbx_AllWorkspaces.Items.Add(workspace.Name + " (Admin)");
                else
                    Lbx_AllWorkspaces.Items.Add(workspace.Name);
            }

        }

        private void Lbx_AllWorkspaces_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataCache dataCache = DataCache.getInstance();
            RouteHandler routeHandler = RouteHandler.getInstance();

            int workspaceSelectedIdx = Lbx_AllWorkspaces.SelectedIndex;

            Workspace selectedWorkspace = dataCache.AllUserWorkspaces.ElementAt(workspaceSelectedIdx);

            routeHandler.showRoute(new WorkspaceDetails(selectedWorkspace.Id));
            
        }

        private void Pb_AddWorkspace_Click(object sender, EventArgs e)
        {
            new CreateWorkspacePopup().Show();
        }

        private void Pb_RefreshWorkspaces_Click(object sender, EventArgs e)
        {
            refreshWorkspaces();
        }

        private void Pb_CheckHistory_Click(object sender, EventArgs e)
        {
            RouteHandler.getInstance().showRoute(new History());
        }
    }

}
