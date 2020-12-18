using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 ELEMANLI KLAVYEDEN ALDIĞIMIZ DEĞERLERİN EN BÜYÜĞÜNÜ YAZDIRMA
            int[] sayilar = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write((i+1).ToString()+".sayı giriniz: ");
                sayilar[i] =Convert.ToInt32( Console.ReadLine());

            }
            int enbuyuk;
            enbuyuk = sayilar[0];
            for (int i = 1; i < 5; i++)
            {
                if (enbuyuk < sayilar[i])
                {
                    enbuyuk = sayilar[i];
                }
            }
            Console.WriteLine( enbuyuk+" girilen en buyuk değerdir.");
            Console.Read();

        }
    }
}
