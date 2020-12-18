using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[4];
            for (int i = 0; i < 4;i++)
            {
                Console.Write("sehir:" );
                sehirler[i] = Console.ReadLine();
                
            }
            Console.WriteLine("*****ŞEHİRLER*****");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.Read();
        }
    }
}
