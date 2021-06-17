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
    public partial class Register : Form
    {

        DBManager dBManager;
        private bool registerSuccessfully; 

        public Register()
        {
            InitializeComponent();
            this.dBManager = DBManager.getInstance();
            dBManager.connect();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {

            Timer resultTimer = new Timer();
            string userName = Tb_Name.Text;
            string userEmail = Tb_Email.Text;
            string userPassword = Tb_Password.Text;

            SqlParameter[] sqlParameters = {
                new SqlParameter("@Name", userName),
                new SqlParameter("@Email", userEmail),
                new SqlParameter("@Password", userPassword)
            };

            resultTimer.Interval = 3000;
            resultTimer.Tick += (s, args) =>
            {
                Lb_RegisterResult.Visible = false;

                if (registerSuccessfully)
                {
                    this.Hide();
                    Login login = new Login();
                    login.Closed += (s, args) => this.Close();
                    login.Show();
                }

                resultTimer.Stop();

            };

            dBManager.open();

            SqlParameterCollection resultParams = dBManager.executeSP("Wellet.CreateUser", sqlParameters);

            if (resultParams != null)
            {
                Lb_RegisterResult.Visible = true;
                Lb_RegisterResult.Text = "Successfully registered!";
                resultTimer.Start();
                registerSuccessfully = true;

            } 
            else
            {
                Lb_RegisterResult.Visible = true;
                Lb_RegisterResult.Text = "Error during registration. Try again...";
                resultTimer.Start();
                registerSuccessfully = false;
            }

            dBManager.close();

        }

    }
}
