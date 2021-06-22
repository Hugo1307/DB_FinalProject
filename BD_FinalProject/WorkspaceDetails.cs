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
    public partial class WorkspaceDetails : UserControl, Route
    {

        private int workspaceID;

        public int WorkspaceID { get => workspaceID; set => workspaceID = value; }

        public WorkspaceDetails(int workspaceID)
        {
            InitializeComponent();
            this.workspaceID = workspaceID;
        }
        private void WorkspaceDetails_Load(object sender, EventArgs e)
        {
            DBCommander dBCommander = DBCommander.getInstance();
            Workspace workspace = dBCommander.getWorkspaceByID(this.workspaceID);
            List<User> workspaceUsers = dBCommander.getWorkspaceUsers(this.workspaceID);

            if (workspace != null)
            {
                Lb_WorkspaceName.Text = workspace.Name;
                Lb_WorkspaceAdmin.Text = workspace.Admin;
                Lb_WorkspaceCreationDate.Text = workspace.CreationDate.ToString();
                foreach (User user in workspaceUsers)
                {
                    Lbx_WorkspaceUsers.Items.Add(user.Name + "(" + user.Email + ")");
                }
               
            }

        }

        public RouteName getName()
        {
            return RouteName.WORKSPACE_DETAILS;
        }

        public UserControl getNewInstance()
        {
            return new WorkspaceDetails(1);
        }

        
    }
}
