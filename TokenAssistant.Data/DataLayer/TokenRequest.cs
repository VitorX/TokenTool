using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TokenAssistant.Data
{
    public class TokenRequest
    {
        private AzureApp _app;
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public string Resource
        {
            get; set;
        }

        public string SignInUserName
        {
            get; set;
        }

        public int Id { get;set; }

        public int AzureAppId { get; set; }

        [ForeignKey("AzureAppId")]
        public AzureApp App
        {
            get { return _app; }
        }

        public TokenRequest(AzureApp app, string resource, string signInUserName)
        {
            _app = app;
            Resource = resource;
            SignInUserName = signInUserName;
        }

        public override bool Equals(object tokenRequest)
        {
            if (tokenRequest is TokenRequest)
            {
                var _tokenRequest = (TokenRequest)tokenRequest;
                if (this.Resource == _tokenRequest.Resource &&
                    this.SignInUserName == _tokenRequest.SignInUserName
                    )
                    return true;
                else
                    return false;
            }
            return false;
        }

        public TokenRequest()
        {
        }
    }
}
