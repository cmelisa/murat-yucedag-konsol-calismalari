using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //KULLANICI TEK SAYI GİRENE KADAR SAYI GİRİŞİ ALAN PROGRAM
            int i;
            Console.WriteLine(" tek sayı girin");
            i =Convert.ToInt32( Console.ReadLine());
            while (i % 2 == 0)
            {
                Console.WriteLine("tek değil tekrar deneyin");
                i = Convert.ToInt32(Console.ReadLine());
              

            }
            Console.WriteLine("tek sayı girdiniz");
            Console.Read();
        }
    }
}
