﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data
{
    public interface IAzureAppDbContext
    {
        void AddApp(AzureApp app);
        void SaveApp(AzureApp app);
    
        AzureApp GetApp(string clientId);
        void DeleteApp(string clientId);

        List<AzureApp> GetAllApps();

        void SaveChanges();
    }
}
