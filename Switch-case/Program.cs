﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayındasınız");
                    break;
                case 6:
                    Console.WriteLine("Haziran ayındasınız");
                    break;
                case 7:
                    Console.WriteLine("Temuz ayındasınız");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız");
                    break;
                case 9:
                    Console.WriteLine("Eylül ayındasınız");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayındasınız");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayındasınız");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındasınız");
                    break;
                default:
                    Console.WriteLine("Ayda Bir yanlışlık olmalı");
                    break;

            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Ayrıca Kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ayrıca İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Ayrıca Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ayrıca Sonbahar mevsimi");
                    break;
            }
            Console.ReadKey();
        }
    }
}