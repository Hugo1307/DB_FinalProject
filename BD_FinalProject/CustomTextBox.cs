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
    public partial class CustomTextBox : Form
    {
        public CustomTextBox(string title, string message)
        {
            InitializeComponent();
            Lb_Title.Text = title;
            Lb_Body.Text = message;
        }

        private void Pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
