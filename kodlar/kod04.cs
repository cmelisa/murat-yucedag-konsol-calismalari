using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖĞRENCİ NOT HESAPLAMA
            int sinav1, sinav2, sinav3, proje,not;
            Console.Write("1.sınav notunuzu girin:");
            sinav1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sınav notunuzu girin:");
            sinav2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3.sınav notunuzu girin:");
            sinav3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("proje notunuzu girin:");
            proje = Convert.ToInt32(Console.ReadLine());
            not = ((sinav1 + sinav2 + sinav3 + proje) / 4);
            Console.Write("dönem sonu puanınız= {0}", not);
            Console.Read();
        }
    }
}
