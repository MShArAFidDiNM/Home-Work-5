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
            Console.Write("enter number : ");
            int num1=int.Parse(Console.ReadLine());
            for (int i = 1; i < num1*2; i+=2)
            {
                Console.Write($"{i}, ");
            }
            Main(args);
        }
    }
}
