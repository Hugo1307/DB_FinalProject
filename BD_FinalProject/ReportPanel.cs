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
    public partial class ReportPanel : UserControl
    {

        private Report currentReport;
        private DBCommander dBCommander;

        public ReportPanel(Report report)
        {
            InitializeComponent();
            this.currentReport = report;
            this.dBCommander = DBCommander.getInstance();
        }

        private void ReportPanel_Load(object sender, EventArgs e)
        {
            Lb_ReportName.Text = "Report " + currentReport.Id;
            Lb_ReportDate.Text = currentReport.StartDate.ToShortDateString() + " - " + currentReport.EndDate.ToShortDateString();
            Lb_TotalValue.Text = Math.Round(currentReport.TotalValue, 2).ToString() + " €";
        }

        private void Pb_DeleteReport_Click(object sender, EventArgs e)
        {
            bool reportDeleted = dBCommander.deleteReport(currentReport.Id);
            CustomTextBox customTextBox;
            if (reportDeleted)
                customTextBox = new CustomTextBox("Report Deleted", "The report '" + currentReport.Id + "' was successfully deleted.");
            else
                customTextBox = new CustomTextBox("Error", "The report '" + currentReport.Id + "' could not be deleted.");
            customTextBox.Show();
        }

    }

}
