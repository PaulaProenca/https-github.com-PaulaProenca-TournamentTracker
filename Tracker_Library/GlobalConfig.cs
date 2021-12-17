using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_Library.DataAccess;

namespace Tracker_Library
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 
        public static void InitializeConnections(Databasetype db ) 
        {
            if (db == Databasetype.Sql)
            {
                // Create the SQL connection
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == Databasetype.Textfile) ; 
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string CnnString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
