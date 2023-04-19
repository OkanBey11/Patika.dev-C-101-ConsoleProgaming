using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cumle giriniz: ");
            string cumle = Console.ReadLine();

            char[] sesliHarfler = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] cumleHarfler = cumle.ToLower().ToCharArray();
            Array.Sort(cumleHarfler);

            int sesliSayisi = 0;

            Console.Write("Cumledeki sesli harfler: ");

            for (int i = 0; i < cumleHarfler.Length; i++)
            {
                if (Array.IndexOf(sesliHarfler, cumleHarfler[i]) != -1)
                {
                    Console.Write(cumleHarfler[i] + " ");
                    sesliSayisi++;
                }
            }

            if (sesliSayisi == 0)
            {
                Console.WriteLine("Cumlede sesli harf bulunamadi.");
            }
            Console.ReadKey();
        }
    }
}
