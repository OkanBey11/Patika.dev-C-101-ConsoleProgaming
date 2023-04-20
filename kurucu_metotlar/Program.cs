using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurucu_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            // {
            //    [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //    {
            //      Metot Komutları
            //    }
            // }

            //Erişim Belirleyiciler
            // * Public -> her yerden erişilebilir
            // * Private -> sadece tanımlandığı sınıf içerisinde erişilebilir
            // * Internal -> sadece kendi bulunduğu proje içerisinde erişilebilir
            // * Protected -> sadece tanımlandığı sınıfta ve/veya o sınıftan kalıtım alan diğer sınıflarda erişilebilir

            Console.WriteLine("******** Çalışan 1 *********");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 12345678, "İnsan kaynakları");
            calisan1.CalisanInf();
            

            Console.WriteLine("******** Çalışan 2 *********");
            Calisan calisan2 = new Calisan("Okan", "Birisi", 14725836, "Cyber");
            calisan2.CalisanInf();

            Console.WriteLine("******** Çalışan 3 *********");
            Calisan calisan3 = new Calisan("Öyle", "Birisi");
            calisan3.CalisanInf();

            Console.ReadKey();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Department;

        public Calisan(string ad, string soyad, int no, string deparment) 
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Department = deparment;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;    
        }

        public Calisan() { }

        public void CalisanInf()
        {
            Console.WriteLine($"Çalışanın Adı: {Ad}");
            Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
            Console.WriteLine($"Çalışanın Numarası: {No}");
            Console.WriteLine($"Çalışanın Departmanı: {Department}");
        }
    }
}
