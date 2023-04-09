using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirleyici geri_donustipi metot_adi(parametreListesi/arguman)
            //{
            //    Komutlar;
            //}
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);


            Console.WriteLine(Topla(11, 22));


            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir("ELMA");
            Console.WriteLine("Referans olarak : "+ornek.ArtırVeTopla(ref a, ref b).ToString());

            Console.ReadKey();
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri = "KELİME")
        {
            Console.WriteLine("***_" + veri + "_***");
        }

        public int ArtırVeTopla(ref int deger1, ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
    }

}
