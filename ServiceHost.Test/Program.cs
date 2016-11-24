using ServiceHost.Test.AzureApp.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHost.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            TokenAssistantServiceClient azureAppDbHelperClient = new TokenAssistantServiceClient();

            foreach (var app in azureAppDbHelperClient.GetAllApps())
            {
                Console.WriteLine(String.Format("{0}:{1}", app.AppName, app.Type));
                Console.WriteLine(app.Type);
                if (app.tokenRequests.Length > 0)
                    Console.WriteLine(String.Format("\t{0,-30}{1,-30}", "Resource", "SignInUserName"));
                foreach (var tokenRequest in app.tokenRequests)
                {
                    Console.WriteLine(String.Format("\t{0,-30}{1,-30}", tokenRequest.Resource, tokenRequest.SignInUserName));
                }
            }

            Console.ReadLine();
        }
    }
}
