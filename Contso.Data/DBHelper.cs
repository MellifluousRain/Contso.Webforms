using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Contso.Data
{
    public class DBHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Contso"].ConnectionString;
        }
    }
}
