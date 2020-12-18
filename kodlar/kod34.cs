using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for(int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.Write((i + 1) + ". öğrencinin adı: ");
                isim[i] = Console.ReadLine();

                Console.Write((i + 1) + " sınav1: ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write((i + 1) + " sınav2: ");
                s2[i] = Convert.ToInt32(Console.ReadLine());
                ort[i] = ((s1[i] + s2[i]) / 2);
            }
            Console.WriteLine("öğrenci            sınav1          sınav2         ortalama");
            Console.WriteLine();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("   " + isim[i] + "  " + s1[i] + "    " + s2[i] + "     " + ort[i]);
            }
            Console.Read();

        }
    }
}
