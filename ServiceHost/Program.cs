using System;
using System.ServiceModel;
using TokenAssistant.Data.DataLayer;

namespace ServiceHost1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(TokenAssistantService)))
            {
                //WSHttpBinding binding = new WSHttpBinding();
                //host.AddServiceEndpoint(typeof(UserService), binding, "http://localhost:8090/UserService");
                host.Open();

                Console.WriteLine("service started...");
                Console.ReadLine();
            }
        }
    }
}
