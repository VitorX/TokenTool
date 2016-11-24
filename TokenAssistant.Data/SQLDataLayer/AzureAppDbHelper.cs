using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ServiceModel;
using System.IO;
using TokenAssistant.Data.DataLayer;

namespace TokenAssistant.Data.SQLDataLayer
{
    public class AzureAppDbHelper : IAzureAppService,IUserService
    {
        AzureAppSQLDbContext azureAppDbContext;

        public AzureAppDbHelper(string sqlConnName)
        {
            azureAppDbContext = new AzureAppSQLDbContext(sqlConnName);
        }

        public AzureAppDbHelper(): this("AzureAppsConn")
        {
           
        }

        public void AddApp(AzureApp app)
        {
            azureAppDbContext.AzureApps.Add(app);
            azureAppDbContext.SaveChanges();
        }

        public void DeleteApp(string clientId)
        {
            var targetApp = azureAppDbContext.AzureApps.FirstOrDefault(app => app.ClientId == clientId);
            azureAppDbContext.AzureApps.Remove(targetApp);
        }

        public List<AzureApp> GetAllApps()
        {
            return azureAppDbContext.AzureApps.Include(app => app.tokenRequests).ToList();
        }

        public AzureApp GetApp(string clientId)
        {
            var targetApp = azureAppDbContext.AzureApps.Include(app => app.tokenRequests).FirstOrDefault(app => app.ClientId == clientId);
            return targetApp;
        }

        public void SaveApp(AzureApp app)
        {
            var targetApp = azureAppDbContext.AzureApps.Include(_app => _app.tokenRequests).FirstOrDefault(_app => _app.ClientId == app.ClientId);
            targetApp.AppName = app.AppName;
            targetApp.RedirectURL = app.RedirectURL;
            if (app is ServerAzureApp)
            {
                ((ServerAzureApp)targetApp).Secret = ((ServerAzureApp)app).Secret;
            }

            foreach (var req in app.tokenRequests)
            {
                var tagetRequest=targetApp.tokenRequests.FirstOrDefault(_req => _req.Resource == req.Resource && _req.SignInUserName == req.SignInUserName);
                if (tagetRequest == null)
                {
                    req.App = null;
                    targetApp.tokenRequests.Add(req);
                }
                else
                {
                    if(!tagetRequest.AccessToken.Equals(req.AccessToken))
                        tagetRequest.AccessToken = req.AccessToken;
                    if (!tagetRequest.RefreshToken.Equals(req.RefreshToken))
                        tagetRequest.RefreshToken = req.RefreshToken;
                }
            }
            
            azureAppDbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            azureAppDbContext.SaveChanges();
        }

        public void AddUser(User user)
        {
            azureAppDbContext.Users.Add(user);
            SaveChanges();
        }

        public User GetUser(string userName)
        {
            return azureAppDbContext.Users.FirstOrDefault(u=>u.UserName== userName);
            
        }

        public List<User> GetAllUsers()
        {
            return azureAppDbContext.Users.ToList();
        }

        public void DeleteUser(User user)
        {
            var removingUser = azureAppDbContext.Users.FirstOrDefault(u => u.UserName == user.UserName);
            azureAppDbContext.Users.Remove(removingUser);
            SaveChanges();
        }
    }
}
