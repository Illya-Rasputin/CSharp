using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗавдання 1");

            int[] arr = { 1, 2, 3, 4, 4, 5, 6, 6, 7 };

            int even = 0, odd = 0, unique = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                    unique++;
            }

            Console.WriteLine("Парних: " + even);
            Console.WriteLine("Непарних: " + odd);
            Console.WriteLine("Унікальних: " + unique);
        }
    }
}
