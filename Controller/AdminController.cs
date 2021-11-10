using System;
using VEZIMENAMOYPOEZD.Model;
using VEZIMENAMOYPOEZD.View;

namespace VEZIMENAMOYPOEZD.Controller
{
  public class AdminController
    {

        private readonly AdminMenuView _adminView;
        private readonly MenuChoiceAdmin _choiceStorageadmin;

        public AdminController()
        {

            _adminView = new AdminMenuView();
            _choiceStorageadmin = MenuChoiceAdmin.GetInstance();
        }
             
    }
}
