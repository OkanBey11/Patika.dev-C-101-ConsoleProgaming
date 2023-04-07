using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana Girilen sayıya kadar olan tek sayıları yazdır
            Console.Write("Hangi sayıya kadar olan tek sayıları yazdırmak istersiniz :  ");
            int num = int.Parse(Console.ReadLine());
            for(int i= 0; i < num; i++)
            {
                if (i % 2 == 1) Console.WriteLine(i);
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*");
            //1 den 1000 e kadar olan tek ve çift sayıları kendi içinde toplayan kod
            int tek_toplam = 0;
            int cift_toplam = 0;
            for(int i =0; i<1000; i++)
            {
                if (i % 2 == 1) tek_toplam += i; else cift_toplam += i;
            }
            Console.WriteLine("Tek Sayı Toplamları = " + tek_toplam + "\nÇift Sayı Toplamları = " + cift_toplam);
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*");
            // 1 den 10 a kadar break ve continue

            for(int i = 0; i <10; i++)
            {
                if (i == 4) break;
                Console.WriteLine(i);
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) continue;
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
