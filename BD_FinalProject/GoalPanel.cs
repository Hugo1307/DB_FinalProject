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
    public partial class GoalPanel : UserControl
    {

        private Goal currentGoal;
        private DBCommander dBCommander;

        public GoalPanel(Goal goal)
        {
            InitializeComponent();
            this.currentGoal = goal;
            this.dBCommander = DBCommander.getInstance();
        }

        private void GoalPanel_Load(object sender, EventArgs e)
        {

            Lb_GoalName.Text = currentGoal.Name;
            Lb_GoalDescription.Text = currentGoal.Description;
            Lb_GoalValue.Text = currentGoal.CurrentValue.ToString() + " €";

            if (currentGoal.ImagePath != null && currentGoal.ImagePath != "")
                Pb_GoalPicture.Image = Image.FromFile(currentGoal.ImagePath);
            else
                Pb_GoalPicture.Image = Properties.Resources.goal_icon_black_xl;

        }

        private void Pb_ViewGoal_Click(object sender, EventArgs e)
        {
            RouteHandler.getInstance().showRoute(new GoalDetails(currentGoal));
        }

        private void Pb_DeleteGoal_Click(object sender, EventArgs e)
        {
            bool goalDeleted = dBCommander.deleteGoal(currentGoal.Id);
            CustomTextBox customTextBox;
            if (goalDeleted)
                customTextBox = new CustomTextBox("Goal Deleted", "The goal '" + currentGoal.Name + "' was successfully deleted.");
            else
                customTextBox = new CustomTextBox("Error", "The goal '" + currentGoal.Name + "' could not be deleted.");
            customTextBox.Show();
        }

    }

}
