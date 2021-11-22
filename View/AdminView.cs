using VEZIMENAMOYPOEZD.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VEZIMENAMOYPOEZD.View
{
    public class AdminView
    {
        public event Action<int> Deletetrain = delegate { };
        public event Action<int, DateTime, string, DateTime, string, int, int> CreateAddEvent = delegate { };
        public void DeleteTrain()
        {
            int getnomber;
            Console.WriteLine("Введите номер рейса который хотите удалить: ");
            do
            {
                Console.WriteLine($"У нас есть {TripsStorage.trips.Last().Id} айди рейсов, введите не больше чем {TripsStorage.trips.Last().Id}");
                getnomber = Convert.ToInt32(Console.ReadLine());
                if (getnomber > TripsStorage.trips.Last().Id)
                {
                    Console.WriteLine("Ну ты и тупой");
                }

            } while (getnomber > TripsStorage.trips.Last().Id);          
            Deletetrain(getnomber);
            TripsStorage.trips.RemoveAt(getnomber);
        }
        public void Add()
        {
            int idreus;
            DateTime timefrom = new DateTime();
            string placefrom;
            DateTime timeto = new DateTime();
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
            try
            {
                Console.WriteLine("2: Введите дату отбытия рейса. ПРИМЕР - (21.11.2021)");
                timefrom = Convert.ToDateTime(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ОШИБКА");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine("В след раз будь внимательней, а то на бананах будешь работать");
                Console.ReadLine();
                return;               
            }                                      
            do
            {
                Console.WriteLine("3: Введите место отбытия рейса");
                placefrom = Convert.ToString(Console.ReadLine());
                if (placefrom.Length > 15)
                {
                    Console.WriteLine("Слишком длинно, сделайте по короче ");
                }

            } while (placefrom.Length > 15);
            try
            {
                Console.WriteLine("4: Введите дату прибытия(21.11.2021)");
                timeto = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine("В след раз будь внимательней, а то на бананах будешь работать");
                Console.ReadLine();
                return;
            }           
            do
            {
                Console.WriteLine("5: Введите место прибытия");
                placeto = Convert.ToString(Console.ReadLine());
                if (placeto.Length > 15)
                {
                    Console.WriteLine("Слишком длинно, сделайте по короче ");
                }

            } while (placeto.Length > 15);
            do
            {
                Console.WriteLine("6: Введите Kоличество мест");
                freeplace = Convert.ToInt32(Console.ReadLine());
                if (freeplace > 50)
                {
                    Console.WriteLine("Слишком много мест, сделайте меньше");
                }

            } while (freeplace > 50);
            do
            {
                Console.WriteLine("7: Введите цена билета");
                priceticket = Convert.ToInt32(Console.ReadLine());
                if (priceticket > 10000)
                {
                    Console.WriteLine("Слишком доргой билет, сделайте дешевлее");
                }

            } while (priceticket > 10000);
            Console.WriteLine("КОМАНДА ДОДАТЬ ПОЕЗД ЗАКОНЧЕННА");
            Console.ReadLine();
            CreateAddEvent(idreus, timefrom, placefrom, timeto, placeto, freeplace, priceticket);

            TripsStorage.trips.Add(new TripModel(idreus, timefrom, placefrom, timeto, placeto, freeplace, priceticket));
        }
    }
}