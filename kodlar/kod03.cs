using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //aritmetik ortalama
            int sayi1, sayi2, ort;
            Console.Write("ortalaması alınacak 2 sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            ort = ((sayi1 + sayi2) / 2);
            Console.WriteLine("girilen sayinin ortalamasi= {0}", ort);
            Console.Read();
        }
    }
}
