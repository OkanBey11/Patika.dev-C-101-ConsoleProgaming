using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Sayi giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                sayilar[i] = sayi;
            }

            Array.Sort(sayilar);

            int toplamBuyuk = 0;
            for (int i = 19; i >= 17; i--)
            {
                Console.WriteLine("En buyuk " + (20 - i) + ". sayi: " + sayilar[i]);
                toplamBuyuk += sayilar[i];
            }

            int toplamKucuk = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("En kucuk " + (i + 1) + ". sayi: " + sayilar[i]);
                toplamKucuk += sayilar[i];
            }

            double ortalamaBuyuk = (double)toplamBuyuk / 3;
            double ortalamaKucuk = (double)toplamKucuk / 3;

            Console.WriteLine("En buyuk sayilarin ortalamasi: " + ortalamaBuyuk);
            Console.WriteLine("En kucuk sayilarin ortalamasi: " + ortalamaKucuk);
            Console.WriteLine("Ortalama toplamlari: " + (ortalamaBuyuk + ortalamaKucuk));

            Console.ReadKey();
        }
    }
}
