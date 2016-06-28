using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TokenAssistant.Data
{
    [XmlInclude(typeof(ClientAzureApp))]
    [XmlInclude(typeof(ServerAzureApp))]
    public class AzureApp
    {
        private string _clientId;
        private string _redirectURL;
        private string _appName;
      
        [Key]
        public int Id { get; set; }

        public string ClientId
        {
            get
            {
                return _clientId;
            }

            set
            {
                _clientId = value;
            }
        }

        public List<TokenRequest> tokenRequests { get; set; }

        public string RedirectURL
        {
            get
            {
                return _redirectURL;
            }

            set
            {
                _redirectURL = value;
            }
        }

        public string AppName
        {
            get
            {
                return _appName;
            }

            set
            {
                _appName = value;
            }
        }

        public AzureAppType Type { set; get; }

    }

    public enum AzureAppType { Server = 1, client = 2 }

    public class ClientAzureApp : AzureApp
    {
        public ClientAzureApp() {
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
