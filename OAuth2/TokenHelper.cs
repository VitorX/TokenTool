using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OAuth2
{
    public class TokenHelper
    {
        AuthenticationContext authContext;
        private string _authUri;

        public TokenHelper(string authUri)
        {
            string _authUri = authUri;
            authContext = new AuthenticationContext(authUri);
        }

        public async Task<string> AcquireTokenAsync(string clientId, string secret, string resrouceURL)
        {
            var credential = new ClientCredential(clientId: clientId, clientSecret: secret);
            var result = await authContext.AcquireTokenAsync(resrouceURL, credential);
            return result.AccessToken;
        }

        public JObject RefreshToken(string clientId, string secret, string resrouceURL, string refreshToken)
        {

            var parameters = new Dictionary<string, string>
                {
                    { "grant_type", "refresh_token" },
                    { "client_id", clientId },
                    { "client_secret", secret },
                    { "resource", resrouceURL},
                    { "refresh_token",refreshToken}
                };

            var list = new List<string>();

            foreach (var parameter in parameters)
            {
                if (!string.IsNullOrEmpty(parameter.Value))
                    list.Add(string.Format("{0}={1}", parameter.Key, HttpUtility.UrlEncode(parameter.Value)));
            }

            HttpClient client = new HttpClient();
            var content= string.Join("&", list);

            var httpContent = new StringContent(content, Encoding.GetEncoding("utf-8"), "application/x-www-form-urlencoded");
            var response = client.PostAsync("https://login.microsoftonline.com/common/oauth2/token", httpContent).Result;
            return JObject.Parse(response.Content.ReadAsStringAsync().Result);         

        }


        static string AccquireToken(string refreshToken)
        {
            
            HttpClient client = new HttpClient();
            string content = "grant_type=refresh_token&refresh_token={0}&resource=https%3A%2F%2Fgraph.microsoft.com&client_id=5efa8abc-13dc-4681-83f5-c6fde07116ac&client_secret=%2Bae67Jr3Pdl3F4JcCWOfnoURa9WTzRmzaBOySXeGdVY%3D";
            var httpContent = new StringContent(String.Format(content, refreshToken), Encoding.GetEncoding("utf-8"), "application/x-www-form-urlencoded");
            var response = client.PostAsync("https://login.microsoftonline.com/common/oauth2/token", httpContent).Result;
            JObject json = JObject.Parse(response.Content.ReadAsStringAsync().Result);
            return json["access_token"].ToString();
        }

    }
}
