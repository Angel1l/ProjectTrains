using VEZIMENAMOYPOEZD.Controller;
using System;
namespace VEZIMENAMOYPOEZD
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuController = new MainMenuController();
            menuController.Run();
            menuController.Stop();
        }
    }
}
