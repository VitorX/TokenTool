using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data.Data
{
    [ServiceContract]
    public class AzureAppService : IAzureAppDbContext
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
        public AzureApp GetApp(string clientId)
        {
            return AzureAppDbFactory.GetDbContext().GetApp(clientId);
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

    }
}
