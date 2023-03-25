using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            Console.WriteLine("*** ATAMA OPERATORS ***");
            int x = 3;
            int y = 3;

            y = y + 2;            // y = 5
            Console.WriteLine(y); 
            y +=  2;              // y = 7
            Console.WriteLine(y);
            y /=  1;               // y = 7
            Console.WriteLine(y);
            y *=  2;               // y = 14
            Console.WriteLine(y);


            // Mantıksal operatörler
            // ||, &&, !
            Console.WriteLine("*** MANTIKSAL OPERATORS ***");
            bool isSuccess = true;
            bool isComplate = false;

            if (isSuccess && isComplate)
                Console.WriteLine("Harika!");

            if (isSuccess || isComplate)
                Console.WriteLine("Harika!");

            if (isSuccess && !isComplate)
                Console.WriteLine("Harika!");

            // ilişkisel opertörler
            // <, >, <=, >=, ==, !=
            Console.WriteLine("*** ILISKISEL OPERATORS ***");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            // Matematiksel operatörler
            // + - * / %
            Console.WriteLine("*** MATEMATIKSEL OPERATORS ***");
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = 0;
            sonuc1 = sayi1 + sayi2;    // 15
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;    // 5
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;    // 50
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 / sayi2;    // 2
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 % sayi2;    // 0
            Console.WriteLine(sonuc1);


            Console.ReadKey();

        }
    }
}
