using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir dizi boyutu giriniz : ");
            int dizi_uzunluk = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[dizi_uzunluk];

            for(int i=0; i<dizi_uzunluk; i++)
            {
                Console.WriteLine("Lütfen sayi giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                dizi[i] = sayi;
               
            }
            Console.Write("Çift Sayılar : ");
            foreach (int item in dizi)
                if (item % 2 == 0)
                    Console.Write(item + " ");
            Console.WriteLine("\n ************* \n");

            Console.Write("Lütfen pozitif bir sayı girin: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Lütfen bir pozitif sayı daha girin: ");
            int m = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine($"Lütfen {n} adet pozitif sayı girin:");

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            Console.WriteLine($"{m}'e eşit ya da tam bölünen sayılar:");
            foreach (int number in numbers)
            {
                if (number % m == 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine("\n ************* \n");

            Console.Write("Lütfen pozitif bir sayı girin: ");
            int a = int.Parse(Console.ReadLine());

            string[] words = new string[a];
            Console.WriteLine($"Lütfen {a} adet kelime girin:");

            for (int i = 0; i < a; i++)
            {
                string word = Console.ReadLine();
                words[i] = word;
            }

            Console.WriteLine("Girilen kelimelerin ters sıralaması:");
            for (int i = a - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine("\n ************* \n");

            Console.Write("Lütfen bir cümle yazın: ");
            string sentence = Console.ReadLine();

            int wordCount = 0;
            int letterCount = 0;

            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    wordCount++;
                }
                else
                {
                    letterCount++;
                }
            }

            // Son kelimeyi hesaba katmak için kelime sayısı bir artırılır.
            wordCount++;

            Console.WriteLine($"Cümledeki kelime sayısı: {wordCount}");
            Console.WriteLine($"Cümledeki harf sayısı: {letterCount}");
            Console.WriteLine("\n ************* \n");

            Console.ReadKey();
        }
    }
}
