using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            //int outSayi;

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarı ile çevrildi");
            }
            else
            {
                Console.WriteLine("Başarısız Oldu");
            }

            Metotlar instance = new Metotlar();
            instance.topla(4, 5, out int toplanan);
            Console.WriteLine(toplanan);
            instance.EkranaYaz(sayi);
            instance.EkranaYaz(999);
            instance.EkranaYaz("11","11");

            Console.ReadKey();
        }
    }

    class Metotlar
    {
        public void topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        // Overloading 
        public void EkranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYaz(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYaz(string veri, string veri2)
        {
            Console.WriteLine(veri + veri2);
        }
    }
}
