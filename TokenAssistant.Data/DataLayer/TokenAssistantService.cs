using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data.DataLayer
{
    [ServiceContract]
    public class TokenAssistantService : IAzureAppService, IUserService
    {
        [OperationContract]
        public void AddApp(AzureApp app)
        {
            AzureAppDbFactory.GetDbContext().AddApp(app);
        }

        [OperationContract]
        public void DeleteApp(string clientId)
        {
            AzureAppDbFactory.GetDbContext().DeleteApp(clientId);
        }

        [OperationContract]
        public List<AzureApp> GetAllApps()
        {
            return AzureAppDbFactory.GetDbContext().GetAllApps();
        }  

        [OperationContract]
        public void SaveApp(AzureApp app)
        {
            AzureAppDbFactory.GetDbContext().SaveApp(app);
        }

        [OperationContract]
        public void SaveChanges()
        {
            AzureAppDbFactory.GetDbContext().SaveChanges();
        }

        [OperationContract]
        public AzureApp GetApp(string clientId)
        {
            return AzureAppDbFactory.GetDbContext().GetApp(clientId);
        }


        [OperationContract]
        public void AddUser(User user)
        {
            (AzureAppDbFactory.GetDbContext() as IUserService).AddUser(user);
        }


        [OperationContract]
        public void DeleteUser(User user)
        {
            (AzureAppDbFactory.GetDbContext() as IUserService).DeleteUser(user);
        }


        [OperationContract]
        public List<User> GetAllUsers()
        {
            return (AzureAppDbFactory.GetDbContext() as IUserService).GetAllUsers();
        }

        [OperationContract]
        public User GetUser(string userName)
        {
            return (AzureAppDbFactory.GetDbContext() as IUserService).GetUser(userName);
        }

    }
}
