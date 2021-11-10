using VEZIMENAMOYPOEZD.Model;
using VEZIMENAMOYPOEZD.View;

namespace VEZIMENAMOYPOEZD.Controller
{
   public class MainMenuController
    {
        private readonly AdminMenuView _adminView;
        private readonly MenuChoiceAdmin _choiceStorageadmin;
        private readonly MainMenuView _menuView;
        private readonly MenuChoiceStorage _choiceStorage;


       

        public MainMenuController()
        {
            _adminView = new AdminMenuView();
            _choiceStorageadmin = MenuChoiceAdmin.GetInstance();
            _menuView = new MainMenuView();
            _choiceStorage = MenuChoiceStorage.GetInstance();
            
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
                    _adminView.admin();
                    break;
                default:
                    _menuView.ShowError();
                    break;
            }
        }

        public void Run()
        {
            _menuView.MenuSelected += MenuSelectedHandler;

            _menuView.ShowHeader();
            _menuView.ShowMenu(_choiceStorage.Choices);
        }

        public void Stop()
        {
            _menuView.MenuSelected -= MenuSelectedHandler;
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
        
        
    }
}
