using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Programing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba burada c# ın bizlere sunduğu değişkenler söz konusu");
            byte a = 5;  //1 byte
            sbyte b = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; // 2 byte sadeece pozitif

            Int16 i16 = 555; //2 byte yer kaplar
            int i = 555;     //4 byte yer kaplar
            Int32 i32 = 555; //4 byte yer kaplar
            Int64 i64 = 555; //8 byte yer kaplar

            uint ui = 5;     //4 byte
            long lo = 5;     //8 byte
            ulong ulo = 5;   //8 byte

            //reel sayilar
            float f = 55;    //4 byte
            double d = 55;   //8 byte
            decimal dd = 55; //16 byte

            char c = 'a';    //2 byte
            string str = "sinirsiz"; //sinirsiz

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);


            //Butun degiskenler objectten türer
            object o1 = 'a';
            object o2 = "deneme";
            object o3 = 3;

            //degisken donusum
            string str1 = "20";
            int int1 = 20;
            Console.WriteLine("String + String: " + str1 + int1.ToString());
            Console.WriteLine("int + int: " + (int1 + Convert.ToInt32(str1)).ToString());

            Console.ReadKey();
        }
    }
}
