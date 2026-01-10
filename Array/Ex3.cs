using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗавдання 3");

            double[] A = new double[5];
            double[,] B = new double[3, 4];
            Random rnd = new Random();

            Console.WriteLine("Введіть 5 елементів масиву A:");
            for (int i = 0; i < 5; i++)
                A[i] = double.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    B[i, j] = rnd.NextDouble() * 20 - 10;

            Console.WriteLine("\nМасив A:");
            for (int i = 0; i < 5; i++)
                Console.Write(A[i] + " ");

            Console.WriteLine("\n\nМасив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{B[i, j]:F2}\t");
                Console.WriteLine();
            }

            double max = A[0], min = A[0];
            double sum = 0, product = 1;

            for (int i = 0; i < 5; i++)
            {
                sum += A[i];
                product *= A[i];
                if (A[i] > max) max = A[i];
                if (A[i] < min) min = A[i];
            }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    double x = B[i, j];
                    sum += x;
                    product *= x;
                    if (x > max) max = x;
                    if (x < min) min = x;
                }

            double sumEvenA = 0;
            for (int i = 0; i < 5; i++)
                if ((int)A[i] % 2 == 0)
                    sumEvenA += A[i];

            double sumOddColumnsB = 0;
            for (int j = 0; j < 4; j++)
                if (j % 2 != 0)
                    for (int i = 0; i < 3; i++)
                        sumOddColumnsB += B[i, j];

            Console.WriteLine("\nМаксимум: " + max);
            Console.WriteLine("Мінімум: " + min);
            Console.WriteLine("Сума всіх елементів: " + sum);
            Console.WriteLine("Добуток всіх елементів: " + product);
            Console.WriteLine("Сума парних A: " + sumEvenA);
            Console.WriteLine("Сума непарних стовпців B: " + sumOddColumnsB);
        }
    }
}
