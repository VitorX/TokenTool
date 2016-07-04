using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TokenAssistant.Data
{
    [DataContract(IsReference = true)]
    public class TokenRequest
    {

        [DataMember]
        public string AccessToken { get; set; }
        [DataMember]
        public string RefreshToken { get; set; }
        [DataMember]
        public string Resource
        {
            get; set;
        }
        [DataMember]
        public string SignInUserName
        {
            get; set;
        }

        public int Id { get; set; }

        public int AzureAppId { get; set; }

        [DataMember]
        [ForeignKey("AzureAppId")]
        public AzureApp App { get; set; }

        public TokenRequest(AzureApp app, string resource, string signInUserName)
        {
            App = app;
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
