using System;

namespace VEZIMENAMOYPOEZD.View
{
   public class InputComponent
    {
        public int GetInputInt()
        {
            bool isParsed;
            int result;
            do
            {
                Console.WriteLine("Введите число и нажмите Enter");
                var userChoice = Console.ReadLine();
                isParsed = int.TryParse(userChoice, out result);
            } while (!isParsed);
            return result;
        }
    }
}
