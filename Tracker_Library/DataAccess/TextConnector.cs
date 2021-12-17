using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_Library.Models;
using Tracker_Library.DataAccess.TextHelpers;


namespace Tracker_Library.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
           
            int currentId = 1;
            
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            
            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        // wire up the createPrize for text files.
        public PrizeModel CreatePrize(PrizeModel model) 
        {
            // Load the text file and convert the text to list
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;

            if (prizes.Count > 0) 
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // ADD the new record with the new ID (Max + 1)
            prizes.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to the text file 
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

    }
}
