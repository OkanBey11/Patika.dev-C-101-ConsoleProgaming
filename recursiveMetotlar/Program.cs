using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursiveMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // recursive yinelemeli fonksiyon
            // 3 ** 4
            int result = 1;
            for(int i=0; i<4; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
            Islermler instance = new Islermler();
            Console.WriteLine(instance.ust(3,4));

            //Extension metotlar
            string ifade = "Okan Goztak Burada Kodluyor";
            Console.WriteLine(ifade.CheakSpcese());
            if(ifade.CheakSpcese())
                Console.WriteLine(ifade.RemoveWhiteSpaces());

            Console.WriteLine(ifade.MakeUpper());
            Console.WriteLine(ifade.MakeLower());

            int[] dizicik = { 11, 6, 3, 4, 9, 7, 2, 0 };
            dizicik.SortArray();
            dizicik.EkranaYaz();

            int sayi = 6;
            Console.WriteLine(sayi.IsEvenNum());


            Console.ReadKey();
        }
    }

    public class Islermler
    {
        public int ust(int sayi , int us)
        {
            if (us < 2)
                return sayi;
            return ust(sayi, us - 1) * sayi;
        }

    }

    public static class Extensions
    {
        public static bool CheakSpcese(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join("", dizi);
        }

        public static string MakeUpper(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLower(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        } 

        public static void EkranaYaz(this int[] param)
        {
            foreach (int item in param)
                Console.Write(item + "\t");
        }

        public static bool IsEvenNum(this int param)
        {
            return param % 2 == 0;
        }
    }
}
