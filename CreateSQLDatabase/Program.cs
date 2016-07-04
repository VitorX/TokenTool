using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenAssistant;
using TokenAssistant.Data;
using TokenAssistant.Data.SQLDataLayer;

namespace CreateSQLDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AzureAppSQLDbContext("AzureAppsConn"))
            {

                var app1 = new ServerAzureApp
                {
                    AppName = "Office365RESTFEI",
                    ClientId = "5efa8abc-13dc-4681-83f5-c6fde07116ac",
                    RedirectURL = "http://localhost:55065",
                    Secret = "+ae67Jr3Pdl3F4JcCWOfnoURa9WTzRmzaBOySXeGdVY=",
                    tokenRequests = new List<TokenRequest>
                    {
                        new TokenRequest {
                        Resource="https://graph.microsoft.com",
                        SignInUserName="sp.tech@o365e3215.onmicrosoft.com"} ,

                        new TokenRequest {
                        Resource="https://office365.office.com",
                        SignInUserName ="nanyu@o365e3w15.onmicrosoft.com"} ,

                    }
                };

                db.AzureApps.Add(app1);
                db.SaveChanges();

                // Display all Apps from the database 
                var query = from app in db.AzureApps
                            orderby app.AppName
                            select app;

                Console.WriteLine("All apps in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.AppName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
