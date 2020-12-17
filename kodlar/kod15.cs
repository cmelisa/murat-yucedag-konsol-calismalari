using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, proje, not;

            Console.Write("1.sınav notunuzu girin: ");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.sınav notunuzu girin: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("proje notunuzu girin: ");
            proje = Convert.ToInt32(Console.ReadLine());

            not = (sinav1 + sinav2 + proje) / 3;

            if (not >0 && not<=30)
            {
                Console.WriteLine("durum:vasat");
            }
            else if(not>30 && not<=70)
            {
                Console.WriteLine("durum:iyileştirilmeli");
            }
            else if(not>70 && not <= 100)
            {
                Console.WriteLine("durum:iyi");
            }
            Console.Read();
        }
    }
}
