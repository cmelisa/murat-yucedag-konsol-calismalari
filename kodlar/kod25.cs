using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //120 SAYISININ TAM BÖLENLERİNİN SAYISI
            int i;
            for (i = 1; i <= 120; i++)
            {
                if (120 % i == 0)
                {
                    Console.WriteLine(i);

                }
            }
            Console.Read();
        }
    }
}
