using VEZIMENAMOYPOEZD.Model;
using VEZIMENAMOYPOEZD.View;

namespace VEZIMENAMOYPOEZD.Controller
{
  public class AdminController
    {
        private readonly AdminMenuView _adminView;
        private readonly MenuChoiceStorage _choiceStorage;
        public AdminController()
        {
            _adminView = new AdminMenuView();
            _choiceStorage = MenuChoiceStorage.GetInstance();
        }
        public void ADMIN(int menu)
        {
            ADMIN();
            switch (menu)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Delete();
                    break;               
                default:
                    
                    break;
            }
        }
        private void ADMIN()
        {
            _adminView.ADMIN();
        }

        private void Add()
        {
            _adminView.Add();
        }

        private void Delete()
        {
            _adminView.Delete();
        }
    }

}
