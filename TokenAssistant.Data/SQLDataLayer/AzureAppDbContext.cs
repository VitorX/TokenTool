﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data.SQLDataLayer
{
    public class AzureAppSQLDbContext : DbContext
    {
        public DbSet<AzureApp> AzureApps { get; set; }

        public AzureAppSQLDbContext(string connectionStringName)
      : base(connectionStringName)
        {
        }

    }
}
