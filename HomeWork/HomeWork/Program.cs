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

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"Yig'indi : {sum}");
                    break;
                }
                else
                {
                    sum += array[i];
                }
                if (num1-1 == i)
                {
                    int yigindi = 0;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (j != 0 && array[num1 - 1] != j)
                        {
                            yigindi += array[j];
                        }
                    }
                    Console.WriteLine($"Yig'indi : {yigindi}");
                }
            }           

            Main(args);               
        }
    }
}
