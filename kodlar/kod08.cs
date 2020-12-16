using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****ÖĞRENCİ BİLGİLERİ****");
            string ad, soyad, numara;

            Console.Write("adınız: ");
            ad = Console.ReadLine();

            Console.Write("soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("numaranız:");
            numara = Console.ReadLine();

            Console.WriteLine("****ÖĞRENCİ SINAV BİLGİLERİ****");
            double sinav1, sinav2, sinav3, proje, not;

            Console.Write("1.sınav puanınızı girin: ");
            sinav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2.sınav puanınızı girin: ");
            sinav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("3.sınav puanınızı girin: ");
            sinav3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("proje notunuzu girin: ");
            proje = Convert.ToDouble(Console.ReadLine());

            not = ((sinav1 + sinav2 + sinav2 + sinav3 + proje) / 4);

            Console.WriteLine(" {0} numaralı {1} {2} öğrencimiz, ders notunuz {3}", numara, ad, soyad, not);
            Console.Write("BAŞARILAR DİLERİZ..");

            Console.Read();
            





        }
    }
}
