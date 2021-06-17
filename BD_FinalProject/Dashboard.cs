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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Pb_AddTransaction_Click(object sender, EventArgs e)
        {
            Main mainForm = Main.getInstance();
            Panel routingPanel = (Panel) mainForm.Controls["P_MainRouting"];

            AddTransaction addTransaction = new AddTransaction();
            addTransaction.Parent = routingPanel;
            addTransaction.Location = new Point(0, 0);
            addTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            addTransaction.BringToFront();

        }
    }
}
