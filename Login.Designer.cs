namespace CS314App_ahenry
{
    partial class Login
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
            this.login_button = new System.Windows.Forms.Button();
            this.quit_button = new System.Windows.Forms.Button();
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.Label();
            this.Invalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(132, 207);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.Login_Click);
            // 
            // quit_button
            // 
            this.quit_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quit_button.Location = new System.Drawing.Point(132, 271);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(75, 23);
            this.quit_button.TabIndex = 1;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.Quit_Click);
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(121, 80);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(100, 20);
            this.username_input.TabIndex = 2;
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(121, 135);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(100, 20);
            this.password_input.TabIndex = 3;
            // 
            // username_textbox
            // 
            this.username_textbox.AutoSize = true;
            this.username_textbox.Location = new System.Drawing.Point(45, 83);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(58, 13);
            this.username_textbox.TabIndex = 4;
            this.username_textbox.Text = "Username:";
            // 
            // password_textbox
            // 
            this.password_textbox.AutoSize = true;
            this.password_textbox.Location = new System.Drawing.Point(45, 138);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(56, 13);
            this.password_textbox.TabIndex = 5;
            this.password_textbox.Text = "Password:";
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.ForeColor = System.Drawing.Color.Red;
            this.Invalid.Location = new System.Drawing.Point(101, 167);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(147, 13);
            this.Invalid.TabIndex = 6;
            this.Invalid.Text = "Invalid username or password";
            this.Invalid.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quit_button;
            this.ClientSize = new System.Drawing.Size(334, 336);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.login_button);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label username_textbox;
        private System.Windows.Forms.Label password_textbox;
        private System.Windows.Forms.Label Invalid;
    }
}