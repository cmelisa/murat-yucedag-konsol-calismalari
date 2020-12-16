using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN ALINAN DEĞER İLE KARE VE DİKDÖRTGEN ALAN HESABI
            int sayi1, sayi2, sayi3, alan1,alan2;
            Console.WriteLine("kare alan hesabı");
            Console.WriteLine("karenin kenar uzunluğunu giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            alan1 = sayi1 * sayi1;
            Console.WriteLine("karenin alanı: " + alan1);

            Console.WriteLine();


            Console.WriteLine("dikdörtgnin kısa kenar uzunluğunu giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dikdörgenin uzun kenar uzunluğunu giriniz:");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            alan2 = sayi2 * sayi3;
            Console.WriteLine("dikdörtgenin uzunluğu: " + alan2);
            Console.Read();



        }
    }
}
