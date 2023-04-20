using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cuma);
            int sicaklik = 32;

            if (sicaklik <= (int)HavaDurumu.Normal) 
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim!");
            }
            else if (sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün!");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.Soguk)
            {
                Console.WriteLine("Hadi dışarıya çıkalım!");
            }


            Console.ReadKey();
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSıcak = 30 
    }
}
