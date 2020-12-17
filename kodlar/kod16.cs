using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, indirim, ödeme;
            Console.Write("alışveriş tutarınız ne kadar? ");
            x = Convert.ToInt32(Console.ReadLine());


            if (x < 100)
            {
                indirim = x * 10 / 100;
                ödeme = x - indirim;
                Console.WriteLine("alışverişinizden {0} indirim kazandınız ve faturanız {1} liradır. iyi günler dileriz",indirim,ödeme);
            }
            else if (x >= 100 && x<150)
            {
                indirim = x * 15 / 100;
                ödeme = x - indirim;
                Console.WriteLine("alışverişinizden {0} indirim kazandınız ve faturanız {1}liradır.iyi günler dileriz.", indirim, ödeme);

            }
            Console.Read();

        }
    }
}
