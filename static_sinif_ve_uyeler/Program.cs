using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_sinif_ve_uyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı : {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IT");
            Console.WriteLine("Çalışan sayısı : {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Ayşe", "Yılmaz", "IT");
            Calisan calisan2 = new Calisan("Ayşe", "Yılmaz", "IT");
            Calisan calisan3 = new Calisan("Ayşe", "Yılmaz", "IT");
            Calisan calisan4 = new Calisan("Ayşe", "Yılmaz", "IT");
            Console.WriteLine("Çalışan sayısı : {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama Sonuc : {0}", Islemeler.Topla(11, 22));
            Console.WriteLine("Çıkarma sonuc : {0}", Islemeler.Cikar(22, 11));


            Console.ReadKey();
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemeler
    {
        public static long Topla (int x, int y)
        {
            return (long) (x + y);
        }

        public static long Cikar(int x, int y)
        {
            return (long)(x - y);
        }
    }
}
