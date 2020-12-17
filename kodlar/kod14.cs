using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN SAYININ TEK Mİ ÇİFT Mİ OLDUĞUNU BULAN PROGRAM

            int sayi;
            Console.WriteLine("sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("girilen sayi cift.");
            }
            else
            {
                Console.WriteLine("girilen sayi tek");
            }
            Console.Read();
        }
    }
}
