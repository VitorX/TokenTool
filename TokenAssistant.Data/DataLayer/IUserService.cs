using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data.DataLayer
{
    interface IUserService
    {
        void AddUser(User user);
        User GetUser(string userName);
        List<User> GetAllUsers();
        void DeleteUser(User user);

    }
}
