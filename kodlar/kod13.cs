using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN ÖĞRENCİ NOTUNUN GEÇME KALMA HESABI

            int not,sinav1,sinav2;

            Console.WriteLine("1. sınav puanınızı giriniz: ");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sınav puanınızı giriniz: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            not = ((sinav1 + sinav2) / 2);
            if (not <= 60)
            {
                Console.WriteLine("ders başarısız,kaldınız");
            }
            else
            {
                Console.WriteLine("ders başarılı,geçtiniz");
            }
            Console.Read();
        }
    }
}
