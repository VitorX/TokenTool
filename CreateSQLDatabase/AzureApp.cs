using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateSQLDatabase
{

    public class AzureApp
    {

        [Key]
        public string ClientId
        {
            get; set;
        }

        public string RedirectURL
        {
            get; set;
        }

        public string AppName
        {
            get; set;
        }

        public AzureAppType Type { set; get; }

        public List<TokenRequest> tokenRequests { get; set; }

    }

    public enum AzureAppType { Server = 1, client = 2 }

    public class ClientAzureApp : AzureApp
    {
        public ClientAzureApp()
        {
            Type = AzureAppType.client;
        }
    }

    public class ServerAzureApp : AzureApp
    {
        public string Secret { get; set; }

        public ServerAzureApp()
        {
            Type = AzureAppType.Server;
        }
    }
}
