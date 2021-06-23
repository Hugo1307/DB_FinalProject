using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BD_FinalProject.Utils;

namespace BD_FinalProject
{
    public partial class AddIncome : UserControl, Route
    {

        string documentPath = null;

        public AddIncome()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pb_ChooseDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "PDF files (*.pdf) | *.pdf";
            fileDialog.Title = "Choose Document";
           
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                
                documentPath = fileDialog.FileName;

                P_ChooseUploadFile.Visible = false;
                P_UploadFileChosen.Visible = true;
                P_UploadFileChosen.BringToFront();
                Lb_ChosenFilePath.Text = documentPath;

            }

        }

        private void Btn_AddTransaction_Click(object sender, EventArgs e)
        {

            DBCommander dBCommander = DBCommander.getInstance();
            Workspace currentWorkspace = DataCache.getInstance().CurrentWorkspace;

            if (currentWorkspace == null)
            {
                new CustomTextBox("No Workspace found", "Please checkout a workspace before adding a transaction.").Show();
            }

            string incomeName = Tb_IncomeName.Text;
            double incomeValue = Convert.ToDouble(Tb_IncomeValue.Value);
            string incomeCategory = Tb_Category.Text;
            DateTime incomeDate = Dp_Date.Value;
            bool isIncomeVisible = Rb_Visible.Checked ? true : false;

            bool wasIncomeAdded = dBCommander.addIncome(currentWorkspace, incomeName, incomeDate, incomeValue, isIncomeVisible, documentPath, incomeCategory);

            if (wasIncomeAdded)
            {
                new CustomTextBox("Income Added", "The income transaction was successfully added to the database.").Show();
                RouteHandler.getInstance().showRoute(new Dashboard());
            }
            else
            {
                new CustomTextBox("Error", "The transaction could not be added to the database.\nPlease try again.").Show();
            }

        }

        public RouteName getName()
        {
            return RouteName.ADD_TRANSACTION;
        }

        public UserControl getNewInstance()
        {
            return new AddIncome();
        }

        private void AddIncome_Load(object sender, EventArgs e)
        {

        }

    }

}
