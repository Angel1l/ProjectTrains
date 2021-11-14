using System;
using VEZIMENAMOYPOEZD.Model;
using VEZIMENAMOYPOEZD.View;

namespace VEZIMENAMOYPOEZD.Controller
{
  public class AdminController
    {
        private readonly MainMenuView _menuView;
        private readonly MenuChoiceAdmin _choiceStorageadmin;        
        private readonly AdminView adminView;
        public AdminController()
        {
            _menuView = new MainMenuView();
            _choiceStorageadmin = MenuChoiceAdmin.GetInstance();
            adminView = new AdminView();


            adminView.Deletetrain += AdminView_Deletetrain;
           

            
        }

        public void Stop()
        {
            adminView.Deletetrain -= AdminView_Deletetrain;
        }
        private void AdminView_Deletetrain(int getnomber)
        {
            DeteleTrain(getnomber);
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
                ShowError();
                
            }
            
        }

        private void _menuView_ShowAddOrDel(int c)
        {
            switch (c)
            {
                case 1:
                    ADD();
                    ShowTripsTable();
                    break;
                case 2:
                    adminView.DeleteTrain();
                    ShowTripsTable();
                    break;
                default:
                    EROR();
                    break;
            }
        }

        public void Add()
        {
            int id;
            DateTime timefrom;
            string placefrom;
            DateTime timeto;           
            string placeto;
            int freeplace;
            int priceticket;
            Console.WriteLine("Для того что бы добавить поезд следуйте инcтрукции");
            Console.WriteLine("1: Введите айди рейса");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2: Введите время отбытия рейса");
            timefrom = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("3: Введите место отбытия рейса");
            placefrom = Convert.ToString(Console.ReadLine());
            Console.WriteLine("4: Введите время прибытия");
            timeto = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("5: Введите место прибытия");
            placeto = Convert.ToString(Console.ReadLine());
            Console.WriteLine("6: Введите Kоличество мест");          
            freeplace = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("7: Введите цена билета");
            priceticket = Convert.ToInt32(Console.ReadLine());

            TripsStorage.trips.Add(new TripModel(id,timefrom,placefrom,timeto,placeto,freeplace,priceticket));
        }
        public void DeteleTrain(int getnomber)
        {
            TripsStorage.trips.RemoveAt(getnomber);
        }
        private void ShowError()
        {
            _menuView.ShowwError();
        }
        public void AddOrDell(int c)
        {
            _menuView_ShowAddOrDel(c);
        }
        private void ADD()
        {
            Add();
        }        
        public void EROR()
        {
            ShowError();
        }
        private void ShowTripsTable()
        {
            _menuView.ShowTripsTable(TripsStorage.trips);
        }
    }
}
