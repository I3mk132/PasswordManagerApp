using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace PresentationLayer
{
    public partial class EditUserFrom : Form
    {
        public EditUserFrom(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            
        }
        private int _UserID;
        private clsUser _User;

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No Content with this data");
                this.Close();
                return;
            }

            lblID.Text = _UserID.ToString();
            mtxtUserEmail.Text = _User.Email;
            mtxtUserUsername.Text = _User.Username;
            

        }
        private bool _CheckOldPaasword(string old)
        {
            old = clsUser.HashPassword(old);
            return old == _User.Password;
        }
        private bool _ComparePasswords(string s1, string s2)
        {
            return s1.Equals(s2);
        }
        private void _ApplyChanges()
        {
            _User.Email = mtxtUserEmail.Text;
            _User.Username = mtxtUserUsername.Text;
            
            if (_CheckOldPaasword(mtxtUserOldPassword.Text))
            {
                if (_ComparePasswords(mtxtUserPassword.Text, mtxtUserPassword2.Text))
                {
                    _User.Password = clsUser.HashPassword(mtxtUserPassword.Text);

                    if (_User.Save())
                    {
                        MessageBox.Show("User added successfully. ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong with saving. ");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords isn't match.");
                }
            }
            else
            {
                MessageBox.Show("Old Password is Invalid");
            }
        }
        private void btnApplyEditProfile_Click(object sender, EventArgs e)
        {
            _ApplyChanges();
        }

        private void btnCancelEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUserFrom_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void chkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            mtxtUserPassword.UseSystemPasswordChar = (!chkViewPassword.Checked);
            mtxtUserPassword2.UseSystemPasswordChar = (!chkViewPassword.Checked);
            mtxtUserOldPassword.UseSystemPasswordChar = (!chkViewPassword.Checked);
        }
    }
}
