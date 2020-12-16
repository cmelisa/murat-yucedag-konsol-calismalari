using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 İŞLEM UYGULAMASI
            int sayi1, sayi2, toplam,fark,carpim,bolum;
            Console.WriteLine("toplamak istediğiniz iki sayiyi girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = (sayi1 + sayi2);
            Console.WriteLine("girilen sayilarin toplamı:{0}", toplam);
            fark = (sayi1 - sayi2);
            Console.WriteLine("girilen sayilarin farki:{0}", fark);
            carpim = (sayi1 * sayi2);
            Console.WriteLine("girilen sayilarin carpimi:{0}", carpim);
            bolum = (sayi1 / sayi2);
            Console.WriteLine("girilen sayilarin bölümü:{0}", bolum);

            Console.Read();
        }
    }
}
