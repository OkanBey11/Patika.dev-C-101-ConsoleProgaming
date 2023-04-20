using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif_kavrami
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

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 12345678;
            calisan1.Department = "İnsan kaynakları";

            calisan1.CalisanInf();
            Console.WriteLine("---------------");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Okan";
            calisan2.Soyad = "Birisi";
            calisan2.No = 14725836;
            calisan2.Department = "Cyber";

            calisan2.CalisanInf();

            Console.ReadKey();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Department;

        public void CalisanInf() 
        {
            Console.WriteLine($"Çalışanın Adı: {Ad}");
            Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
            Console.WriteLine($"Çalışanın Numarası: {No}");
            Console.WriteLine($"Çalışanın Departmanı: {Department}");
        }
    }
}
