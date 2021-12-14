using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_Library
{
    public class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } 

        public static void InitializeConnections (bool database, bool textFiles) 
        {
            Connections = new List<IDataConnection>();
            if (database) 
            {
                // Create the SQL connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles) 
            {
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }

        }
    }
}
