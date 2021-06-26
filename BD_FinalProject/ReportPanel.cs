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

        private Report report;

        public ReportPanel(Report report)
        {
            InitializeComponent();
            this.report = report;
        }

        private void ReportPanel_Load(object sender, EventArgs e)
        {
            Lb_ReportName.Text = "Report " + report.Id;
            Lb_ReportDate.Text = report.StartDate.ToShortDateString() + " - " + report.EndDate.ToShortDateString();
            Lb_TotalValue.Text = Math.Round(report.TotalValue, 2).ToString() + " €";
        }

    }

}
