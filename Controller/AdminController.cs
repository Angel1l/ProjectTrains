using System;
using VEZIMENAMOYPOEZD.Model;
using VEZIMENAMOYPOEZD.View;

namespace VEZIMENAMOYPOEZD.Controller
{
  public class AdminController
    {
        private readonly MainMenuView _menuView;
        private readonly MenuChoiceAdmin _choiceStorageadmin;
       


        public AdminController()
        {
            _menuView = new MainMenuView();
            _choiceStorageadmin = MenuChoiceAdmin.GetInstance();
        }

        public void PriemWork (int a)
        {
            
            int b = 123;           
            if (a == b)
            {
                _menuView.ShowDelOrAdd();
                
               
            }
            else
            {
                Console.WriteLine("Pshel von");
            }

        }


        public void Add()
        {
            int a;
            DateTime b;
            string v;
            DateTime c;
            string n;
            string m;
            int q;
            int s;
            Console.WriteLine("Для того что бы добавить поезд следуйте инcтрукции");
            Console.WriteLine("1: Введите айди рейса");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2: Введите время отбытия рейса");
            b = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("3: Введите место отбытия рейса");
            v = Convert.ToString(Console.ReadLine());
            Console.WriteLine("4: Введите время прибытия");
            c = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("5: Введите место прибытия");
            n = Convert.ToString(Console.ReadLine());
            Console.WriteLine("6: Введите Kоличество мест");          
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("7: Введите цена билета");
            s = Convert.ToInt32(Console.ReadLine());

            TripsStorage.trips.Add(new TripModel { Id = a, DepartureTime = b, TripFrom = v, ArrivalTime = c, TripTo = n, FreePlcae = q, TicketPrice = s });//Не работает хз чо так 
        }

        public void Delete()
        {
            int a;
            Console.WriteLine("Введите номер рейса который хотите удалить:");
            a = Convert.ToInt32(Console.ReadLine());

            TripsStorage.trips.RemoveAt(a);
        }

        public void ShowError()
        {
            Console.WriteLine("ERROR!!");
        }
    }
}
