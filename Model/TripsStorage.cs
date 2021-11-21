using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEZIMENAMOYPOEZD.Model
{
    public class TripsStorage
    {        
        public static List<TripModel> trips = JsonPars.ReadFromFile("trips.json");                   
    }
}
