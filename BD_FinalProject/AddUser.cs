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
    public partial class AddUser : UserControl, Route
    {
        private List<Workspace> allUserWorkspaces;
        private Workspace selectedWorkspace;
        private List<User> usersObtained;
        private int selectedUserIdx;
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            DBCommander dBCommander = DBCommander.getInstance();
            allUserWorkspaces = dBCommander.getUserWorkspaces();

            foreach (Workspace workspace in allUserWorkspaces)
            {
                Cb_WorkspaceSelection.Items.Add(workspace.Name);
            }

            Cb_WorkspaceSelection.SelectedIndex = 0;
            selectedWorkspace = allUserWorkspaces.ElementAt(Cb_WorkspaceSelection.SelectedIndex);

        }

        private void Pb_SearchUser_Click(object sender, EventArgs e)
        {
            
            DBCommander dBCommander = DBCommander.getInstance();
            
            string searchStr = Tb_UserSearch.Text;
            usersObtained = dBCommander.searchUser(searchStr);

            Lb_SearchResult.Visible = true;
            Lb_Progress.Visible = true;

            if (usersObtained.Count > 0)
            {
                Lb_SearchResult.Text = "Found " + usersObtained.Count + " results";
                P_UserPreview.Visible = true;

                selectedUserIdx = 0;
                updateUserCard();
            }
            else
            {
                Lb_SearchResult.Text = "No results found";
            }

        }

        private void Pb_LeftControl_Click(object sender, EventArgs e)
        {
            if (selectedUserIdx > 0) selectedUserIdx--;
            updateUserCard();
        }

        private void Pb_RightControl_Click(object sender, EventArgs e)
        {
            if (selectedUserIdx < usersObtained.Count - 1) selectedUserIdx++;
            updateUserCard();
        }

        private void updateUserCard()
        {
            UserPanel userPanel = new UserPanel(usersObtained.ElementAt(selectedUserIdx));

            Lb_Progress.Text = selectedUserIdx+1 + "/" + usersObtained.Count;

            userPanel.Parent = P_UserCard;
            userPanel.Location = new Point(1, 1);
            userPanel.BringToFront();
        }

        public RouteName getName()
        {
            return RouteName.ADD_USER;
        }

        public UserControl getNewInstance()
        {
            return new AddUser();
        }

    }
}
