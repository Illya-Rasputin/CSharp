using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegals
{
    class Utility
    {
        public static void ShowTime()
        {
            Console.WriteLine("Час: " + DateTime.Now.ToLongTimeString());
        }

        public static void ShowDate()
        {
            Console.WriteLine("Дата: " + DateTime.Now.ToShortDateString());
        }

        public static void ShowDayOfWeek()
        {
            Console.WriteLine("День тижня: " + DateTime.Now.DayOfWeek);
        }

        public static double TriangleArea(double a, double h)
        {
            return 0.5 * a * h;
        }

        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }
    }

    class ArrayProcessor
    {
        
        public static int[] FilterArray(int[] array, Predicate<int> condition)
        {
            return Array.FindAll(array, condition);
        }

        
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;
            return true;
        }

        
        public static bool IsFibonacci(int number)
        {
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return number == b || number == 0;
        }
    }

    delegate (int, int, int) RainbowColor(string color);
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 8, 13, 21, 22, 34 };

            //Ex 1
            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;
            Predicate<int> isPrime = ArrayProcessor.IsPrime;
            Predicate<int> isFibonacci = ArrayProcessor.IsFibonacci;

            var evenNumbers = ArrayProcessor.FilterArray(array, isEven);
            var oddNumbers = ArrayProcessor.FilterArray(array, isOdd);
            var primeNumbers = ArrayProcessor.FilterArray(array, isPrime);
            var fibNumbers = ArrayProcessor.FilterArray(array, isFibonacci);

            Console.WriteLine("Парні: " + string.Join(", ", evenNumbers));
            Console.WriteLine("Непарні: " + string.Join(", ", oddNumbers));
            Console.WriteLine("Прості: " + string.Join(", ", primeNumbers));
            Console.WriteLine("Фібоначчі: " + string.Join(", ", fibNumbers));


            //Ex 2
            Action showTime = Utility.ShowTime;
            Action showDate = Utility.ShowDate;
            Action showDay = Utility.ShowDayOfWeek;

            showTime();
            showDate();
            showDay();

            
            Func<double, double, double> triangleArea = Utility.TriangleArea;
            Func<double, double, double> rectangleArea = Utility.RectangleArea;

            Console.WriteLine("Площа трикутника: " + triangleArea(10, 5));
            Console.WriteLine("Площа прямокутника: " + rectangleArea(4, 6));

            //Ex 3
            RainbowColor getRGB = delegate (string color)
            {
                switch (color.ToLower())
                {
                    case "червоний": return (255, 0, 0);
                    case "помаранчевий": return (255, 165, 0);
                    case "жовтий": return (255, 255, 0);
                    case "зелений": return (0, 128, 0);
                    case "блакитний": return (0, 255, 255);
                    case "синій": return (0, 0, 255);
                    case "фіолетовий": return (128, 0, 128);
                    default: return (0, 0, 0);
                }
            };

            
            var rgb = getRGB("синій");
            Console.WriteLine($"RGB: {rgb.Item1}, {rgb.Item2}, {rgb.Item3}");

            //Ex 4
            int[] numbers = { -10, -5, 0, 5, 10, 15, 20 };

            
            Func<int[], int, int, int> countInRange = (arr, min, max) =>
                arr.Count(x => x >= min && x <= max);

            
            Console.WriteLine("0..10: " + countInRange(numbers, 0, 10));
            Console.WriteLine("-10..0: " + countInRange(numbers, -10, 0));
            Console.WriteLine("10..20: " + countInRange(numbers, 10, 20));

            //ex 5
            string text = "Привіт світ привіт всім привіт";
            string word = "привіт";

            
            Func<string, string, int> countWord = (t, w) =>
                t.ToLower()
                 .Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                 .Count(x => x == w.ToLower());

            
            Func<string, string, bool> containsWord = (t, w) =>
                t.ToLower().Contains(w.ToLower());

            
            Console.WriteLine("Є слово: " + containsWord(text, word));
            Console.WriteLine("Кількість входжень: " + countWord(text, word));
        }
    }
}
