using VEZIMENAMOYPOEZD.Model;
using VEZIMENAMOYPOEZD.View;

namespace VEZIMENAMOYPOEZD.Controller
{
   public class MainMenuController
    {       
        private readonly MainMenuView _menuView;
        private readonly MenuChoiceStorage _choiceStorage;
        private readonly AdminController admin;
        private readonly AdminView adminView;
        public MainMenuController()
        {
            
            _menuView = new MainMenuView();
            _choiceStorage = MenuChoiceStorage.GetInstance();
            admin = new AdminController();
            adminView = new AdminView();
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
            _menuView.ShowMenu(_choiceStorage.Choices);
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
                    adminView.Add();                                      
                    break;
                case 2:
                    adminView.DeleteTrain();
                    ShowTripsTable();
                    break;
                default:
                    admin.EROR();
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
            _menuView.ShowAddOrDel -= _menuView_ShowAddOrDel;
            _menuView.PasswordforUser -= _menuView_PasswordforUser;
            admin.Stop();
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
    }
}
