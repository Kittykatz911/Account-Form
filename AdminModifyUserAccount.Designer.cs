namespace CS314App_ahenry
{
    partial class AdminModifyUserAccount
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
            this.Update_Account = new System.Windows.Forms.Button();
            this.Close_Modify = new System.Windows.Forms.Button();
            this.accountsTxt = new System.Windows.Forms.Label();
            this.roleTxt = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newRole = new System.Windows.Forms.ComboBox();
            this.accountSelection = new System.Windows.Forms.ComboBox();
            this.passwordTxt = new System.Windows.Forms.Label();
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.UpdatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Update_Account
            // 
            this.Update_Account.Location = new System.Drawing.Point(72, 376);
            this.Update_Account.Name = "Update_Account";
            this.Update_Account.Size = new System.Drawing.Size(113, 39);
            this.Update_Account.TabIndex = 0;
            this.Update_Account.Text = "Update Account";
            this.Update_Account.UseVisualStyleBackColor = true;
            this.Update_Account.Click += new System.EventHandler(this.UpdateAccount_Click);
            // 
            // Close_Modify
            // 
            this.Close_Modify.Location = new System.Drawing.Point(215, 376);
            this.Close_Modify.Name = "Close_Modify";
            this.Close_Modify.Size = new System.Drawing.Size(113, 39);
            this.Close_Modify.TabIndex = 1;
            this.Close_Modify.Text = "Close";
            this.Close_Modify.UseVisualStyleBackColor = true;
            this.Close_Modify.Click += new System.EventHandler(this.CloseModifyAccount_Click);
            // 
            // accountsTxt
            // 
            this.accountsTxt.AutoSize = true;
            this.accountsTxt.Location = new System.Drawing.Point(52, 69);
            this.accountsTxt.Name = "accountsTxt";
            this.accountsTxt.Size = new System.Drawing.Size(77, 13);
            this.accountsTxt.TabIndex = 2;
            this.accountsTxt.Text = "User Accounts";
            // 
            // roleTxt
            // 
            this.roleTxt.AutoSize = true;
            this.roleTxt.Location = new System.Drawing.Point(15, 16);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(32, 13);
            this.roleTxt.TabIndex = 3;
            this.roleTxt.Text = "Role:";
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Location = new System.Drawing.Point(15, 63);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(38, 13);
            this.nameTxt.TabIndex = 4;
            this.nameTxt.Text = "Name:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.Location = new System.Drawing.Point(15, 115);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(58, 13);
            this.usernameTxt.TabIndex = 5;
            this.usernameTxt.Text = "Username:";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(131, 56);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(100, 20);
            this.newName.TabIndex = 6;
            // 
            // newUsername
            // 
            this.newUsername.Location = new System.Drawing.Point(131, 108);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(100, 20);
            this.newUsername.TabIndex = 7;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(131, 160);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(100, 20);
            this.newPassword.TabIndex = 8;
            // 
            // newRole
            // 
            this.newRole.FormattingEnabled = true;
            this.newRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.newRole.Location = new System.Drawing.Point(131, 8);
            this.newRole.Name = "newRole";
            this.newRole.Size = new System.Drawing.Size(121, 21);
            this.newRole.TabIndex = 9;
            this.newRole.Click += new System.EventHandler(this.newRole_Click);
            // 
            // accountSelection
            // 
            this.accountSelection.FormattingEnabled = true;
            this.accountSelection.Location = new System.Drawing.Point(168, 69);
            this.accountSelection.Name = "accountSelection";
            this.accountSelection.Size = new System.Drawing.Size(121, 21);
            this.accountSelection.TabIndex = 10;
            this.accountSelection.SelectedIndexChanged += new System.EventHandler(this.accountSelection_SelectedIndexChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.AutoSize = true;
            this.passwordTxt.Location = new System.Drawing.Point(15, 167);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(56, 13);
            this.passwordTxt.TabIndex = 11;
            this.passwordTxt.Text = "Password:";
            // 
            // UpdatePanel
            // 
            this.UpdatePanel.Controls.Add(this.roleTxt);
            this.UpdatePanel.Controls.Add(this.passwordTxt);
            this.UpdatePanel.Controls.Add(this.newPassword);
            this.UpdatePanel.Controls.Add(this.newRole);
            this.UpdatePanel.Controls.Add(this.newUsername);
            this.UpdatePanel.Controls.Add(this.nameTxt);
            this.UpdatePanel.Controls.Add(this.newName);
            this.UpdatePanel.Controls.Add(this.usernameTxt);
            this.UpdatePanel.Location = new System.Drawing.Point(37, 126);
            this.UpdatePanel.Name = "UpdatePanel";
            this.UpdatePanel.Size = new System.Drawing.Size(291, 206);
            this.UpdatePanel.TabIndex = 12;
            // 
            // AdminModifyUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 446);
            this.Controls.Add(this.UpdatePanel);
            this.Controls.Add(this.accountSelection);
            this.Controls.Add(this.accountsTxt);
            this.Controls.Add(this.Close_Modify);
            this.Controls.Add(this.Update_Account);
            this.Name = "AdminModifyUserAccount";
            this.Text = "Admin - Modify User Account";
            this.UpdatePanel.ResumeLayout(false);
            this.UpdatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_Account;
        private System.Windows.Forms.Button Close_Modify;
        private System.Windows.Forms.Label accountsTxt;
        private System.Windows.Forms.Label roleTxt;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.ComboBox newRole;
        private System.Windows.Forms.ComboBox accountSelection;
        private System.Windows.Forms.Label passwordTxt;
        private System.Windows.Forms.Panel UpdatePanel;
    }
}