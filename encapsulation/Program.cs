using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Ayşe";
            ogrenci1.Soyisim = "Yılmaz";
            ogrenci1.OgrenciNo = 155;
            ogrenci1.Sinif = 4;
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Okan","Arda", 211,1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

            Console.ReadKey();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set {
                if (value < 1) 
                {
                    Console.WriteLine("Sınıf 1 den daha düşük sınıflar yok");
                    sinif = 1;
                }
                else
                    sinif = value;
            } 
        }

        public Ogrenci() { }


        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******* Öğrenci Bilgisi *******");
            Console.WriteLine("Öğrenci Adı      :{0}",Isim);
            Console.WriteLine("Öğrenci Soyadı   :{0}", Soyisim);
            Console.WriteLine("Öğrenci Numarası :{0}", OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf    :{0}", Sinif);
        }

        public void SinifAtlat() 
        {
            this.Sinif++;
        }

        public void SinifDusur()
        {
            this.Sinif--;
        }
    }
}
