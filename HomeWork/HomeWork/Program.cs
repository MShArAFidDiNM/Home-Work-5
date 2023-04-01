using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Massiv uzunligini kiriting : ");
            int num1 = int.Parse(Console.ReadLine());
            int[] array = new int[num1];

            for (int i = 0; i < num1; i++)
            {
                int k = rnd.Next(100);
                Console.Write($"{k}, ");
                array[i] = k;
            }

            Console.Write("K :");
            int karrali = int.Parse(Console.ReadLine());

            int g = 0;

            for(int i = 0; i < num1; i++)
            {
                if (array[i] % karrali == 0)
                {
                    g++;
                    Console.WriteLine($"Javob : {array[i]}");
                }
            }
            if (g == 0)
            {
                Console.WriteLine("Natija aniqlanmadi qaytadan urinib ko'ring ");
            }
            Main(args);
        }
    }
}
