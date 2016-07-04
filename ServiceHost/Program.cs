using System;
using System.ServiceModel;
using TokenAssistant.Data.Data;

namespace ServiceHost1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AzureAppService)))
            {
                host.Open();

                Console.WriteLine("service started...");
                Console.ReadLine();
            }
        }
    }
}
