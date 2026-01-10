using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗавдання 2");

            int[] arr = { 2, 5, 8, 1, 9, 3, 6 };

            Console.Write("Введіть число: ");
            int k = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < k)
                    count++;
            }

            Console.WriteLine("Кількість елементів менших за " + k + ": " + count);
        }
    }
}
