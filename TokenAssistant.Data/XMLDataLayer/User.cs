using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace TokenAssistant.Data
{
    public static class Users
    {
        private static List<string> _userNames;

        public static List<string> UserNames
        {
            get { return _userNames; }
        }

        static Users()
        {

            _userNames = ConfigurationManager.AppSettings["Users"].Split(new char[] { ';', ',' }).ToList<string>();
        }
    }
}