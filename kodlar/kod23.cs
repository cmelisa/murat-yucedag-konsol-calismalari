using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 İLE 10 ARASINDAKİ SAYILARI TOPLAMA
            int i,toplam;
            toplam = 0;
            for (i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
               
            }
            Console.WriteLine(toplam);
            Console.Read();
        }
    }
}
