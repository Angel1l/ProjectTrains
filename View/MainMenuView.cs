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
        public event Action<int> PasswordforUser = delegate { };
        
        public event Action<int> MenuSelected = delegate { };

        public event Action<int> ShowAddOrDel = delegate { };
      

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
                Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Kоличество мест:{5}, Цена:{6}", oneTrip.Id, oneTrip.DepartureTime, oneTrip.TripFrom, oneTrip.ArrivalTime, oneTrip.TripTo, oneTrip.FreePlcae, oneTrip.TicketPrice);

            }
        }

        public void FindByLastOstanovochka(List<TripModel> trips)
        {
            string b;
            Console.WriteLine("Напишите место прибытия: ");
            b = Convert.ToString(Console.ReadLine());

            TripModel found = TripsStorage.trips.Find(item => item.TripTo == b);           
            if (found != null)
            {
                Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Kоличество мест:{5}, Цена:{6}", found.Id, found.DepartureTime, found.TripFrom, found.ArrivalTime, found.TripTo, found.FreePlcae, found.TicketPrice);

            }
            else
            {
                Console.WriteLine("Неверное место прибытия");
            }

        }

        public void ShowWeekReus(List<TripModel> trips)
        {
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Kоличество мест:{5}, Цена:{6}", oneTrip.Id, oneTrip.DepartureTime, oneTrip.TripFrom, oneTrip.ArrivalTime, oneTrip.TripTo, oneTrip.FreePlcae, oneTrip.TicketPrice);

            }
        }
        
        public void ShooowFreePlace(List<TripModel> trips)
        {
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                Console.WriteLine("Рейс:{0}, Kоличество мест:{1}, Цена:{2}", oneTrip.Id, oneTrip.FreePlcae, oneTrip.TicketPrice);

            }
        }
        public void ShowTodayReus()
        {
            TripModel found = TripsStorage.trips.Find(item => item.ArrivalTime == DateTime.Today);
            if (found != null)
            {
                Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Kоличество мест:{5}, Цена:{6}", found.Id, found.DepartureTime, found.TripFrom, found.ArrivalTime, found.TripTo, found.FreePlcae, found.TicketPrice);

            }
            else
            {
                Console.WriteLine("На сегодня рейсов нету");
            }
            
        }
        public void FindById(List<TripModel> trips)
        {
            int a;
            Console.WriteLine("Напишите номер рейса: ");
            a = Convert.ToInt32(Console.ReadLine());

            TripModel found = TripsStorage.trips.Find(item => item.Id == a);
            Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Kоличество мест:{5}, Цена:{6}", found.Id, found.DepartureTime, found.TripFrom, found.ArrivalTime, found.TripTo, found.FreePlcae, found.TicketPrice);

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
        public void ShowPassword()
        {
            int a;
            Console.WriteLine("Введите пароль:");
            a = Convert.ToInt32(Console.ReadLine());
            PasswordforUser(a);
        }
       
        public void ShowDelOrAdd()
        {
            int c;
            Console.WriteLine("Добро пожаловать в клуб дружище");
            Console.WriteLine("Для того что бы создать поезд напишите: 1");
            Console.WriteLine("Для того что бы удалить поезд напишите: 2");
            c = Convert.ToInt32(Console.ReadLine());
            ShowAddOrDel(c);
        }

        
       
        public void ShowPrice()
        {
            int a;
            Console.WriteLine("Введите сумуму: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            TripModel found = TripsStorage.trips.Find(item => item.TicketPrice == a);          
            if (found != null)
            {
                Console.WriteLine("Рейс:{0}, Время отбытия:{1}, Место отбытия:{2}, Время прибытия:{3}, Место Прибытия:{4}, Kоличество мест:{5}, Цена:{6}", found.Id, found.DepartureTime, found.TripFrom, found.ArrivalTime, found.TripTo, found.FreePlcae, found.TicketPrice);

            }
            else
            {
                Console.WriteLine("Eore");
            }
        }
        

    }
    }

