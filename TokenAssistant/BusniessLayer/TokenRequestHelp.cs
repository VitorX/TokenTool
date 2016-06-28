using OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TokenAssistant.Data;

namespace TokenAssistant.BusniessLayer
{
    class TokenRequestHelp
    {
        private TokenRequest _tokenRequest;
        public TokenRequestHelp(TokenRequest tokenRequest)
        {
            _tokenRequest = tokenRequest;
        }

        public void Send(string authority, string tenant = "common")
        {

            var oauth = new OauthConfiguration
            {
                Authority = authority,
                Tenant = tenant,
                ClientId = _tokenRequest.App.ClientId,
                RedirectURI = _tokenRequest.App.RedirectURL,
                Secret = _tokenRequest.App.Type == AzureAppType.Server ? ((ServerAzureApp)_tokenRequest.App).Secret : ""
            };

            var tokenResponse = new OAuth2.OauthWebAuthHelper(oauth).AcquireTokenWithResource(_tokenRequest.Resource);
            _tokenRequest.AccessToken = tokenResponse.GetValue("access_token").Value<string>();
            _tokenRequest.RefreshToken = tokenResponse.GetValue("refresh_token").Value<string>();

            SaveToken();
        }

        private void SaveToken()
        {

            if (_tokenRequest.App.tokenRequests.Contains(_tokenRequest))
            {
                int index = _tokenRequest.App.tokenRequests.IndexOf(_tokenRequest);
                _tokenRequest.App.tokenRequests[index].AccessToken = _tokenRequest.AccessToken;
                _tokenRequest.App.tokenRequests[index].RefreshToken = _tokenRequest.AccessToken;
            }
            else
                _tokenRequest.App.tokenRequests.Add(_tokenRequest);
        }
    }
}
