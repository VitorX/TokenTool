using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokenAssistant.Data.DataLayer;
using TokenAssistant.DataService;

namespace TokenAssistant.UI.user
{
    public partial class UserList : Form
    {
        TokenAssistantServiceClient dataService = new TokenAssistantServiceClient();
        public UserList()
        {
            InitializeComponent();
            BindUserListbox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = new Data.DataLayer.User();
            user.UserName = tbUser.Text.Trim();
            dataService.AddUser(user);

            BindUserListbox();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            User user = (User)listBoxUsers.SelectedItem;
            dataService.DeleteUser(user);
            BindUserListbox();
        }

        private void BindUserListbox()
        {
            var users = dataService.GetAllUsers();
            listBoxUsers.DataSource = users;
            listBoxUsers.DisplayMember = "UserName";
        }
    }
}
