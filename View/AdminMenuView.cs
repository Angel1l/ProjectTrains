﻿using System;
using VEZIMENAMOYPOEZD.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEZIMENAMOYPOEZD.View
{
    class AdminMenuView
    {
        public void admin()
        {
            int b = 123;
            int a;
            Console.WriteLine("Введите пароль:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Добро пожаловать в клуб дружище");
                Console.WriteLine("Для того что бы создать поезд напишите: 1");
                Console.WriteLine("Для того что бы удалить поезд напишите: 2");                
                switch (Console.ReadLine())
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Delete();
                        
                        break;
                    default:
                        ShowError();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Pshel von");
            }

        }

        public void Add()
        {
            int a;
            DateTime b;
            string v;
            DateTime c;
            string n;
            string m;
            int s;
            Console.WriteLine("Для того что бы добавить поезд следуйте инcтрукции");            
            Console.WriteLine("1: Введите айди рейса");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2: Введите время отбытия рейса");
            b = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("3: Место отбытия рейса");
            v = Convert.ToString(Console.ReadLine());
            Console.WriteLine("4: Время прибытия");
            c = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("5: Место прибытия");
            n = Convert.ToString(Console.ReadLine());
            Console.WriteLine("6: Марка автобуса");
            m = Convert.ToString(Console.ReadLine());
            Console.WriteLine("7: Цена билета");
            s = Convert.ToInt32(Console.ReadLine());

            //TripsStorage.trips.Add(a); Chtoto poxojee
        }

        public void Delete()
        {
            int a;
            Console.WriteLine("Введите номер рейса который хотите удалить:");
            a = Convert.ToInt32(Console.ReadLine());

            TripsStorage.trips.RemoveAt(a);
        }

        public void ShowError()
        {
            Console.WriteLine("ERROR!!");
        }
    }
}
