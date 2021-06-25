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
    public partial class UserPanel : UserControl
    {

        private User user;
        private bool showDeleteButton;

        public User User { get => user; set => user = value; }

        public UserPanel(User user, bool showDeleteButton)
        {
            InitializeComponent();
            this.user = user;

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            Lb_UserName.Text = user.Name;
            Lb_UserEmail.Text = user.Email;

            if (user.ImagePath != null && user.ImagePath != "")
                Pb_UserPicture.Image = Image.FromFile(user.ImagePath);
            else
                Pb_UserPicture.Image = Properties.Resources.user_icon_black;

            if (!showDeleteButton) Pb_DeleteUser.Visible = false;

        }

        private void Pb_DeleteUser_Click(object sender, EventArgs e)
        {

        }
    }

}
