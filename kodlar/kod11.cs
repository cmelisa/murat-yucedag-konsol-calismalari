using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string baskent;
            Console.WriteLine("Türkiye'nin başkenti neresidir?");
            baskent = Console.ReadLine();
            if (baskent == "ankara")
            {
                Console.WriteLine("tebrikler, bildiniz");
            }
            else
            {
                Console.WriteLine("yanlış bildiniz.");
            }
            Console.Read();
        }
    }
}
