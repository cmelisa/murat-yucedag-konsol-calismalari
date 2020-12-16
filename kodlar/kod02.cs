using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kimlik olusturma

            string ad, soyad, yas, meslek, sehir;
            Console.WriteLine("adiniz: ");
            ad = Console.ReadLine();
            Console.WriteLine("soyadiniz:");
            soyad = Console.ReadLine();
            Console.WriteLine("kac yasindasiniz: ");
            yas = Console.ReadLine();
            Console.WriteLine("mesleginiz nedir: ");
            meslek = Console.ReadLine();
            Console.WriteLine("nerede yasiyorsunuz: ");
            sehir = Console.ReadLine();

            Console.WriteLine("ad:{0} soyad:{1} yas:{2} meslek:{3} sehir:{4}", ad, soyad, yas, meslek, sehir);


            Console.Read();
            


            


            
        }
    }
}
