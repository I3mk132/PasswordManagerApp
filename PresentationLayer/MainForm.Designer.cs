namespace PresentationLayer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.cbSelectData = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbByUsername = new System.Windows.Forms.RadioButton();
            this.rbByEmail = new System.Windows.Forms.RadioButton();
            this.rbByNote = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.llEditUser = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.getHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblResultsCount = new System.Windows.Forms.Label();
            this.btnPasswordGenerator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(116, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(692, 388);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.editRecordToolStripMenuItem,
            this.DeleteRecordToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(148, 70);
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addRecordToolStripMenuItem.Text = "Add Record";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // editRecordToolStripMenuItem
            // 
            this.editRecordToolStripMenuItem.Name = "editRecordToolStripMenuItem";
            this.editRecordToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editRecordToolStripMenuItem.Text = "Edit Record";
            this.editRecordToolStripMenuItem.Click += new System.EventHandler(this.editRecordToolStripMenuItem_Click);
            // 
            // DeleteRecordToolStripMenuItem
            // 
            this.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem";
            this.DeleteRecordToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.DeleteRecordToolStripMenuItem.Text = "Delete Record";
            this.DeleteRecordToolStripMenuItem.Click += new System.EventHandler(this.DeleteRecordToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 54);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 54);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 54);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(456, 15);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(258, 32);
            this.txtKeyword.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(720, 15);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(73, 32);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 352);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(12, 323);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(86, 23);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // cbSelectData
            // 
            this.cbSelectData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectData.FormattingEnabled = true;
            this.cbSelectData.Location = new System.Drawing.Point(116, 14);
            this.cbSelectData.Name = "cbSelectData";
            this.cbSelectData.Size = new System.Drawing.Size(238, 33);
            this.cbSelectData.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Keyword:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select:";
            // 
            // rbByUsername
            // 
            this.rbByUsername.AutoSize = true;
            this.rbByUsername.Location = new System.Drawing.Point(93, 49);
            this.rbByUsername.Name = "rbByUsername";
            this.rbByUsername.Size = new System.Drawing.Size(88, 17);
            this.rbByUsername.TabIndex = 17;
            this.rbByUsername.TabStop = true;
            this.rbByUsername.Tag = "Username";
            this.rbByUsername.Text = "By Username";
            this.rbByUsername.UseVisualStyleBackColor = true;
            this.rbByUsername.CheckedChanged += new System.EventHandler(this.rbByUsername_CheckedChanged);
            // 
            // rbByEmail
            // 
            this.rbByEmail.AutoSize = true;
            this.rbByEmail.Location = new System.Drawing.Point(187, 49);
            this.rbByEmail.Name = "rbByEmail";
            this.rbByEmail.Size = new System.Drawing.Size(65, 17);
            this.rbByEmail.TabIndex = 18;
            this.rbByEmail.TabStop = true;
            this.rbByEmail.Tag = "Email";
            this.rbByEmail.Text = "By Email";
            this.rbByEmail.UseVisualStyleBackColor = true;
            this.rbByEmail.CheckedChanged += new System.EventHandler(this.rbByEmail_CheckedChanged);
            // 
            // rbByNote
            // 
            this.rbByNote.AutoSize = true;
            this.rbByNote.Location = new System.Drawing.Point(258, 49);
            this.rbByNote.Name = "rbByNote";
            this.rbByNote.Size = new System.Drawing.Size(63, 17);
            this.rbByNote.TabIndex = 19;
            this.rbByNote.TabStop = true;
            this.rbByNote.Tag = "Note";
            this.rbByNote.Text = "By Note";
            this.rbByNote.UseVisualStyleBackColor = true;
            this.rbByNote.CheckedChanged += new System.EventHandler(this.rbByNote_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(330, 49);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 20;
            this.rbNone.TabStop = true;
            this.rbNone.Tag = "None";
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(8, 378);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(101, 24);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.Text = "Welcome: ";
            this.lblWelcome.Visible = false;
            // 
            // llEditUser
            // 
            this.llEditUser.AutoSize = true;
            this.llEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llEditUser.Location = new System.Drawing.Point(8, 402);
            this.llEditUser.MaximumSize = new System.Drawing.Size(102, 0);
            this.llEditUser.Name = "llEditUser";
            this.llEditUser.Size = new System.Drawing.Size(102, 20);
            this.llEditUser.TabIndex = 22;
            this.llEditUser.TabStop = true;
            this.llEditUser.Text = "User\'s Profile";
            this.llEditUser.Visible = false;
            this.llEditUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEditUser_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.getHelpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 70);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "Select Theme";
            // 
            // getHelpToolStripMenuItem
            // 
            this.getHelpToolStripMenuItem.Name = "getHelpToolStripMenuItem";
            this.getHelpToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.getHelpToolStripMenuItem.Text = "GetHelp";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 433);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 23);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblResultsCount
            // 
            this.lblResultsCount.AutoSize = true;
            this.lblResultsCount.Location = new System.Drawing.Point(672, 53);
            this.lblResultsCount.Name = "lblResultsCount";
            this.lblResultsCount.Size = new System.Drawing.Size(79, 13);
            this.lblResultsCount.TabIndex = 24;
            this.lblResultsCount.Text = "Results Count: ";
            // 
            // btnPasswordGenerator
            // 
            this.btnPasswordGenerator.Location = new System.Drawing.Point(11, 284);
            this.btnPasswordGenerator.Name = "btnPasswordGenerator";
            this.btnPasswordGenerator.Size = new System.Drawing.Size(98, 91);
            this.btnPasswordGenerator.TabIndex = 25;
            this.btnPasswordGenerator.Text = "Password generator";
            this.btnPasswordGenerator.UseVisualStyleBackColor = true;
            this.btnPasswordGenerator.Visible = false;
            this.btnPasswordGenerator.Click += new System.EventHandler(this.btnPasswordGenerator_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(813, 468);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblResultsCount);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.llEditUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbByNote);
            this.Controls.Add(this.rbByEmail);
            this.Controls.Add(this.rbByUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectData);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPasswordGenerator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ComboBox cbSelectData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbByUsername;
        private System.Windows.Forms.RadioButton rbByEmail;
        private System.Windows.Forms.RadioButton rbByNote;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel llEditUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteRecordToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblResultsCount;
        private System.Windows.Forms.Button btnPasswordGenerator;
    }
}

