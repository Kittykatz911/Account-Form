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
    public partial class AdminAddUserAccount: Form
    {
        // Add data manager:
        public AddUserDataMgr addUserDataMgr = new AddUserDataMgr("UserData");

        public AdminAddUserAccount()
        {
            InitializeComponent();

            // Load user data from .json
            addUserDataMgr.userDataList = addUserDataMgr.readFromJson<AddUserData>();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {

            // make object of AddUserData class

            AddUserData addUser = new AddUserData();

            // get data from user input fields:

            addUser.Role = addRole.Text;
            addUser.Name = addName.Text;
            addUser.Username = addUsername.Text;
            addUser.Password = addPassword.Text;

            // If no list/data create one:
            if(null == addUserDataMgr.userDataList)
            {
                addUserDataMgr.userDataList = new List<AddUserData>();
            }

            // add object of AddUserData class to list:
            addUserDataMgr.userDataList.Add(addUser);

            // write to the .json list:
            addUserDataMgr.writeToJson(addUserDataMgr.userDataList);

            // Clear items so they don't stay in the fields you can add more people right away:
            addRole.SelectedIndex = -1;
            addName.Text = "";
            addUsername.Text = "";
            addPassword.Text = "";

            // add a message: 
            string greeting = "User Added!";
            MessageBox.Show(greeting, "Add User Status");
            Console.WriteLine("User Added!");
        }

        private void addRole_Click(object sender, EventArgs e)
        {
            addRole.Text = (String)addRole.SelectedItem;
        }

        private void CloseAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
