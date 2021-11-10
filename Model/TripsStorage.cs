using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEZIMENAMOYPOEZD.Model
{
   public class TripsStorage
    {
        public static List<TripModel> trips = new List<TripModel>()
        {
            new TripModel(1, new DateTime(2021,01,11,22,13,50), "Киев", new DateTime(2021,01,11,3,10,50), "Харьков",new BusModel("BMW", 35), 750),
            new TripModel(2, new DateTime(2021,01,11,15,00,00), "Одесса", new DateTime(2021,01,11,18,30,50), "Днепр",new BusModel("Mers", 20), 500),
            new TripModel(3, new DateTime(2021,01,12,8,10,35), "Запорожье", new DateTime(2021,01,12,13,00,10), "Львов",new BusModel("Porse",15), 2000),
            new TripModel(4, new DateTime(2021,01,13,6,50,10), "Николаев", new DateTime(2021,01,13,10,10,10), "Мариуполь",new BusModel("Sprinter", 18), 400),
            new TripModel(5, new DateTime(2021,01,14,23,10,30), "Винница", new DateTime(2021,01,14,6,10,30), "Херсон",new BusModel("Bohdan", 20), 450),
            new TripModel(6, new DateTime(2021,01,15,2,7,10), "Чернигов", new DateTime(2021,01,15,6,30,50), "Полтава",new BusModel("Ikarus", 35), 200),
            new TripModel(7, new DateTime(2021,01,16,20,44,44), "Черкассы", new DateTime(2021,01,16,3,22,22), "Хмельницкий",new BusModel("Reno", 8), 1000),
            new TripModel(8, new DateTime(2021,01,17,16,15,14), "Черновцы",new DateTime(2021,01,17,22,23,24), "Житомир",new BusModel("Mazda", 40), 3000),
            new TripModel(9, new DateTime(2021,01,17,22,13,50), "Сумы", new DateTime(2021,01,17,3,10,50), "Ровно",new BusModel("Benkli", 6), 5000),
            new TripModel(10, new DateTime(2021,01,11,14,13,14), "Каменское", new DateTime(2021,01,20,5,11,11), "Кропивницкий",new BusModel("Jugyl", 5), 10000)
        };
    }
}
