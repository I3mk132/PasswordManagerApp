using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public clsUser user;
        private void btnDoLogin_Click(object sender, EventArgs e)
        {
            string Email = mtxtLoginEmail.Text;
            string Password = mtxtLoginPassword.Text;
            user = clsUser.CheckAccount(Email, Password);
            
            if (user == null)
            {

                MessageBox.Show("Email Or Password is Invalid");
            }
            else
            {
                this.Close();
            }
        }

        private void btnDoCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            mtxtLoginPassword.UseSystemPasswordChar = (!chkViewPassword.Checked);
        }

    }
}
