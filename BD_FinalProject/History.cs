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
    public partial class History : UserControl, Route
    {

        private DBCommander dBCommander;
        private List<Workspace> allUserWorkspaces;
        private int selectedWorkspaceIdx;

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

            if (allUserWorkspaces.Count > 0)
            {
                Workspace selectedWorkspace = allUserWorkspaces.ElementAt(selectedWorkspaceIdx);
                DateTime startDate = Dp_StartDate.Value;
                DateTime endDate = Dp_EndDate.Value;

                List<HistoryItem> historyItems = dBCommander.getHistory(selectedWorkspace.Id, startDate, endDate);

                historyItems.ForEach(item => Lbx_HistoryItems.Items.Add(item.Action.Type.ToString() + " (" + item.Action.Id + ")"));
                
            }

        }

        private void Cb_WorkspaceSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWorkspaceIdx = Cb_WorkspaceSelection.SelectedIndex;
        }

        private void Btn_ApplyFilters_Click(object sender, EventArgs e)
        {
            loadHistoryItems();
        }

        public RouteName getName()
        {
            return RouteName.HISTORY;
        }

        public UserControl getNewInstance()
        {
            return new History();
        }
    }

}
