using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_Library.Models;

namespace Tracker_Library.DataAccess
{
    public class TextConnector : IDataConnection
    {

        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }

        public static implicit operator List<object>(TextConnector v)
        {
            throw new NotImplementedException();
        }
    }
}
