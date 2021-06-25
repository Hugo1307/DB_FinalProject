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
    public partial class AddGoal : UserControl, Route
    {

        private DataCache dataCache;
        private DBCommander dBCommander;
        private string goalImagePath;

        public AddGoal()
        {
            InitializeComponent();
            this.goalImagePath = null;
            this.dataCache = DataCache.getInstance();
            this.dBCommander = DBCommander.getInstance();
        }

        private void Pb_ChooseDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg";
            fileDialog.Title = "Choose Document";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                goalImagePath = fileDialog.FileName;

                P_ChooseUploadFile.Visible = false;
                P_UploadFileChosen.Visible = true;
                P_UploadFileChosen.BringToFront();
                Lb_ChosenFilePath.Text = goalImagePath;

            }

        }

        private void AddGoal_Load(object sender, EventArgs e)
        {
            Lb_CurrentWorkspace.Text = dataCache.CurrentWorkspace.Name;
        }

        private void Btn_AddGoal_Click(object sender, EventArgs e)
        {

            string goalName = Tb_GoalName.Text;
            string goalDescription = Tb_GoalDescription.Text;
            double goalValue = Convert.ToDouble(Tb_GoalValue.Text);
            double startingGoalValue = Convert.ToDouble(Tb_GoalStartingValue.Text);
            DateTime goalDeadline = Dp_GoalDeadline.Value;

            bool goalAdded = dBCommander.addGoal(dataCache.CurrentWorkspace, goalName, goalDescription, goalDeadline, startingGoalValue, goalValue, goalImagePath);

            if (goalAdded)
            {
                new CustomTextBox("Goal Added", "The goal " + goalName + " was successfully added to the database").Show();
            }
            else
            {
                new CustomTextBox("Error", "An error has occurred while adding the goal to the database.").Show();
            }

        }

        public RouteName getName()
        {
            return RouteName.ADD_GOAL;
        }

        public UserControl getNewInstance()
        {
            return new AddGoal();
        }
    }

}
