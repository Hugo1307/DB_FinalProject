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
            routeHandler.showRoute(new AddTransaction());
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
            string userEmail = Properties.Settings.Default.UserEmail;

            if (dataCache.AllUserWorkspaces == null)
                dataCache.AllUserWorkspaces = DBCommander.getInstance().getUserWorkspaces();

            foreach (Workspace workspace in dataCache.AllUserWorkspaces)
            {
                bool isUserAdmin = workspace.isAdmin(userEmail);
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
    }

}
