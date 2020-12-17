using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 İLE 100 ARASINDA 9 A TAM BÖLENLERİN SAYISI
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
