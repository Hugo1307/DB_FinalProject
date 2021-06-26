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
    public partial class CreateReportPopup : Form
    {

        private DataCache dataCache;
        private DBCommander dBCommander;

        public CreateReportPopup()
        {
            InitializeComponent();
            this.dataCache = DataCache.getInstance();
            this.dBCommander = DBCommander.getInstance();
        }

        private void Pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateReportPopup_Load(object sender, EventArgs e)
        {
            Lb_ActiveWorkspace.Text = dataCache.CurrentWorkspace.Name;
        }

        private void Btn_CreateReport_Click(object sender, EventArgs e)
        {
            CustomTextBox customTextBox;
            bool reportCreated = dBCommander.createReport(dataCache.CurrentWorkspace.Id, Dp_ReportStart.Value, Dp_ReportEnd.Value);

            if (reportCreated)
                customTextBox = new CustomTextBox("Report Created", "The report was successfully created.");
            else
                customTextBox = new CustomTextBox("Error", "An error has occurred while creating the report.");

            this.Hide();
            customTextBox.Closed += (s, args) => this.Close();
            customTextBox.Show();

        }

    }

}
