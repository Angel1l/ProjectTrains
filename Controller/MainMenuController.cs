using VEZIMENAMOYPOEZD.Model;
using VEZIMENAMOYPOEZD.View;

namespace VEZIMENAMOYPOEZD.Controller
{
   public class MainMenuController
    {
        
        private readonly MainMenuView _menuView;
        private readonly MenuChoiceStorage _choiceStorage;

       

        private AdminController admin;



        public MainMenuController()
        {
            
            _menuView = new MainMenuView();
            _choiceStorage = MenuChoiceStorage.GetInstance();
            admin = new AdminController();
        }

        private void MenuSelectedHandler(int menu)
        {
            switch (menu)
            {
                case 1:
                    ShowTripsTable();
                    break;
                case 2:
                    FindById();
                    break;
                case 3:
                    FindByLastOstanovochka();
                    break;
                case 4:
                    ShowTodayReus();
                    break;
                case 5:
                    ShowWeekReuses();
                    break;
                case 6:                   
                    _menuView.ShowPrice();                   
                    break;
                case 7:
                    ShowFreePlace();
                    break;
                case 8:
                    _menuView.ShowPassword();
                    _menuView.ShowDelOrAdd();
                    break;
                default:
                    _menuView.ShowError();
                    break;
            }
        }
        
        public void Run()
        {
            _menuView.PasswordforUser += _menuView_PasswordforUser;
            _menuView.ShowAddOrDel += _menuView_ShowAddOrDel;
            _menuView.MenuSelected += MenuSelectedHandler;
          
            _menuView.ShowHeader();
            _menuView.ShowMenu(_choiceStorage.Choices);
           
        }

      

        private void _menuView_ShowAddOrDel(int c)
        {
            switch (c)
            {
                case 1:
                    ADD();
                    break;
                case 2:
                    DELETE();
                    ShowTripsTable();
                    break;
                default:
                    EROR();
                    break;
            }
        }

        private void _menuView_PasswordforUser(int obj)
        {
            admin.PriemWork(obj);
        }

        public void Stop()
        {
            _menuView.MenuSelected -= MenuSelectedHandler;
            _menuView.ShowAddOrDel -= MenuSelectedHandler;
            
        }

        private void ShowTripsTable()
        {
            _menuView.ShowTripsTable(TripsStorage.trips);
        }
        
        private void FindById()
        {
            _menuView.FindById(TripsStorage.trips);
        }

        private void FindByLastOstanovochka()
        {
            _menuView.FindByLastOstanovochka(TripsStorage.trips);
        }

        private void ShowTodayReus()
        {
            _menuView.ShowTodayReus();
        }
        
        private void ShowWeekReuses()
        {
            _menuView.ShowWeekReus(TripsStorage.trips);
        }

        private void ShowFreePlace()
        {
            _menuView.ShooowFreePlace(TripsStorage.trips);
        }
        private void ADD()
        {
            admin.Add();
        }

        private void DELETE()
        {
            admin.Delete();
        }
        private void EROR()
        {
            admin.ShowError();
        }
       
       
    }
}
