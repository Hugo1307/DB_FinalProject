using BD_FinalProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_FinalProject
{
    public partial class History : UserControl, Route
    {

        private DBCommander dBCommander;
        private List<Workspace> allUserWorkspaces;
        private List<HistoryItem> historyItems;
        private int selectedWorkspaceIdx;
        private int selectedHistoryIdx;

        public History()
        {
            InitializeComponent();
            this.dBCommander = DBCommander.getInstance();
        }

        private void History_Load(object sender, EventArgs e)
        {
            allUserWorkspaces = dBCommander.getUserWorkspaces();
            selectedWorkspaceIdx = 0;

            allUserWorkspaces.ForEach(workspace => Cb_WorkspaceSelection.Items.Add(workspace.Name));
            Cb_WorkspaceSelection.SelectedIndex = selectedWorkspaceIdx;

            loadHistoryItems();

        }

        private void loadHistoryItems()
        {

            Lbx_HistoryItems.Items.Clear();

            if (allUserWorkspaces.Count > 0)
            {
                Workspace selectedWorkspace = allUserWorkspaces.ElementAt(selectedWorkspaceIdx);
                DateTime startDate = Dp_StartDate.Value;
                DateTime endDate = Dp_EndDate.Value;

                historyItems = dBCommander.getHistory(selectedWorkspace.Id, startDate, endDate);

                historyItems.ForEach(item => Lbx_HistoryItems.Items.Add(item.Document.Name + " (" + item.Action.Type.ToString() + ")"));
                
            }

        }

        private void updateHistoryItem()
        {

            HistoryItem currentHistoryItem = historyItems.ElementAt(selectedHistoryIdx);
            
            P_HistoryDetails.Visible = true;
            Lb_DocumentName.Text = currentHistoryItem.Document.Name;
            Lb_DocumentDate.Text = currentHistoryItem.Document.Date.ToString();
            Lb_DocumentValue.Text = currentHistoryItem.Document.Value.ToString();
            Lb_ActionDate.Text = currentHistoryItem.Action.Date.ToString();
            Lb_ActionUser.Text = currentHistoryItem.Action.User;

            if (currentHistoryItem.Action.Type == ActionType.Upload)
            {
                Pb_ActionType.Image = Properties.Resources.upload_icon_yellow_light;
                Lb_ActionType.Text = "Document Upload";
            }
            else if (currentHistoryItem.Action.Type == ActionType.Consult)
            {
                Pb_ActionType.Image = Properties.Resources.search_icon_yellow_light;
                Lb_ActionType.Text = "Document Consult";
            }
            else if (currentHistoryItem.Action.Type == ActionType.ChangeVisibility)
            {
                Pb_ActionType.Image = Properties.Resources.visibility_icon_yellow_light;
                Lb_ActionType.Text = "Document Visibility Change";
            }

        }

        private void Cb_WorkspaceSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWorkspaceIdx = Cb_WorkspaceSelection.SelectedIndex;
            loadHistoryItems();
        }

        private void Btn_ApplyFilters_Click(object sender, EventArgs e)
        {
            loadHistoryItems();
            P_HistoryDetails.Visible = false;
        }

        public RouteName getName()
        {
            return RouteName.HISTORY;
        }

        public UserControl getNewInstance()
        {
            return new History();
        }

        private void Lbx_HistoryItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHistoryIdx = Lbx_HistoryItems.SelectedIndex;
            updateHistoryItem();
        }

        private void Btn_OpenDocument_Click(object sender, EventArgs e)
        {
            HistoryItem currentHistoryItem = historyItems.ElementAt(selectedHistoryIdx);

            dBCommander.addConsultAction(currentHistoryItem.Document.Id);
            
            try
            {
                new Process
                {
                    StartInfo = new ProcessStartInfo(currentHistoryItem.Document.Path.ToString())
                    {
                        UseShellExecute = true
                    }
                }.Start();
            }
            catch (System.IO.FileNotFoundException)
            {
                new CustomTextBox("Error opening file", "The file could not be found in path " + currentHistoryItem.Document.Path.ToString()).Show();
            }
           
        }

    }

}
