using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CreateSQLDatabase
{
    public class TokenRequest
    {
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

        public string AppClientId { get; set; }

        [Key]
        public int RequestId { get; set; }

        [ForeignKey("AppClientId")]
        public AzureApp App { get; set; }

    }
}
