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
    public partial class Login : Form
    {

        DBManager dBManager;
        private bool loginSuccessfull;

        public Login()
        {
            InitializeComponent();
            dBManager = DBManager.getInstance();
            dBManager.connect();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

            string userEmail = Tb_Email.Text;
            string userPassword = Tb_Password.Text;

            SqlParameter[] sqlParameters = {
                new SqlParameter("@Email", userEmail),
                new SqlParameter("@Password", userPassword),
                new SqlParameter("@Authorized", SqlDbType.Bit),
                new SqlParameter("@UserName", SqlDbType.VarChar, 256)
            };

            sqlParameters[2].Direction = ParameterDirection.Output;
            sqlParameters[3].Direction = ParameterDirection.Output;

            dBManager.open();

            SqlParameterCollection resultParams = dBManager.executeSP("Wellet.UserLogin", sqlParameters);

            if (resultParams != null)
            {
                loginSuccessfull = Convert.ToBoolean(resultParams["@Authorized"].Value);

                if (loginSuccessfull)
                {

                    string userName = Convert.ToString(resultParams["@UserName"].Value);
                    
                    Timer_Result.Start();
                    Lb_LoginResult.Visible = true;
                    Lb_LoginResult.Text = "Welcome, " + userName + "!";

                    Properties.Settings.Default["UserName"] = userName;
                    Properties.Settings.Default["UserEmail"] = userEmail;
                    Properties.Settings.Default.Save();

                    DataCache dataCache = DataCache.getInstance();
                    DBCommander dBCommander = DBCommander.getInstance();

                    dataCache.CurrentUser = dBCommander.getUserByEmail(userEmail);

                }
                else
                {
                    Timer_Result.Start();
                    Lb_LoginResult.Visible = true;
                    Lb_LoginResult.Text = "Wrong credentials!";
                }

            }

            dBManager.close();

        }

        private void Timer_Result_Tick(object sender, EventArgs e)
        {
            Lb_LoginResult.Visible = false;
            Timer_Result.Stop();

            if (loginSuccessfull)
            {
                this.Hide();
                Main main = Main.getInstance();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }

        }

        private void Lb_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }
    }
}
