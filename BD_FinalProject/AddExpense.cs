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
    public partial class AddExpense : UserControl, Route
    {

        private DBCommander dBCommander;
        private List<BillEntity> billEntities;
        private List<string> billCategories;
        private int selectedCategoryIdx;
        private int selectedEntityIdx;
        private string documentPath;

        public AddExpense()
        {
            InitializeComponent();
            this.dBCommander = DBCommander.getInstance();
            this.selectedCategoryIdx = -1;
            this.selectedEntityIdx = -1;
        }

        private void AddExpense_Load(object sender, EventArgs e)
        {
            billCategories = dBCommander.getBillCategories();
            billCategories.ForEach(category => Cb_CategorySelection.Items.Add(category));
            billEntities = dBCommander.getBillEntities(null);
            billEntities.ForEach(entity => Cb_EntitySelection.Items.Add(entity.Name));
        }

        public RouteName getName()
        {
            return RouteName.ADD_EXPENSE;
        }

        public UserControl getNewInstance()
        {
            return new AddExpense();
        }

        private void Cb_CategorySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategoryIdx = Cb_CategorySelection.SelectedIndex;
            billEntities = dBCommander.getBillEntities(billCategories.ElementAt(selectedCategoryIdx));
            Cb_EntitySelection.Items.Clear();
            billEntities.ForEach(entity => Cb_EntitySelection.Items.Add(entity.Name));
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

            string expenseName = Tb_ExpenseName.Text;
            double expenseValue = Convert.ToDouble(Tb_ExpenseValue.Value);
            DateTime expenseDate = Dp_Date.Value;
            DateTime? paymentDate = Rb_NoPaymentDate.Checked ? null : Dp_Date.Value;
            bool isExpenseVisible = Rb_Visible.Checked ? true : false;
            int? entityId = selectedEntityIdx == -1 ? null : billEntities.ElementAt(selectedEntityIdx).Id; 

            bool wasIncomeAdded = dBCommander.addExpense(currentWorkspace, expenseName, expenseDate, expenseValue, isExpenseVisible, documentPath, paymentDate, entityId);

            if (wasIncomeAdded)
            {
                new CustomTextBox("Expense Added", "The expense transaction was successfully added to the database.").Show();
                RouteHandler.getInstance().showRoute(new Dashboard());
            }
            else
            {
                new CustomTextBox("Error", "The transaction could not be added to the database.\nPlease try again.").Show();
            }
        }
    }

}
