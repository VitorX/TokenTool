﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ServiceModel;

namespace TokenAssistant.Data.SQLDataLayer
{
    public class AzureAppDbHelper : IAzureAppDbContext
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

            targetApp.tokenRequests = app.tokenRequests;
            azureAppDbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            azureAppDbContext.SaveChanges();
        }

    }
}
