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
            int[] arr = new int[num1];

            for (int i = 0; i < num1; i++)
            {
                int k = rnd.Next(100);
                arr[i] = k;
            }

            Console.WriteLine("Tartiblanmagan massiv:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Array.Sort(arr); // Massivni o'sish tartibida saralab berish

            Console.WriteLine("\nTartiblangan massiv:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
