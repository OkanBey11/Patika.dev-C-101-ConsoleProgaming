using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_cath
{
    class Program
    {
        static void Main(string[] args)
        {

            try 
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı = " + sayi);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Hata :" + ex.Message.ToString());
            }
            finally 
            {
                Console.WriteLine("İşlem tamam");
            }

            try 
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException exx) 
            {
                Console.WriteLine("Değer null girilmez");
                Console.WriteLine(exx);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Değer null girilmez");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex) 
            {
                Console.WriteLine("Menzil dışı");
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
