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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        
        private bool ComparePasswords(string s1, string s2)
        {
            return s1.Equals(s2);
        }

        public bool UserAdded = false;
        private void btnDoSignUp_Click(object sender, EventArgs e)
        {

            clsUser User = new clsUser();
            User.Email = mtxtSignEmail.Text;
            User.Username = mtxtSignUsename.Text;

            if (ComparePasswords(mtxtSignPassword.Text, mtxtSignPassword2.Text))
            {
                User.Password = clsUser.HashPassword(mtxtSignPassword.Text);
                if (User.Save())
                {
                    UserAdded = true;
                    this.Close();
                }
                else
                {
                    UserAdded = false;
                    MessageBox.Show("User Couldnt be saved. ");
                }
            }
            else
            {
                UserAdded = false;
                MessageBox.Show("Password isnt match. ");
            }   
            
        }

        private void btnDoCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            mtxtSignPassword.UseSystemPasswordChar = (!chkViewPassword.Checked);
            mtxtSignPassword2.UseSystemPasswordChar = (!chkViewPassword.Checked);
        }
    }
}
