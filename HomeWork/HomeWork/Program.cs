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

            Console.WriteLine();

            int sum = 0;
            int kopaytma = 1;

            for (int i = 0;i < num1; i++)
            {
                sum += array[i];
                kopaytma *= array[i];
            }

            Console.WriteLine($"Yig'indi {sum}, Ko'paytma {kopaytma}");
            Console.WriteLine();

            Main(args);
        }
    }
}
