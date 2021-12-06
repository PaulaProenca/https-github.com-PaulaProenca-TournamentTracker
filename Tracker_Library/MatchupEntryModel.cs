using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_Library
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team int the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// represents the matchup that this team came
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
