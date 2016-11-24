using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenAssistant.Data.SQLDataLayer;

namespace TokenAssistant.Data.DataLayer
{
    static class AzureAppDbFactory
    {
        static string SQLConnName="AzureAppsConn";

        static IAzureAppService _IAzureAppDbContext;

        static AzureAppDbFactory()
        {
            _IAzureAppDbContext = GetDbContext();
        }

        private static IAzureAppService GetDbContext(AzureAppDbType dBType)
        {
            switch (dBType)
            {
                case AzureAppDbType.XML:
                    return new AzureAppXMLContext();
                case AzureAppDbType.SQLServer:
                    return new AzureAppDbHelper(SQLConnName);
                default:
                    return new AzureAppXMLContext();
            }
        }

        public static IAzureAppService GetDbContext()
        {
            //TODO
            //return GetDbContext(AzureAppDbType.XML);
            return GetDbContext(AzureAppDbType.SQLServer);
        }
    }

    internal enum AzureAppDbType
    {
        XML=1,SQLServer=2
    }
}
