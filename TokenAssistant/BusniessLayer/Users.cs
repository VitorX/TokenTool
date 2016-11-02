using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenAssistant.Data.DataLayer;
using TokenAssistant.Data.SQLDataLayer;

namespace TokenAssistant.BusniessLayer
{
    class Users
    {
        private AzureAppSQLDbContext dbContext;

            public Users()
        {
            dbContext = new AzureAppSQLDbContext("");
        }
        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }

        public void UpdateUsers(User user)
        {

        }

        public void DeleteUser(User user)
        {

        }
    }
}
