using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data
{
    public class AzureAppXMLContext: IAzureAppDbContext
    {
        string filePath;
        List<AzureApp> apps;

        internal AzureAppXMLContext()
        {
            filePath = AppDomain.CurrentDomain.BaseDirectory + "/AzureApps.xml";

            if (File.Exists(filePath))
            {
                System.Xml.Serialization.XmlSerializer reader =
     new System.Xml.Serialization.XmlSerializer(typeof(List<AzureApp>));

                System.IO.StreamReader file = new System.IO.StreamReader(filePath);
                apps = (List<AzureApp>)reader.Deserialize(file);
                file.Close();
            }
            else
                apps = new List<AzureApp>();

        }

        public void AddApp(AzureApp app)
        {
            apps.Add(app);

            SaveChanges();
        }

        public void SaveApp(AzureApp app)
        {
            foreach (var oldApp in apps)
            {
                if (oldApp.ClientId == app.ClientId)
                {
                    oldApp.AppName = app.AppName;
                    oldApp.RedirectURL = app.RedirectURL;
                    if (oldApp.Type == app.Type && (app is ServerAzureApp))
                        ((ServerAzureApp)oldApp).Secret = ((ServerAzureApp)app).Secret;
                    else
                    {
                        DeleteApp(app.ClientId);
                        AddApp(app);
                    }
                }
            }

            SaveChanges();
        }

        public AzureApp GetApp(string clientId)
        {
            foreach (var app in apps)
            {
                if (app.ClientId.Equals(clientId))
                    return app;
            }
            throw new Exception("No app found!");
        }
        public void DeleteApp(string clientId)
        {
            AzureApp findApp = null;
            foreach (var app in apps)
            {
                if (app.ClientId.Equals(clientId))
                {
                    findApp = app;
                }


            }
            if (findApp == null)
                throw new Exception("No app found!");
            else
            {
                apps.Remove(findApp);
                SaveChanges();
            }
            
        }

        public List<AzureApp> GetAllApps()
        {
            return apps;
        }

        public void SaveChanges()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<AzureApp>));

            System.IO.FileStream file = System.IO.File.Create(filePath);

            writer.Serialize(file, apps);
            file.Close();
        }

    }

}
