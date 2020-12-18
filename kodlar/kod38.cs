using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizideki sayilari toplatıcaz
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };
            int toplam = 0;
            foreach(int i in sayilar)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("toplam="+toplam);
            Console.Read();

        }
    }
}
