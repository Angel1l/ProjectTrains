using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEZIMENAMOYPOEZD.Model
{
   public class TripModel
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public string TripFrom { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string TripTo { get; set; }
        public int  FreePlcae { get; set; }
        public double TicketPrice { get; set; }
        public TripModel(int id, DateTime departureTime, string tripFrom, DateTime arrivalTime, string tripTo, int freep, double ticketPrice)
        {
            Id = id;
            DepartureTime = departureTime;
            TripFrom = tripFrom;
            ArrivalTime = arrivalTime;
            TripTo = tripTo;
            FreePlcae = freep;
            TicketPrice = ticketPrice;
        }
    }
}
