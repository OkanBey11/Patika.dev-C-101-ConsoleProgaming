using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start 
            int[] sayiDizisi = { 23, 13, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("*** Sırasız bir dizi ***");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("*** Sıralı bir dizi ***");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("*** Array Clear ***");
            // sayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı 0 lar
            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse 
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resive 
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.ReadKey();
        }
    }
}
