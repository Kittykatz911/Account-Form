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
    public partial class AdminModifyUserAccount: Form
    {
        public AddUserDataMgr addUserDataMgr = new AddUserDataMgr("UserData");

        int index; // index within the combobox

        public AdminModifyUserAccount()
        {
            InitializeComponent();

            // load .json
            addUserDataMgr.userDataList = addUserDataMgr.readFromJson<AddUserData>();

            // Get list of users:
            getCurrentUsers();

            // Disable update button
            Update_Account.Enabled = false;

            // Disable update panel:
            UpdatePanel.Enabled = false;

            this.Activated += AdminModifyUserAccount_Activated; // event to reload the list without exiting
        }

        private void getCurrentUsers()
        {

            // Clear items:

            accountSelection.Items.Clear();
            accountSelection.Text = "";
            newRole.SelectedIndex = -1;
            newRole.Text = "";
            newRole.SelectedIndex = -1;
            newName.Text = "";
            newUsername.Text = "";
            newPassword.Text = "";
           
            
            // Check for empty list:
            if(null == addUserDataMgr.userDataList)
            {
                return;
            }

            // read in data in:

            foreach (var data in addUserDataMgr.userDataList)
            {
                accountSelection.Items.Add(data.Name);
            }
        }
        private void UpdateAccount_Click(object sender, EventArgs e)
        {

            // Read new data to .json:
            addUserDataMgr.userDataList[index].Role = newRole.Text;
            addUserDataMgr.userDataList[index].Name = newName.Text;
            addUserDataMgr.userDataList[index].Username = newUsername.Text;
            addUserDataMgr.userDataList[index].Password = newPassword.Text;

            // read list:
            getCurrentUsers();

            // Disable Panel:
            UpdatePanel.Enabled = false;

            // Disable update button:
            Update_Account.Enabled = false;

            // Write updated data to .json:
            addUserDataMgr.writeToJson(addUserDataMgr.userDataList);

            // Completion message:
            string greeting = "User updated.";
            MessageBox.Show(greeting, "Modify User Status.");
            Console.WriteLine("Profile Updated!");
        }

        private void accountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable the Panel
            UpdatePanel.Enabled = true;

            // Enable update button:
            Update_Account.Enabled = true;

            // get index selected:
            index = accountSelection.SelectedIndex;

            // Write in current user data:

            newRole.Text = addUserDataMgr.userDataList[index].Role;
            newName.Text = addUserDataMgr.userDataList[index].Name;
            newUsername.Text = addUserDataMgr.userDataList[index].Username;
            newPassword.Text = addUserDataMgr.userDataList[index].Password;
        }

        private void newRole_Click(object sender, EventArgs e)
        {
            newRole.Text = (String)newRole.SelectedItem;
        }

        private void AdminModifyUserAccount_Activated(object sender, EventArgs e)
        {
            addUserDataMgr.userDataList = addUserDataMgr.readFromJson<AddUserData>();
            getCurrentUsers();
        }

        private void CloseModifyAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
