using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS314App_ahenry
{
    public partial class Login : Form
    {
        // Create member variables for child forms:

        Home Home_form;

        public Login()
        {
            InitializeComponent();
        }

        // there will only ONE home form (modify the title)
        private void Login_Click(object sender, EventArgs e)
        {
            // make string variables for comparison:

            String user_name1 = "admin";
            String pass1 = "admin1";
            String user_name2 = "user1";
            String pass2 = "user123";
            
            // verify correct login:
            bool verified = ((username_input.Text == user_name1 && password_input.Text == pass1) || (username_input.Text == user_name2 && password_input.Text == pass2));
            
            // boolean variables for diiferent output messages:
            bool admin_login = (username_input.Text == user_name1 && password_input.Text == pass1);
            bool norm_login = (username_input.Text == user_name2 && password_input.Text == pass2);

            if (verified) // checking verification
            {
                if (norm_login) // print special message for normal user login
                {
                    Console.WriteLine("Credentials correct! Logging in as normal user...");
                    // Make sure Home form instance doesn't exist yet:
                    if (Home_form == null || Home_form.IsDisposed)
                    {
                        // create the form
                        Home_form = new Home();
                        this.Home_form.FormClosed += Logout_FormClosed; // creating logout event of homeform
                    }
                    Home_form.Text = "Home";
                    this.Hide();
                    Home_form.ShowDialog();
                }
                else if (admin_login) // print special message for admin user login
                {
                    Console.WriteLine("Credentials correct! logging in as admin...");
                    if (Home_form == null || Home_form.IsDisposed)
                    {
                        Home_form = new Home();
                        this.Home_form.FormClosed += Logout_FormClosed; // creating logout event of homeform
                    }
                    Home_form.Text = "Home - admin";
                    this.Hide();
                    Home_form.ShowDialog();
                }
            }
            // Print error message for incorrect login information:
            else 
            {
                Console.WriteLine("Wrong username or password. Please try again.");
                this.Invalid.Visible = true;
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("exiting program...");
            this.Close(); // closes the application, ending the program.
        }

        // Close this form and the application when logout button is pressed in home form
        private void Logout_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
