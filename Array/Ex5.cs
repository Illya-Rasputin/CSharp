using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Ex5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗавдання 5");

            int[] arr = { 3, 8, 10, 13, 15, 18 };
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                    min = arr[i];

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] - min == 5 || min - arr[i] == 5)
                    count++;

            Console.WriteLine("Кількість елементів, що відрізняються від мінімального на 5: " + count);
        }
    }
}
