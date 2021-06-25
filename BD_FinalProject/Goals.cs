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
    public partial class Goals : UserControl, Route
    {

        private DBCommander dBCommander;
        private List<Workspace> allUserWorkspaces;
        private List<Goal> allWorkspaceGoals;
        private List<GoalPanel> allGoalCards;
        private int selectedWorkspaceIdx;
        private int goalsCardsCount;

        public Goals()
        {
            InitializeComponent();
            this.dBCommander = DBCommander.getInstance();
            this.selectedWorkspaceIdx = 0;
            this.goalsCardsCount = 0;
            this.allGoalCards = new List<GoalPanel>();
        }

        private void Goals_Load(object sender, EventArgs e)
        {

            Workspace currentWorkspace;

            allUserWorkspaces = dBCommander.getUserWorkspaces();
            allUserWorkspaces.ForEach(workspace => Cb_WorkspaceSelection.Items.Add(workspace.Name));

            currentWorkspace = allUserWorkspaces.ElementAt(selectedWorkspaceIdx);

            allWorkspaceGoals = dBCommander.getGoals(currentWorkspace);

            Cb_WorkspaceSelection.SelectedIndex = selectedWorkspaceIdx;

            updateGoalsCards();

        }

        private void updateGoalsCards()
        {

            Workspace currentWorkspace = allUserWorkspaces.ElementAt(selectedWorkspaceIdx);

            foreach (GoalPanel goalPanel in allGoalCards) goalPanel.Dispose();

            goalsCardsCount = 0;
            allWorkspaceGoals = dBCommander.getGoals(currentWorkspace);

            foreach (Goal goal in allWorkspaceGoals) addGoalCard(goal);

        }

        private void addGoalCard(Goal goal)
        {
            GoalPanel goalPanel = new GoalPanel(goal);
            Point cardLocation = new Point((goalPanel.Width + 40) * goalsCardsCount++, 0);

            goalPanel.Parent = P_User_Cards;
            goalPanel.Location = cardLocation;
            goalPanel.BringToFront();

            allGoalCards.Add(goalPanel);

        }

        public RouteName getName()
        {
            return RouteName.GOALS;
        }

        public UserControl getNewInstance()
        {
            return new Goals();
        }

        private void Cb_WorkspaceSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWorkspaceIdx = Cb_WorkspaceSelection.SelectedIndex;
            updateGoalsCards();
        }

        private void Pb_AddGoal_Click(object sender, EventArgs e)
        {
            RouteHandler.getInstance().showRoute(new AddGoal());
        }
    }

}
