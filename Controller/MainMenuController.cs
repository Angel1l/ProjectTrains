using VEZIMENAMOYPOEZD.Model;
using VEZIMENAMOYPOEZD.View;

namespace VEZIMENAMOYPOEZD.Controller
{
   public class MainMenuController
    {
        private readonly MainMenuView _menuView;
        private readonly MenuChoiceStorage _choiceStorage;

        public MainMenuController()
        {
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
    }
}
