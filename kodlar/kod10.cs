using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            Console.Write("lutfen adinizi giriniz: ");
            isim = Console.ReadLine();
            if (isim == "baran")
            {
                Console.WriteLine("doğru isim girişi");
            }
            else
            {
                Console.WriteLine("hatalı isim girişi");
            }
            Console.Read();

        }
    }
}
