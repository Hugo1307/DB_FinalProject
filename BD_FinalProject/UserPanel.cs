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
    public partial class UserPanel : UserControl
    {

        private User user;
        private DBCommander dBCommander;
        private DataCache dataCache;
        private bool showDeleteButton;
        private int workspaceId;

        public User User { get => user; set => user = value; }

        public UserPanel(User user, bool showDeleteButton, int workspaceId)
        {
            InitializeComponent();
            this.user = user;
            this.showDeleteButton = showDeleteButton;
            this.dBCommander = DBCommander.getInstance();
            this.dataCache = DataCache.getInstance();
            this.workspaceId = workspaceId;
        }

        public UserPanel(User user, bool showDeleteButton)
        {
            InitializeComponent();
            this.user = user;
            this.showDeleteButton = showDeleteButton;
            this.dBCommander = DBCommander.getInstance();
            this.dataCache = DataCache.getInstance();
            this.workspaceId = 0;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            Lb_UserName.Text = user.Name;
            Lb_UserEmail.Text = user.Email;

            if (user.ImagePath != null && user.ImagePath != "")
                Pb_UserPicture.Image = Image.FromFile(user.ImagePath);
            else
                Pb_UserPicture.Image = Properties.Resources.user_icon_black;

            if (!showDeleteButton) Pb_DeleteUser.Visible = false;

        }

        private void Pb_DeleteUser_Click(object sender, EventArgs e)
        {
            bool userRemoved = dBCommander.removeUserFromWorkspace(dataCache.CurrentUser.Email, user.Email, workspaceId);
            CustomTextBox customTextBox;
            if (userRemoved)
                customTextBox = new CustomTextBox("Removed user from Workspace", "You have successfully removed the user '" + user.Email + "' from the workspace " + workspaceId + ".");
            else
                customTextBox = new CustomTextBox("Error", "Unable to remove the user '" + user.Email + "' from the workspace " + workspaceId + ".");
            customTextBox.Show();
        }

    }

}
