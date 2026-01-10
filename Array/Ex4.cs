using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗавдання 4");

            int[,] arr = new int[5, 5];
            Random rnd = new Random();

            int min = 101, max = -101;
            int minPos = 0, maxPos = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(-100, 101);
                    Console.Write($"{arr[i, j],4}");

                    int pos = i * 5 + j;
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minPos = pos;
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxPos = pos;
                    }
                }
                Console.WriteLine();
            }

            int start = minPos < maxPos ? minPos : maxPos;
            int end = minPos > maxPos ? minPos : maxPos;

            int sum = 0;
            for (int i = start + 1; i < end; i++)
                sum += arr[i / 5, i % 5];

            Console.WriteLine("Сума між мінімальним і максимальним: " + sum);
        }
    }
}
