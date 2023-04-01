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
                int h = rnd.Next(100);
                Console.Write($"{h}, ");
                array[i] = h;
            }

            Console.WriteLine();

            Console.Write("K : ");
            int k = int .Parse(Console.ReadLine()); 
            Console.Write("L : ");
            int L = int .Parse(Console.ReadLine()); 

            for (int i = 0;i < num1; i++)
            {
                if (i == k)
                {
                    Console.Write($"{array[L]}, ");
                    continue;
                }
                if (i == L)
                {
                    Console.Write($"{array[k]}, ");
                }
                else
                {
                    Console.Write($"{array[i]}, ");
                }
            }

            Console.WriteLine();

            Main(args);
        }
    }
}
