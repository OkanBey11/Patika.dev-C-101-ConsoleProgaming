using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namesapce
            ArrayList liste = new ArrayList();
            liste.Add("Okan");
            liste.Add(5);
            liste.Add('A');
            liste.Add(true);

            //içerideki verilere erişim
            Console.WriteLine(liste[0]);
            foreach (var item in liste)
                Console.WriteLine(item);

            //AddRange
            Console.WriteLine(" ***** AddRange *****");
            string[] renkler = { "Sarı", "Kırmız", "Beyaz", "Siyah" };
            List<int> sayilar =new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 11, 22, 15, 92 };

            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort - İçinde aynı değerden elemanlar varsa sortlar yoksa run timeda hata verir
            //liste.Sort();

            //Binary Search 
            Console.WriteLine("*****Bianry Search *****");
            Console.WriteLine(liste.BinarySearch(8));

            //Reverse
            Console.WriteLine("*****Reverse *****");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("***** Clear *****");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);
            Console.WriteLine("He he its empty");

            Console.ReadKey();

        }
    }
}
