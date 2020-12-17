using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLAVYEDEN GİRİLEN SAYIYA GÖRE HAFTANIN İLGİLİ GÜNÜNÜ YAZDIRAN PROGRAM
            int rakam;
            Console.Write("1 ile 7 arasında rakam giriniz: ");
            rakam = Convert.ToInt32(Console.ReadLine());
            switch (rakam) {
                case 1:Console.Write("gün:pazartesi");
                    break;
                case 2:Console.Write("gün:salı");
                    break;
                case 3:Console.Write("gün:çarşamba");
                    break;
                case 4:Console.Write("gün:perşembe");
                    break;
                case 5:Console.Write("gün:cuma");
                    break;
                case 6:Console.Write("gün:cumartesi");
                    break;
                case 7:Console.Write("gün:pazar");
                    break;
                default: Console.Write("hatalı giriş");
                    break;
            }
            Console.Read();
                
        }
    }
}
