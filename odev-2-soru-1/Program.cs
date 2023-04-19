using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_soru_1
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            List<int> asalSayilar = new List<int>();
            List<int> asalOlmayanSayilar = new List<int>();

            int sayac = 0;
            int toplamAsal = 0;
            int toplamAsalOlmayan = 0;

            while (sayac < 20)
            {
                Console.Write("Sayi giriniz: ");
                if (int.TryParse(Console.ReadLine(), out int sayi))
                {
                    if (sayi > 0)
                    {
                        if (IsPrime(sayi))
                        {
                            asalSayilar.Add(sayi);
                            toplamAsal += sayi;
                        }
                        else
                        {
                            asalOlmayanSayilar.Add(sayi);
                            toplamAsalOlmayan += sayi;
                        }

                        sayac++;
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz bir deger girdiniz. Lutfen pozitif bir tamsayi giriniz.");
                }
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Asal sayilar: ");
            asalSayilar.Sort();
            asalSayilar.Reverse();
            foreach (int sayi in asalSayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Toplam asal sayilarin adedi: " + asalSayilar.Count);
            Console.WriteLine("Asal sayilarin ortalamasi: " + (double)toplamAsal / asalSayilar.Count);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Asal olmayan sayilar: ");
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();
            foreach (int sayi in asalOlmayanSayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Toplam asal olmayan sayilarin adedi: " + asalOlmayanSayilar.Count);
            Console.WriteLine("Asal olmayan sayilarin ortalamasi: " + (double)toplamAsalOlmayan / asalOlmayanSayilar.Count);

            Console.ReadKey();
        }
    }
}
