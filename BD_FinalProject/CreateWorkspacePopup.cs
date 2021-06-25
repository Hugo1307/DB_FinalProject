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
    public partial class CreateWorkspacePopup : Form
    {
        public CreateWorkspacePopup()
        {
            InitializeComponent();
        }

        private void Btn_CreateUser_Click(object sender, EventArgs e)
        {
            
            DataCache dataCache = DataCache.getInstance();
            DBCommander dBCommander = DBCommander.getInstance();
            User currentUser = dataCache.CurrentUser;

            bool workspaceCreated = dBCommander.createWorkspace(Tb_WorkspaceName.Text, currentUser);

            CustomTextBox customTextBox;

            if (workspaceCreated)
                customTextBox = new CustomTextBox("Workspace created", "The workspace " + Tb_WorkspaceName.Text + " was successfully created.");
            else
                customTextBox = new CustomTextBox("Error creating workspace", "The workspace " + Tb_WorkspaceName.Text + " could not be created.");

            this.Hide();
            customTextBox.Closed += (s, args) => this.Close();
            customTextBox.Show();

        }

        private void Pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
