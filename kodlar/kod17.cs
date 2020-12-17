using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN MEVSİME GÖRE AYLARI YAZMA PROGRAMI

            string mevsim;
            Console.WriteLine("hangi mevsimin aylarını görmek istiyorsanız o mevsimi yazınız");
            mevsim = Console.ReadLine();

            if (mevsim == "kış")
            {
                Console.WriteLine("aralık-ocak-şubat");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("mart-nisan-mayıs");
            }
            else if (mevsim == "yaz")
            {
                Console.WriteLine("haziran-temmuz-ağustos");

            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine("eylül-ekim-kasım");
            }
            else
            {
                Console.WriteLine("hatalı giriş");
            }
            Console.Read();

        }
    }
}
