using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //İSTANBUL İLİNİN DİĞER İLLERE UZAKLIĞINI YAZDIRAN PROGRAM
            string sehir;
            Console.WriteLine("şehir giriniz:");
            sehir = Console.ReadLine();

            switch (sehir)
            {
                case "kocaeli":Console.WriteLine("istanbula uzaklığı 5 km");
                    break;
                case "izmir":Console.WriteLine("istanbula uzaklığı 50 km");
                    break;
                case "mardin":Console.WriteLine("istanbula uzaklığı 300 km");
                    break;
                case "ankara":Console.WriteLine("istanbula uzaklığı 800 km");
                    break;
                case "malatya":Console.WriteLine("istanbula uzaklığı 700 km");
                    break;
                default:Console.WriteLine("sehir tanımlanmamış");
                    break;

            }
            Console.Read();
        }
    }
}
