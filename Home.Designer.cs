namespace CS314App_ahenry
{
    partial class Home
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
            this.Add_User = new System.Windows.Forms.Button();
            this.Modify_User = new System.Windows.Forms.Button();
            this.Sign_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_User
            // 
            this.Add_User.Location = new System.Drawing.Point(43, 50);
            this.Add_User.Name = "Add_User";
            this.Add_User.Size = new System.Drawing.Size(186, 78);
            this.Add_User.TabIndex = 0;
            this.Add_User.Text = "Add New User Account";
            this.Add_User.UseVisualStyleBackColor = true;
            this.Add_User.Visible = false;
            this.Add_User.Click += new System.EventHandler(this.AddAdminUser_Click);
            // 
            // Modify_User
            // 
            this.Modify_User.Location = new System.Drawing.Point(455, 50);
            this.Modify_User.Name = "Modify_User";
            this.Modify_User.Size = new System.Drawing.Size(168, 78);
            this.Modify_User.TabIndex = 1;
            this.Modify_User.Text = "Modify New User Account";
            this.Modify_User.UseVisualStyleBackColor = true;
            this.Modify_User.Visible = false;
            this.Modify_User.Click += new System.EventHandler(this.ModifyAdminUser_Click);
            // 
            // Sign_Out
            // 
            this.Sign_Out.Location = new System.Drawing.Point(260, 345);
            this.Sign_Out.Name = "Sign_Out";
            this.Sign_Out.Size = new System.Drawing.Size(168, 78);
            this.Sign_Out.TabIndex = 2;
            this.Sign_Out.Text = "Sign Out";
            this.Sign_Out.UseVisualStyleBackColor = true;
            this.Sign_Out.Visible = false;
            this.Sign_Out.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 461);
            this.Controls.Add(this.Sign_Out);
            this.Controls.Add(this.Modify_User);
            this.Controls.Add(this.Add_User);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.TextChanged += new System.EventHandler(this.FormType);
        }

        #endregion

        private System.Windows.Forms.Button Add_User;
        private System.Windows.Forms.Button Modify_User;
        private System.Windows.Forms.Button Sign_Out;
    }
}