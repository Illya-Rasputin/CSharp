using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHW
{
    partial class Worker
    {
        private string fullName;
        private int age;
        private decimal salary;
        private DateTime hireDate;

        public string FullName
        {
            get => fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Full name cant be null.");
                fullName = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value <= 15 || value > 90)
                    throw new ArgumentException("Age must range from 16 to 90.");
                age = value;
            }
        }
        public decimal Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cant have negative value.");
                salary = value;
            }
        }
        public DateTime HireDate
        {
            get => hireDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Date of hire cant be in the future dates.");
                hireDate = value;
            }
        }
        public int GetWorkExperience()
        {
            return DateTime.Now.Year - HireDate.Year -
                   (DateTime.Now.DayOfYear < HireDate.DayOfYear ? 1 : 0);
        }
    }

    partial class Calc
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cant divide by zero.");
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Worker[] workers = new Worker[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            Console.WriteLine($"\nEntering data on worker №{i + 1}");

            //            Worker w = new Worker();

            //            Console.Write("Last name and initials: ");
            //            w.FullName = Console.ReadLine();

            //            Console.Write("Age: ");
            //            w.Age = int.Parse(Console.ReadLine());

            //            Console.Write("Salary: ");
            //            w.Salary = decimal.Parse(Console.ReadLine());

            //            Console.Write("Hire date (yyyy-mm-dd): ");
            //            w.HireDate = DateTime.Parse(Console.ReadLine());

            //            workers[i] = w;
            //            break;
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Error: " + ex.Message);
            //            Console.WriteLine("Try again.");
            //        }
            //    }
            //}
            //workers = workers.OrderBy(w => w.FullName).ToArray();

            //Console.Write("\nEnter minimal work experience (in years): ");
            //int minExperience = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nWorkers with more experience than requested:");

            //bool found = false;
            //foreach (var worker in workers)
            //{
            //    if (worker.GetWorkExperience() > minExperience)
            //    {
            //        Console.WriteLine(worker.FullName);
            //        found = true;
            //    }
            //}

            //if (!found)
            //    Console.WriteLine("Workers not found.");
            Calc calc = new Calc();
            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"a + b = {calc.Add(a, b)}");
                    Console.WriteLine($"a - b = {calc.Subtract(a, b)}");
                    Console.WriteLine($"a * b = {calc.Multiply(a, b)}");
                    Console.WriteLine($"a / b = {calc.Divide(a, b)}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Try again.");
                }
            }
        }
    }
}
