namespace PresentationLayer
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtLoginPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnDoLogin = new System.Windows.Forms.Button();
            this.btnDoCancel2 = new System.Windows.Forms.Button();
            this.mtxtLoginEmail = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkViewPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Login";
            // 
            // mtxtLoginPassword
            // 
            this.mtxtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtLoginPassword.Location = new System.Drawing.Point(185, 119);
            this.mtxtLoginPassword.Name = "mtxtLoginPassword";
            this.mtxtLoginPassword.Size = new System.Drawing.Size(239, 32);
            this.mtxtLoginPassword.TabIndex = 1;
            this.mtxtLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnDoLogin
            // 
            this.btnDoLogin.Location = new System.Drawing.Point(274, 172);
            this.btnDoLogin.Name = "btnDoLogin";
            this.btnDoLogin.Size = new System.Drawing.Size(150, 47);
            this.btnDoLogin.TabIndex = 2;
            this.btnDoLogin.Text = "Login";
            this.btnDoLogin.UseVisualStyleBackColor = true;
            this.btnDoLogin.Click += new System.EventHandler(this.btnDoLogin_Click);
            // 
            // btnDoCancel2
            // 
            this.btnDoCancel2.Location = new System.Drawing.Point(121, 172);
            this.btnDoCancel2.Name = "btnDoCancel2";
            this.btnDoCancel2.Size = new System.Drawing.Size(141, 47);
            this.btnDoCancel2.TabIndex = 3;
            this.btnDoCancel2.Text = "Cancel";
            this.btnDoCancel2.UseVisualStyleBackColor = true;
            this.btnDoCancel2.Click += new System.EventHandler(this.btnDoCancel2_Click);
            // 
            // mtxtLoginEmail
            // 
            this.mtxtLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtLoginEmail.Location = new System.Drawing.Point(185, 75);
            this.mtxtLoginEmail.Name = "mtxtLoginEmail";
            this.mtxtLoginEmail.Size = new System.Drawing.Size(239, 32);
            this.mtxtLoginEmail.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter email: ";
            // 
            // chkViewPassword
            // 
            this.chkViewPassword.AutoSize = true;
            this.chkViewPassword.Location = new System.Drawing.Point(434, 129);
            this.chkViewPassword.Name = "chkViewPassword";
            this.chkViewPassword.Size = new System.Drawing.Size(15, 14);
            this.chkViewPassword.TabIndex = 18;
            this.chkViewPassword.UseVisualStyleBackColor = true;
            this.chkViewPassword.CheckedChanged += new System.EventHandler(this.chkViewPassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 241);
            this.Controls.Add(this.chkViewPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtLoginPassword);
            this.Controls.Add(this.btnDoLogin);
            this.Controls.Add(this.btnDoCancel2);
            this.Controls.Add(this.mtxtLoginEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtLoginPassword;
        private System.Windows.Forms.Button btnDoLogin;
        private System.Windows.Forms.Button btnDoCancel2;
        private System.Windows.Forms.MaskedTextBox mtxtLoginEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkViewPassword;
    }
}