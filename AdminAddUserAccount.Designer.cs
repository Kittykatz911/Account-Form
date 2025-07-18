namespace CS314App_ahenry
{
    partial class AdminAddUserAccount
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
            this.Add_Admin = new System.Windows.Forms.Button();
            this.Close_Add = new System.Windows.Forms.Button();
            this.roleTXT = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.Label();
            this.usernameTXT = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.TextBox();
            this.addUsername = new System.Windows.Forms.TextBox();
            this.addPassword = new System.Windows.Forms.TextBox();
            this.addRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Add_Admin
            // 
            this.Add_Admin.Location = new System.Drawing.Point(73, 340);
            this.Add_Admin.Name = "Add_Admin";
            this.Add_Admin.Size = new System.Drawing.Size(110, 44);
            this.Add_Admin.TabIndex = 0;
            this.Add_Admin.Text = "Add user";
            this.Add_Admin.UseVisualStyleBackColor = true;
            this.Add_Admin.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // Close_Add
            // 
            this.Close_Add.Location = new System.Drawing.Point(212, 340);
            this.Close_Add.Name = "Close_Add";
            this.Close_Add.Size = new System.Drawing.Size(109, 44);
            this.Close_Add.TabIndex = 1;
            this.Close_Add.Text = "Close";
            this.Close_Add.UseVisualStyleBackColor = true;
            this.Close_Add.Click += new System.EventHandler(this.CloseAddUser_Click);
            // 
            // roleTXT
            // 
            this.roleTXT.AutoSize = true;
            this.roleTXT.Location = new System.Drawing.Point(93, 75);
            this.roleTXT.Name = "roleTXT";
            this.roleTXT.Size = new System.Drawing.Size(32, 13);
            this.roleTXT.TabIndex = 2;
            this.roleTXT.Text = "Role:";
            // 
            // nameTXT
            // 
            this.nameTXT.AutoSize = true;
            this.nameTXT.Location = new System.Drawing.Point(93, 138);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(38, 13);
            this.nameTXT.TabIndex = 3;
            this.nameTXT.Text = "Name:";
            // 
            // usernameTXT
            // 
            this.usernameTXT.AutoSize = true;
            this.usernameTXT.Location = new System.Drawing.Point(91, 191);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(58, 13);
            this.usernameTXT.TabIndex = 4;
            this.usernameTXT.Text = "Username:";
            // 
            // passwordTXT
            // 
            this.passwordTXT.AutoSize = true;
            this.passwordTXT.Location = new System.Drawing.Point(93, 250);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(56, 13);
            this.passwordTXT.TabIndex = 5;
            this.passwordTXT.Text = "Password:";
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(221, 138);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(100, 20);
            this.addName.TabIndex = 7;
            // 
            // addUsername
            // 
            this.addUsername.Location = new System.Drawing.Point(221, 191);
            this.addUsername.Name = "addUsername";
            this.addUsername.Size = new System.Drawing.Size(100, 20);
            this.addUsername.TabIndex = 8;
            // 
            // addPassword
            // 
            this.addPassword.Location = new System.Drawing.Point(221, 243);
            this.addPassword.Name = "addPassword";
            this.addPassword.PasswordChar = '*';
            this.addPassword.Size = new System.Drawing.Size(100, 20);
            this.addPassword.TabIndex = 9;
            // 
            // addRole
            // 
            this.addRole.AllowDrop = true;
            this.addRole.FormattingEnabled = true;
            this.addRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.addRole.Location = new System.Drawing.Point(221, 75);
            this.addRole.Name = "addRole";
            this.addRole.Size = new System.Drawing.Size(121, 21);
            this.addRole.TabIndex = 10;
            this.addRole.Click += new System.EventHandler(this.addRole_Click);
            // 
            // AdminAddUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 396);
            this.Controls.Add(this.addRole);
            this.Controls.Add(this.addPassword);
            this.Controls.Add(this.addUsername);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.usernameTXT);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.roleTXT);
            this.Controls.Add(this.Close_Add);
            this.Controls.Add(this.Add_Admin);
            this.Name = "AdminAddUserAccount";
            this.Text = "Admin - Add User Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Admin;
        private System.Windows.Forms.Button Close_Add;
        private System.Windows.Forms.Label roleTXT;
        private System.Windows.Forms.Label nameTXT;
        private System.Windows.Forms.Label usernameTXT;
        private System.Windows.Forms.Label passwordTXT;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.TextBox addUsername;
        private System.Windows.Forms.TextBox addPassword;
        private System.Windows.Forms.ComboBox addRole;
    }
}