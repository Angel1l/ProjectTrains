using VEZIMENAMOYPOEZD.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VEZIMENAMOYPOEZD.View
{
    public class AdminView
    {
        public event Action<int> Deletetrain = delegate { };

        public void DeleteTrain()
        {
            int getnomber;
            Console.WriteLine("Введите номер рейса который хотите удалить: ");
            getnomber = Convert.ToInt32(Console.ReadLine());
            Deletetrain(getnomber);
        }





    }
}
