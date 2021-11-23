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
            TripsStorage.trips.RemoveAt(getnomber);
        }
        public void PriemWork (int a)
        {
            
            int b = 123;           
            if (a == b)
            {
               


            }
            else
            {
                ShowError();
                return;
            }
            
        }              
        public void DeteleTrain(int getnomber)
        {
            AdminView_Deletetrain(getnomber);   
        }
        private void ShowError()
        {
            _menuView.ShowwError();
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
