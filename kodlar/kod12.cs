using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN SAYININ POZİTİF NEGATİF OLDUĞUNU BULAN PROGRAM

            int sayi;
            Console.WriteLine("lutfen sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi<=0)
            {
                Console.WriteLine("sayı negatif");
            }
            else
            {
                Console.WriteLine("sayı pozitif");
            }
            Console.Read();
         
        }
    }
}
