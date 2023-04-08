using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama 
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilerde değer atama ve veri erişimi
            renkler[0] = "Kırmızı";
            dizi[0] = 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[0]);

            // Döngülerle Dizi kullanımı
            // klavyeden girilen n tane sayının toplamı

            Console.WriteLine("Lütfen dizinin boyutunu giriniz");
            int boyut = int.Parse(Console.ReadLine());
            int[] n_dizi = new int[boyut];
            int toplam = 0;
            for(int i = 0; i < boyut; i++)
            {
                Console.WriteLine("Lütfen " + (i+1).ToString() + ".Sayıyı giriniz : ");
                n_dizi[i] = int.Parse(Console.ReadLine());
                toplam += n_dizi[i];
            }
            Console.WriteLine("Sayı toplamı : " + toplam.ToString());
            Console.WriteLine("Sayı Ortalama : " + (toplam / boyut).ToString());

            int fark = 0;
            foreach(var sayi in n_dizi)
            {
                fark -= sayi;
            }
            Console.WriteLine("Buda *-* foreach *-* kullanarak bulduğun fark : " + fark);

            Console.ReadKey();
        }
    }
}
