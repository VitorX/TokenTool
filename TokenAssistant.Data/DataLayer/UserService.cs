using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data.DataLayer
{
    [ServiceContract]
    public class UserService
    {
        [OperationContract]
        public void AddUser(User user)
        {
            (AzureAppDbFactory.GetDbContext() as IUserService).AddUser(user);
        }

        [OperationContract]
        public void GetAllUsers()
        {
            (AzureAppDbFactory.GetDbContext() as IUserService).GetAllUsers();
        }

        [OperationContract]
        public void DeleteUser(User user)
        {
            (AzureAppDbFactory.GetDbContext() as IUserService).DeleteUser(user);
        }


    }
}
