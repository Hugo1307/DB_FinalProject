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
    public partial class Main : Form
    {

        private static Main instance;
        private DataCache dataCache;

        private Main()
        {
            InitializeComponent();
            dataCache = DataCache.getInstance();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Lb_UserName.Text = Properties.Settings.Default.UserName;
            Lb_SelectedWorkspace.Text = dataCache.CurrentWorkspace.Name;
        }

        private void Lb_UserName_Click(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sidebar_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Parent = P_MainRouting;
            dashboard.Location = new Point(0,0);
            dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dashboard.BringToFront();
        }

        public static Main getInstance()
        {
            if (instance == null) instance = new Main();
            return instance;
        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void Btn_Sidebar_Users_Click(object sender, EventArgs e)
        {
            RouteHandler routeHandler = RouteHandler.getInstance();
            routeHandler.showRoute(new Users());
        }

        private void Btn_Sidebar_History_Click(object sender, EventArgs e)
        {
            RouteHandler.getInstance().showRoute(new History());
        }

        public void updateWorkspaceIndicator()
        {
            Lb_SelectedWorkspace.Text = dataCache.CurrentWorkspace.Name;
        }

        private void Btn_Sidebar_Goals_Click(object sender, EventArgs e)
        {
            RouteHandler.getInstance().showRoute(new Goals());
        }
    }
}
