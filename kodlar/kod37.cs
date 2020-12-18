using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir nesne veya dizinin tüm elemanlarına ulaşmak için foreach kullanılır.
            //foreach(değişkenTürü-değişkenAdı-in-diziAdı)
            string[] sehirler = { "mersin", "izmir", "kocaeli", "artvin", "erzurum", "şanlıurfa" };
            foreach(string i in sehirler)
            {
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
