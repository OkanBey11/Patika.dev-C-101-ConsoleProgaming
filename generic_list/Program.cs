using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T --> object türünde

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmzı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve list foreach kullanımı
            foreach (var i in sayiListesi)
                Console.WriteLine(i); 
            foreach (var i in renkListesi)
                Console.WriteLine(i);

            //sayiListesi.ForEach(i => Console.WriteLine(i));
            //renkListesi.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("---");

            //Eleman Çıakrma
            sayiListesi.Remove(92);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(i => Console.WriteLine(i));
            renkListesi.ForEach(i => Console.WriteLine(i));

            //Liste içinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içinde bulundu");

            // Eleman ile elemana erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı")); //?

            //Diziyi Liste Çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş" };
            LinkedList<string> hayvanlarListesi = new LinkedList<string>(hayvanlar);

            // Liste temizleme
            hayvanlarListesi.Clear();

            // liste içerisinde nesne tutma
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Okan";
            kullanici1.Soyisim = "Biri";
            kullanici1.Yas = 23;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Efe";
            kullanici2.Soyisim = "Biri";
            kullanici2.Yas = 33;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Mehmet",
                Soyisim = "Biri",
                Yas = 99
            });

            foreach (var item in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi : " + item.Isim);
                Console.WriteLine("Kallanici SoyAdi : " +item.Soyisim);
                Console.WriteLine("Kullanici Yas : " + item.Yas);
            }



            Console.ReadKey();

        }
    }

    public class Kullanıcılar
    {
        string isim;

        string soyisim;

        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
