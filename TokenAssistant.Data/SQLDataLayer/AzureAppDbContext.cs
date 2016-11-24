using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TokenAssistant.Data.DataLayer;

namespace TokenAssistant.Data.SQLDataLayer
{
    public class AzureAppSQLDbContext : DbContext
    {
        public DbSet<AzureApp> AzureApps { get; set; }
        public DbSet<TokenRequest> TokenRequests { get; set; }

        public DbSet<User> Users { get; set; }

        public AzureAppSQLDbContext(string connectionStringName)
      : base(connectionStringName)
        {
        }

        public AzureAppSQLDbContext():base("name=AzureAppSQLDbContext")
        {
        }

    }
}
