using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class AddEditRowForm : Form
    {
        public AddEditRowForm(int RecordID)
        {
            InitializeComponent();

            _RecordID = RecordID;

            if (RecordID != -1)
            { 
                _Mode = enMode.Update;
            }
            else
            {
                _Mode = enMode.AddNew;
            }
        }

        private clsRecord _record;
        private int _RecordID;
        enum enMode { AddNew, Update }
        enMode _Mode;


        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {
                lblAddEdit.Text = "Add New Content";
                _record = new clsRecord();
                return;
            }
            _record = clsRecord.Find(_RecordID);

            if (_record == null)
            {
                MessageBox.Show("This form will be closed because No Content with this data");
                this.Close();
                return;
            }

            lblAddEdit.Text = "Edit RecordID = " + _RecordID;
            lblID.Text = _RecordID.ToString();
            lblDate.Text = _record.Date.ToString();
            lblUser.Text = clsUser.Find(Convert.ToInt32(this.Tag)).Username;
            mtxtEmail.Text = _record.Email;
            mtxtUsername.Text = _record.Username;
            mtxtPassword.Text = _record.Password;
            mtxtNote.Text = _record.Note;

        }
        private void btnAddRecord_Click(object sender, EventArgs e)
        {


            _record.Date = DateTime.Now;
            _record.UserID = Convert.ToInt32(this.Tag);
            _record.Email = mtxtEmail.Text;
            _record.Username = mtxtUsername.Text;
            _record.Password = mtxtPassword.Text;
            _record.Note = mtxtNote.Text;
            

            if (_record.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully. ");
            }

            this.Close();


        }

        private void AddEditRow_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnRecordCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
                mtxtPassword.UseSystemPasswordChar = (!chkViewPassword.Checked);
        }
    }
}
