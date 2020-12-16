using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //İF ELSE YAPISI-1
            string isim;
            isim = "mehmet";
            if (isim == "mehmet")
            {
                Console.Write("doğru isim girişi");
            }
            else
            {
                Console.Write("hatalı isim girişi");
            }
            Console.Read();

        }
    }
}
