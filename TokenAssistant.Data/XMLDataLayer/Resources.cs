using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenAssistant.Data
{
    public static class Resources
    {
        private static List<string> _resrouces;

        public static List<string> Resrouces
        {
            get { return _resrouces; }
        }

        static Resources()
        {

            _resrouces=ConfigurationManager.AppSettings["resrouce"].Split(new char[] { ';',','}).ToList();
        }
    }
}
