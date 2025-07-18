using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS314App_ahenry
{
    public partial class Home: Form
    {
        
        // create member variables:
        AdminAddUserAccount AdminAdd_form;
        AdminModifyUserAccount AdminModify_form;

        public Home()
        {
            InitializeComponent();
        }

        private void AddAdminUser_Click(object sender, EventArgs e)
        {
            if(AdminAdd_form == null || AdminAdd_form.IsDisposed)
            {
                // create the form if null or closed
                AdminAdd_form = new AdminAddUserAccount();
            }
            // open add admin form:
            AdminAdd_form.ShowDialog();
        }

        private void ModifyAdminUser_Click(object sender, EventArgs e)
        {
            if(AdminModify_form == null || AdminModify_form.IsDisposed)
            {
                // Make a new one:
                AdminModify_form = new AdminModifyUserAccount();
            }
            // open modify admin form:
            AdminModify_form.ShowDialog();
        }

        private void FormType(object sender, EventArgs e) // TextChanged event
        {
            if (true) // If the forms text changed that means an admin logged in so we want to show/change the buttons accordingly
            {
                // Viewable:
                this.Sign_Out.Visible = true;
                this.Modify_User.Visible = true;
                this.Add_User.Visible = true;
            }
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
