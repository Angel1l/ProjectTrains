using VEZIMENAMOYPOEZD.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VEZIMENAMOYPOEZD.View
{
    public class AdminView
    {
        public event Action<int> Deletetrain = delegate { };
        public event Action<int,DateTime,string, DateTime, string, int, int> CreateAddEvent = delegate { };        
        public void DeleteTrain()
        {
            int getnomber;
            Console.WriteLine("Введите номер рейса который хотите удалить: ");
            getnomber = Convert.ToInt32(Console.ReadLine());
            Deletetrain(getnomber);
            TripsStorage.trips.RemoveAt(getnomber);
        }
        public void Add()
        {          
            int idreus;
            DateTime timefrom;
            string placefrom;
            DateTime timeto;
            string placeto;
            int freeplace;
            int priceticket;
            Console.WriteLine("Для того что бы добавить поезд следуйте инcтрукции");           
            Console.WriteLine("1: Введите айди рейса");                        
                do
                {
                    Console.WriteLine($"У нас есть {TripsStorage.trips.Last().Id} айди рейсов, введи больше чем последний");
                    idreus = Convert.ToInt32(Console.ReadLine());
                    if (idreus < TripsStorage.trips.Last().Id)
                    {
                        Console.WriteLine("Ну ты и тупой");                        
                    }

                } 
                while (idreus < TripsStorage.trips.Last().Id);
            Console.WriteLine("2: Введите дату отбытия рейса. ПРИМЕР - (21.11.2021)");
            timefrom = Convert.ToDateTime(Console.ReadLine());
            try
            {
                var timefrommiror = timefrom;
            }
            catch
            {
                Console.WriteLine("Попробуйте еще раз");
            }                                               
            Console.WriteLine("3: Введите место отбытия рейса");
            placefrom = Convert.ToString(Console.ReadLine());
            try
            {
                var placefrommiror = timefrom;
            }
            catch
            {
                Console.WriteLine("Попробуйте еще раз");
            }
            Console.WriteLine("4: Введите дату прибытия(21.11.2021)");
            timeto = Convert.ToDateTime(Console.ReadLine());
            try
            {
                var timetomiror = timeto;
            }
            catch
            {
                Console.WriteLine("Попробуйте еще раз");
            }
            Console.WriteLine("5: Введите место прибытия");
            placeto = Convert.ToString(Console.ReadLine());
            try
            {
                var placetomiror = placeto;
            }
            catch
            {
                Console.WriteLine("Попробуйте еще раз");
            }
            Console.WriteLine("6: Введите Kоличество мест");
            freeplace = Convert.ToInt32(Console.ReadLine());
            try
            {
                var freeplacemiror = freeplace;
            }
            catch
            {
                Console.WriteLine("Попробуйте еще раз");
            }
            Console.WriteLine("7: Введите цена билета");
            priceticket = Convert.ToInt32(Console.ReadLine());
            try
            {
                var priceticketmiror = priceticket;
            }
            catch
            {
                Console.WriteLine("Попробуйте еще раз");
            }
            CreateAddEvent(idreus, timefrom, placefrom, timeto, placeto, freeplace, priceticket);

            TripsStorage.trips.Add(new TripModel(idreus, timefrom, placefrom, timeto, placeto, freeplace, priceticket));
        }
    }
}
