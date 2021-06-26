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
    public partial class GoalDetails : UserControl, Route
    {

        private Goal goal;
        private DBCommander dBCommander;

        public GoalDetails()
        {
            InitializeComponent();
            this.goal = null;
            this.dBCommander = DBCommander.getInstance();
        }

        public GoalDetails(Goal goal)
        {
            InitializeComponent();
            this.goal = goal;
            this.dBCommander = DBCommander.getInstance();
        }

        private void GoalDetails_Load(object sender, EventArgs e)
        {

            Lb_GoalName.Text = goal.Name;
            Tb_GoalBalance.Text = goal.CurrentValue.ToString() + " €";
            Lb_GoalValue.Text = goal.GoalValue.ToString() + " €";
            Tb_GoalDescription.Text = goal.Description;
            Lb_GoalDeadline.Text = goal.GoalDeadline.ToString();
            
            if (goal.ImagePath != null)
                Pb_GoalImage.Image = Image.FromFile(goal.ImagePath);
            else
                Pb_GoalImage.Image = Properties.Resources.goal_icon_black_xl;

        }
        
        private void Pb_DecreaseGoalBalance_Click(object sender, EventArgs e)
        {
            if (goal.CurrentValue > 0)
            {
                this.goal.CurrentValue -= 1;
                Tb_GoalBalance.Text = Math.Round(goal.CurrentValue, 2).ToString() + " €";
                Btn_ApplyChanges.Visible = true;
            }
        }

        private void Pb_IncreaseGoalBalance_Click(object sender, EventArgs e)
        {
            if (goal.CurrentValue < goal.GoalValue)
            {
                this.goal.CurrentValue += 1;
                Tb_GoalBalance.Text = Math.Round(goal.CurrentValue, 2).ToString() + " €";
                Btn_ApplyChanges.Visible = true;
            }
        }

        private void Pb_EditGoalDescription_Click(object sender, EventArgs e)
        {
            goal.Description = Tb_GoalDescription.Text;
            Btn_ApplyChanges.Visible = true;
        }

        private void Btn_ApplyChanges_Click(object sender, EventArgs e)
        {
            bool goalEdited = dBCommander.updateGoal(goal);
            if (goalEdited)
                new CustomTextBox("Goal edited", "The goal '" + goal.Name + "' was successfully edited.").Show();
            else
                new CustomTextBox("Error", "The goal '" + goal.Name + "' could not be updated.").Show();
        }

        public RouteName getName()
        {
            return RouteName.GOAL_DETAILS;
        }

        public UserControl getNewInstance()
        {
            return new GoalDetails();
        }

    }

}
