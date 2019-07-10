using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson10._07._2019Windowsform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void chshowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chshowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "Resad";
            username = txtUsername.Text.Trim();
            string password = "12345";
            password = txtPassword.Text.Trim();
            if (username=="Resad" && password=="12345")
            {
                MessageBox.Show("Duzdur");
            }
            else if(username != "Resad")
            {
                MessageBox.Show("Adinizi duzgun daxil edin!");
            }
            else
            {
                MessageBox.Show("Parolunuzu duzgun daxil edin!");
            }
      

        }
    }
}
