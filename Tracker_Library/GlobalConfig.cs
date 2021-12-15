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
        public static List<IDataConnection> Connections { get; private set; } 
        public static void InitializeConnections (bool database, bool textfiles) 
        {
            Connections = new List<IDataConnection>();
            if (database)
            {
                // Create the SQL connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textfiles) 
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        public static string CnnString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
