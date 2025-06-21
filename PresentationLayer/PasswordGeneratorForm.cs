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
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }
        clsGenerator generator = new clsGenerator();
        private string _Password = "";
        private short _Length = 8;
        private void _UpdatePassword()
        {
            _Password = generator.GeneratePassword(_Length);
            txtPassword.Text = _Password.ToString();
            lblLength.Text = "Length: " + _Length.ToString();
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _Length = Convert.ToInt16(tbLength.Value);
            _UpdatePassword();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordGeneratorForm_Load(object sender, EventArgs e)
        {
            generator.HasSpecialCharacters = false;
            generator.HasNumbers = false;

            _UpdatePassword();
        }

        private void chkHasNumbers_CheckedChanged(object sender, EventArgs e)
        {
            generator.HasNumbers = (chkHasNumbers.Checked);
            _UpdatePassword();
        }

        private void chkHasSpecialCharacters_CheckedChanged(object sender, EventArgs e)
        {
            generator.HasSpecialCharacters= (chkHasSpecialCharacters.Checked);
            _UpdatePassword();
        }

    }
}
