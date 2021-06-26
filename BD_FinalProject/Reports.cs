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
    public partial class Reports : UserControl, Route
    {

        private DBCommander dBCommander;
        private List<Report> allReports;
        private List<Workspace> allWorkspaces;
        private List<ReportPanel> allReportPanels;
        private int selectedWorkspaceIdx;
        private int reportCardsCount;

        public Reports()
        {
            InitializeComponent();
            this.dBCommander = DBCommander.getInstance();
            this.selectedWorkspaceIdx = 0;
            this.reportCardsCount = 0;
            this.allReportPanels = new List<ReportPanel>();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

            allWorkspaces = dBCommander.getUserWorkspaces();

            allWorkspaces.ForEach(workspace => Cb_WorkspaceSelection.Items.Add(workspace.Name));
            Cb_WorkspaceSelection.SelectedIndex = selectedWorkspaceIdx;

            updateReports();

        }

        private void addReportCard(Report report)
        {

            ReportPanel reportPanel = new ReportPanel(report);
            Point cardLocation = new Point((reportPanel.Width + 40) * reportCardsCount++, 0);

            reportPanel.Parent = P_Report_Cards;
            reportPanel.Location = cardLocation;
            reportPanel.BringToFront();

            allReportPanels.Add(reportPanel);

        }

        private void updateReports()
        {
            DBCommander dBCommander = DBCommander.getInstance();

            foreach (ReportPanel reportPanel in allReportPanels) reportPanel.Dispose();

            reportCardsCount = 0;
            allReports = dBCommander.getWorkspaceReports(allWorkspaces.ElementAt(selectedWorkspaceIdx));

            foreach (Report report in allReports) addReportCard(report);

        }

        private void Cb_WorkspaceSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWorkspaceIdx = Cb_WorkspaceSelection.SelectedIndex;
            updateReports();
        }

        private void Pb_CreateReport_Click(object sender, EventArgs e)
        {
            new CreateReportPopup().Show();
        }

        public RouteName getName()
        {
            return RouteName.REPORTS;
        }

        public UserControl getNewInstance()
        {
            return new Reports();
        }
    }

}
