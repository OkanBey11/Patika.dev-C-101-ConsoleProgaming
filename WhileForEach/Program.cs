using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak konsoldan girilen sayıya(dahil) kadar olan sayıların ortalamasını konsola bastıran program
            Console.WriteLine("1 den kaça akdar olan sayıların ortalamasını verelrim size : ");
            int sayi =  int.Parse(Console.ReadLine());
            int temp = sayi;
            int toplam = 0;
            while (sayi >= 1)
            {
                toplam += sayi;
                sayi--;
            }
            Console.WriteLine("Ortalamanız : " + toplam/temp);

            // a dan z ye kadar olan harfleri yazma
            char charset = 'a';
            while(charset <= 'z')
            {
                Console.Write(charset);
                charset++;
            }

            Console.WriteLine();
            // foreach
            string[] meyveler = {"Elma","Muz","Armut","Üzüm"};
            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);
            }

            Console.ReadKey();
        }
    }
}
