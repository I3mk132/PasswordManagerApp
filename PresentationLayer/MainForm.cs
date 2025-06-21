using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BussinesLayer;
using System.Security.Cryptography;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private clsUser CurrentUser = new clsUser();
        private void _RefreshDataView()
        {
            dataGridView1.DataSource = clsRecord.GetUsersAllRecords(CurrentUser.ID);
            lblResultsCount.Text = "Results Count: " +  dataGridView1.Rows.Count.ToString();
        }
        private void _ConfigLoginUser()
        {
            lblWelcome.Visible = true;
            llEditUser.Text = CurrentUser.Username;
            llEditUser.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnSignUp.Visible = false;
            btnLogin.Visible = false;
            btnLogout.Visible = true;
            btnPasswordGenerator.Visible = true;
        }
        private void _ConfigLogoutUser()
        {
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSignUp.Visible = true;
            btnLogin.Visible = true;
            btnLogout.Visible = false;
            llEditUser.Visible = false;
            llEditUser.Text = "User's Profile";
            lblWelcome.Visible = false;
            btnPasswordGenerator.Visible = false;
        }
        private bool _OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.user != null)
            {
                CurrentUser = loginForm.user;
                _ConfigLoginUser();
            }
            _RefreshDataView();
            return true;
        }
        private bool _OpenSignUpForm()
        {
            SignUpForm frm = new SignUpForm();
            frm.ShowDialog();
            if (frm.UserAdded)
                _OpenLoginForm();
            return true;
        }
        private void _UpdateRecord()
        {
            if (dataGridView1.CurrentRow != null
                &&
                dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                int a = (int)dataGridView1.CurrentRow.Cells[0].Value;
                AddEditRowForm frm = new AddEditRowForm(a);
                frm.Tag = CurrentUser.ID.ToString();
                frm.ShowDialog();
                _RefreshDataView();
            }
        }
        private void _AddRecord()
        {
            AddEditRowForm frm = new AddEditRowForm(-1);
            frm.Tag = CurrentUser.ID.ToString();
            frm.ShowDialog();
            _RefreshDataView();
        
        }
        private void _DeleteRecord()
        {
            if (dataGridView1.CurrentRow != null
                &&
                dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                int a = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (clsRecord.RemoveRecord(a))
                {
                    MessageBox.Show($"Record [{a}] deleted successfully! ");
                }
                else
                {
                    MessageBox.Show("Record couldnt be deleted. ");
                }
                _RefreshDataView();
            }
        }
        private void _ConfigCombobox(string col)
        {
            DataTable dt = clsRecord.GetUsersAllRowsForColumn(CurrentUser.ID, col);

            cbSelectData.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbSelectData.Items.Add(dr[0].ToString());
            }

        }
        private string _CheckedRadioButton;
        private void _RadioChanged(string col)
        {
            _ConfigCombobox(col);
            _CheckedRadioButton = col;
        }
        private void _ApplyFilter()
        {
            DataTable dt;
            if (cbSelectData.Text != "")
            {
                if (txtKeyword.Text != "")
                {
                    dt = clsRecord.GetUsrsAllRecordsUsingColumnAndKeyward(
                        CurrentUser.ID, _CheckedRadioButton, cbSelectData.Text, txtKeyword.Text);
                }
                else
                {
                    dt = clsRecord.GetUsersAllRecordsUsingLike(CurrentUser.ID, cbSelectData.Text);
                }
            }
            else
            {
                dt = clsRecord.GetUsersAllRecordsUsingLike(CurrentUser.ID, txtKeyword.Text);
            }
            dataGridView1.DataSource = dt;
        }
        private void _OpenProfile()
        {
            EditUserFrom frm = new EditUserFrom(CurrentUser.ID);
            frm.ShowDialog();
            CurrentUser = clsUser.Find(CurrentUser.ID);
            llEditUser.Text = CurrentUser.Username;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            _OpenSignUpForm();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _OpenLoginForm();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _AddRecord();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            _RefreshDataView();
        }
        private void llEditUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            _OpenProfile();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _UpdateRecord();
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _DeleteRecord();
            
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser = new clsUser();
            _RefreshDataView();
            _ConfigLogoutUser();
        }
        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            _RadioChanged(rbNone.Tag.ToString());
        }
        private void rbByNote_CheckedChanged(object sender, EventArgs e)
        {
            _RadioChanged(rbByNote.Tag.ToString());
        }
        private void rbByEmail_CheckedChanged(object sender, EventArgs e)
        {
            _RadioChanged(rbByEmail.Tag.ToString());
        }
        private void rbByUsername_CheckedChanged(object sender, EventArgs e)
        {
            _RadioChanged(rbByUsername.Tag.ToString());
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            _ApplyFilter();
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenProfile();
        }
        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddRecord();
        }
        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UpdateRecord();
        }
        private void DeleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteRecord();
        }
        private void btnPasswordGenerator_Click(object sender, EventArgs e)
        {
            PasswordGeneratorForm frm = new PasswordGeneratorForm();
            frm.Show();
        }


    }
}
