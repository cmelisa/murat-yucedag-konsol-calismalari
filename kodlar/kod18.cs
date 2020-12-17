using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KULLANICIDAN ALINAN MEVSİME GÖRE AY YAZDIRMA 
            string mevsim;
            Console.Write("mevsim giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "kış":Console.WriteLine("aralık-ocak-şubat");
                    break;
                case "ilkbahar":Console.WriteLine("mart-nisan-mayıs");
                    break;
                case "yaz":Console.WriteLine("haziran-temmuz-ağustos");
                    break;
                case" sonbahar":Console.WriteLine("eylül-ekim-kasım");
                    break;
                default:Console.WriteLine("hatalı giriş");
                    break;
            }
            Console.Read();
        }
    }
}
