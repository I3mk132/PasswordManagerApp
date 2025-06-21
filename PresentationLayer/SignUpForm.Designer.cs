namespace PresentationLayer
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtSignEmail = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtSignUsename = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtSignPassword2 = new System.Windows.Forms.MaskedTextBox();
            this.btnDoCancel = new System.Windows.Forms.Button();
            this.btnDoSignUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtSignPassword = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkViewPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter email: ";
            // 
            // mtxtSignEmail
            // 
            this.mtxtSignEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSignEmail.Location = new System.Drawing.Point(261, 56);
            this.mtxtSignEmail.Name = "mtxtSignEmail";
            this.mtxtSignEmail.Size = new System.Drawing.Size(209, 32);
            this.mtxtSignEmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter username: ";
            // 
            // mtxtSignUsename
            // 
            this.mtxtSignUsename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSignUsename.Location = new System.Drawing.Point(261, 104);
            this.mtxtSignUsename.Name = "mtxtSignUsename";
            this.mtxtSignUsename.Size = new System.Drawing.Size(209, 32);
            this.mtxtSignUsename.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter password: ";
            // 
            // mtxtSignPassword2
            // 
            this.mtxtSignPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSignPassword2.Location = new System.Drawing.Point(261, 200);
            this.mtxtSignPassword2.Name = "mtxtSignPassword2";
            this.mtxtSignPassword2.Size = new System.Drawing.Size(207, 32);
            this.mtxtSignPassword2.TabIndex = 3;
            this.mtxtSignPassword2.UseSystemPasswordChar = true;
            // 
            // btnDoCancel
            // 
            this.btnDoCancel.Location = new System.Drawing.Point(185, 276);
            this.btnDoCancel.Name = "btnDoCancel";
            this.btnDoCancel.Size = new System.Drawing.Size(141, 47);
            this.btnDoCancel.TabIndex = 5;
            this.btnDoCancel.Text = "Cancel";
            this.btnDoCancel.UseVisualStyleBackColor = true;
            this.btnDoCancel.Click += new System.EventHandler(this.btnDoCancel_Click);
            // 
            // btnDoSignUp
            // 
            this.btnDoSignUp.Location = new System.Drawing.Point(338, 276);
            this.btnDoSignUp.Name = "btnDoSignUp";
            this.btnDoSignUp.Size = new System.Drawing.Size(150, 47);
            this.btnDoSignUp.TabIndex = 4;
            this.btnDoSignUp.Text = "SignUp";
            this.btnDoSignUp.UseVisualStyleBackColor = true;
            this.btnDoSignUp.Click += new System.EventHandler(this.btnDoSignUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter password again: ";
            // 
            // mtxtSignPassword
            // 
            this.mtxtSignPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSignPassword.Location = new System.Drawing.Point(261, 152);
            this.mtxtSignPassword.Name = "mtxtSignPassword";
            this.mtxtSignPassword.Size = new System.Drawing.Size(207, 32);
            this.mtxtSignPassword.TabIndex = 2;
            this.mtxtSignPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "SignUp";
            // 
            // chkViewPassword
            // 
            this.chkViewPassword.AutoSize = true;
            this.chkViewPassword.Location = new System.Drawing.Point(474, 161);
            this.chkViewPassword.Name = "chkViewPassword";
            this.chkViewPassword.Size = new System.Drawing.Size(15, 14);
            this.chkViewPassword.TabIndex = 19;
            this.chkViewPassword.UseVisualStyleBackColor = true;
            this.chkViewPassword.CheckedChanged += new System.EventHandler(this.chkViewPassword_CheckedChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 335);
            this.Controls.Add(this.chkViewPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtSignPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDoSignUp);
            this.Controls.Add(this.btnDoCancel);
            this.Controls.Add(this.mtxtSignPassword2);
            this.Controls.Add(this.mtxtSignUsename);
            this.Controls.Add(this.mtxtSignEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtSignEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtSignUsename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtSignPassword2;
        private System.Windows.Forms.Button btnDoCancel;
        private System.Windows.Forms.Button btnDoSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtSignPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkViewPassword;
    }
}