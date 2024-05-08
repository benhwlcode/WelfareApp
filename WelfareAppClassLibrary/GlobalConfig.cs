using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;
using WelfareAppClassLibrary.Models;

namespace WelfareAppClassLibrary
{
    public static class GlobalConfig
    {
        const string databaseName = "WelfareApplication";
        const string databaseConnection = "(LocalDb)\\MSSQLLocalDB";

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


    }
}
