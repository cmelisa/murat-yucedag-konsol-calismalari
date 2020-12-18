using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //OLUŞTURDUĞUMUZ DİZİDE 2 YE BÖLENLERİ ALALIM.
            int[] rakamlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           
                foreach(int i in rakamlar)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
            }
        }
    }

