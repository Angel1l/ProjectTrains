using VEZIMENAMOYPOEZD.Controller;
using VEZIMENAMOYPOEZD.Model;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
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