using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("**** Implicit Conversion ****");
            byte a = 5;
            sbyte b = 20;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Okan";
            char f = 'k';
            object g = e + f + d;        // diğer veri türleri objecten türediği için bu noktada object kullanmak avantajlı
            Console.WriteLine("g: " + g);

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("**** Explicit Conversion ****");

            int x = 11;
            byte y = (byte)x;
            Console.WriteLine("y : " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("z : " + z);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("w : " + w);
            Console.WriteLine("v : " + v);

            //ToString Metodu
            Console.WriteLine("**** ToString Metodu ****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy);

            string zz = 11.5f.ToString();
            Console.WriteLine("zz : " + zz);

            //System.Convert
            Console.WriteLine("**** System Convert ****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2, toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);

            //Parse
            Console.WriteLine("**** Parse ****");
            ParseMethod();


            Console.ReadKey();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "11.25";

            int sayi11 = Int32.Parse(metin1);
            double sayi12 = Double.Parse(metin2);

            Console.WriteLine("sayisal cevrim : " + sayi11);
            Console.WriteLine("double cevrim : " + sayi12);
        }
    }
}
