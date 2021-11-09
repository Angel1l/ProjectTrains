using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEZIMENAMOYPOEZD.Model
{
    public class MenuChoiceAdmin
    {
        public List<MenuChoiceModel> Choices { get; }

        private static MenuChoiceAdmin _instance;

        private MenuChoiceAdmin()
        {
            Choices = new List<MenuChoiceModel>
            {
                new MenuChoiceModel(1, "Добавить рейс"),
                new MenuChoiceModel(2, "Удалить рейс"),
                
            };
        }


        public static MenuChoiceAdmin GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MenuChoiceAdmin();
            }
            return _instance;
        }
    }
}
