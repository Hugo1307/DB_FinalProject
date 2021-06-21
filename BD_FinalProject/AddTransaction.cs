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

namespace BD_FinalProject
{
    public partial class AddTransaction : UserControl, Route
    {

        string documentPath = null;

        public AddTransaction()
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

            DBManager dBManager = DBManager.getInstance();
            dBManager.connect();
            if (dBManager.isOpened()) dBManager.close();

            string docName = Tb_TransactionName.Text;
            double transactionValue = Convert.ToDouble(Tb_TransactionValue.Text);
            DateTime transactionDate = Dp_Date.Value;
            bool transactionVisible = Rb_Visible.Checked ? true : false;
            string user = Properties.Settings.Default.UserEmail;
            int workspaceID = 2;

            MessageBox.Show(user);

            dBManager.open();

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@DocName", docName),
                new SqlParameter("@Value", transactionValue),
                new SqlParameter("@Date", transactionDate),
                new SqlParameter("@Visibility", transactionVisible),
                new SqlParameter("@Path", documentPath),
                new SqlParameter("@User", user),
                new SqlParameter("@Workspace_ID", workspaceID)
            };


            SqlParameterCollection result = dBManager.executeSP("Wellet.UploadDoc", sqlParameters);

            if (result != null)
            {
                new CustomTextBox("Transaction Added", "The transaction was successfully added to the database.").Show();
            }
            else
            {
                new CustomTextBox("Error", "The transaction could not be added to database.").Show();
            }

        }

        public RouteName getName()
        {
            return RouteName.ADD_TRANSACTION;
        }

        public UserControl getNewInstance()
        {
            return new AddTransaction();
        }

    }
}
