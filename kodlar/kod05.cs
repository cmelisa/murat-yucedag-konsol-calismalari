using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //iki sayinin toplami
            int sayi1, sayi2, toplam;
            Console.WriteLine("toplamak istediginiz sayilari girin:");
            sayi1 =Convert.ToInt32( Console.ReadLine());
            sayi2 =Convert.ToInt32( Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("girdiginiz sayilarin toplami= {0}", toplam);
            Console.Read();
        }
    }
}
