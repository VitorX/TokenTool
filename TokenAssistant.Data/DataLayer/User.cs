using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data.DataLayer
{
    [DataContract]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }
}
