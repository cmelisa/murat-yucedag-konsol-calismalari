using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 4, 6, 9, 78, 56 };
            foreach(int i in sayilar)
            {
                Console.WriteLine(i);

            }
            Console.Read();

        }
    }
}
