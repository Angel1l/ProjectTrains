using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEZIMENAMOYPOEZD.Model
{
   public class MenuChoiceStorage
    {
        public List<MenuChoiceModel> Choices { get; }
        private static MenuChoiceStorage _instance;
        private MenuChoiceStorage()
        {
            Choices = new List<MenuChoiceModel>
            {
                new MenuChoiceModel(1, "Показать все рейсы"),
                new MenuChoiceModel(2, "Найти по номеру рейса"),
                new MenuChoiceModel(3, "Найти по конечной остановке"),
                new MenuChoiceModel(4, "Показать рейсы на сегодня"),
                new MenuChoiceModel(5, "Показать рейсы на неделю"),
                new MenuChoiceModel(6, "Цены на билет"),
                new MenuChoiceModel(7, "Показать количество мест"),
                new MenuChoiceModel(8, "Войти как админ")
            };
        }     
        public static MenuChoiceStorage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MenuChoiceStorage();
            }
            return _instance;
        }
    }
}
