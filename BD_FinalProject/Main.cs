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
    public partial class Main : Form
    {

        SqlConnection sqlConn;
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Lb_UserName.Text = Properties.Settings.Default.UserName;
        }

        private void getAllUsers()
        {

            this.sqlConn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Wellet.[User]", this.sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader["Email"].ToString());
            }

            sqlConn.Close();

        }

    }
}
