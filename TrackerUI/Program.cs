using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker_Library;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initialize the database connections
            Tracker_Library.GlobalConfig.InitializeConnections(Databasetype.Textfile);
            Application.Run(new CreateTeamForm());
           
            //Application.Run(new TournamentDashboard());

        }
    }
}
