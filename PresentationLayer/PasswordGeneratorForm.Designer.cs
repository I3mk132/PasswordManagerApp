namespace PresentationLayer
{
    partial class PasswordGeneratorForm
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TrackBar();
            this.chkHasNumbers = new System.Windows.Forms.CheckBox();
            this.chkHasSpecialCharacters = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(21, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(428, 32);
            this.txtPassword.TabIndex = 0;
            // 
            // tbLength
            // 
            this.tbLength.LargeChange = 2;
            this.tbLength.Location = new System.Drawing.Point(21, 50);
            this.tbLength.Maximum = 30;
            this.tbLength.Minimum = 8;
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(428, 45);
            this.tbLength.TabIndex = 1;
            this.tbLength.Value = 8;
            this.tbLength.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // chkHasNumbers
            // 
            this.chkHasNumbers.AutoSize = true;
            this.chkHasNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasNumbers.Location = new System.Drawing.Point(17, 101);
            this.chkHasNumbers.Name = "chkHasNumbers";
            this.chkHasNumbers.Size = new System.Drawing.Size(120, 30);
            this.chkHasNumbers.TabIndex = 2;
            this.chkHasNumbers.Text = "Numbers";
            this.chkHasNumbers.UseVisualStyleBackColor = true;
            this.chkHasNumbers.CheckedChanged += new System.EventHandler(this.chkHasNumbers_CheckedChanged);
            // 
            // chkHasSpecialCharacters
            // 
            this.chkHasSpecialCharacters.AutoSize = true;
            this.chkHasSpecialCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasSpecialCharacters.Location = new System.Drawing.Point(17, 137);
            this.chkHasSpecialCharacters.Name = "chkHasSpecialCharacters";
            this.chkHasSpecialCharacters.Size = new System.Drawing.Size(210, 30);
            this.chkHasSpecialCharacters.TabIndex = 4;
            this.chkHasSpecialCharacters.Text = "Special characters";
            this.chkHasSpecialCharacters.UseVisualStyleBackColor = true;
            this.chkHasSpecialCharacters.CheckedChanged += new System.EventHandler(this.chkHasSpecialCharacters_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(344, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(299, 98);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(90, 26);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Length :";
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 185);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkHasSpecialCharacters);
            this.Controls.Add(this.chkHasNumbers);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.txtPassword);
            this.Name = "PasswordGeneratorForm";
            this.Text = "PasswordGeneratorForm";
            this.Load += new System.EventHandler(this.PasswordGeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TrackBar tbLength;
        private System.Windows.Forms.CheckBox chkHasNumbers;
        private System.Windows.Forms.CheckBox chkHasSpecialCharacters;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLength;
    }
}