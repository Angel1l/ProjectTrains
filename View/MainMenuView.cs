using VEZIMENAMOYPOEZD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEZIMENAMOYPOEZD.View
{    
   public class MainMenuView
    {
        public event Action<int> MenuSelected = delegate { };

        private readonly InputComponent _input;

        public MainMenuView()
        {
            _input = new InputComponent();
        }
        
        public void ShowTripsTable(List<TripModel> trips)
        {
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Цена:{5}", oneTrip.Id, oneTrip.DepartureTime, oneTrip.TripFrom, oneTrip.ArrivalTime, oneTrip.TripTo, oneTrip.TicketPrice);

            }
        }

        public void FindByLastOstanovochka(List<TripModel> trips)
        {
            string b;
            Console.WriteLine("Напишите место прибытия: ");
            b = Convert.ToString(Console.ReadLine());

            TripModel found = TripsStorage.trips.Find(item => item.TripTo == b);
            Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Цена:{5}", found.Id, found.DepartureTime, found.TripFrom, found.ArrivalTime, found.TripTo, found.TicketPrice);

            //if (TripsStorage.trips != null)
            //{
            //    Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Цена:{5}", found.Id, found.DepartureTime, found.TripFrom, found.ArrivalTime, found.TripTo, found.TicketPrice);

            //}
            //else
            //{
            //    Console.WriteLine("EROR");  pizdez ne rabotaet
            //}
        }

        public void FindById(List<TripModel> trips)
        {
            int a;
            Console.WriteLine("Напишите номер рейса: ");
            a = Convert.ToInt32(Console.ReadLine());

            TripModel found = TripsStorage.trips.Find(item => item.Id == a);                   
            Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Цена:{5}", found.Id, found.DepartureTime, found.TripFrom, found.ArrivalTime, found.TripTo, found.TicketPrice);

        }
        public void ShowMenu(List<MenuChoiceModel> choices)
        {
            foreach (var choice in choices)
            {
                Console.WriteLine($"{choice.ChoiceId} - {choice.ChoiceText}");
            }

            var isCorrect = false;
            do
            {
                var userChoice = _input.GetInputInt();
                if (choices.Any(ch => ch.ChoiceId == userChoice))
                {
                    isCorrect = true;
                    MenuSelected(userChoice);
                }
            } while (!isCorrect);
        }

        public void ShowHeader()
        {
            Console.WriteLine("Добро пожаловать, используйте меню");
        } 

        public void ShowError()
        {
            Console.WriteLine("ERROR!!");
        }

        private void ShowTripsHeader()
        {
            Console.WriteLine("ТАБЛО");
        }
    }
}
