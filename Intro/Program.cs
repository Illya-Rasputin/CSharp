using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
         
        static void Main(string[] args) 
        {
            Console.WriteLine("Ex1: \r\nIt's easy to win forgiveness for being wrong;\r\nbeing right is what gets you into real trouble.\r\nBjarne Stroustrup");

            //Console.WriteLine("Ex2: ");
            //Console.WriteLine("Enter first number: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter third number: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter forth number: ");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter fifth number: ");
            //int f = Convert.ToInt32(Console.ReadLine());
            //int sum = a + b + c + d +f;
            //Console.WriteLine("Summ: " + sum);
            //int dob = a * b * c * b * d;
            //Console.WriteLine("Mulriplied: " + dob);
            //int temp = a;
            //if(a > b) 
            //{ 
            //    temp = b;
            //    if(b > c) { temp = c; if (c > d) { temp = d; if(d>f){ temp = f; } } }
            //}
            //Console.WriteLine("Min: " + temp);
            //temp = a;
            //if (a < b)
            //{
            //    temp = b;
            //    if (b < c) { temp = c; if (c < d) { temp = d; if (d < f) { temp = f; } } }
            //}
            //Console.WriteLine("Max: " + temp);

            //Console.WriteLine("Ex3: ");
            //Console.WriteLine("Enter 6-digit number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if(num> 999999) { Console.WriteLine("Too big. Try again:"); num = Convert.ToInt32(Console.ReadLine());}
            //else if (num < 100000) { Console.WriteLine("Too small. Try again:"); num = Convert.ToInt32(Console.ReadLine());}
            //if (num < 100000) { Console.WriteLine("Too small. Try again:"); num = Convert.ToInt32(Console.ReadLine()); }
            //else if (num > 999999) { Console.WriteLine("Too big. Try again:"); num = Convert.ToInt32(Console.ReadLine()); }
            //int a3 = num / 100000 % 10;
            //int b3 = num / 10000 % 10;
            //int c3 = num / 1000 % 10;
            //int d3 = num / 100 % 10;
            //int f3 = num / 10 % 10;
            //int e3 = num % 10;
            //Console.Write(e3);
            //Console.Write(f3);
            //Console.Write(d3);
            //Console.Write(c3);
            //Console.Write(b3);
            //Console.Write(a3);

            //Console.WriteLine();
            //Console.WriteLine("Ex4: ");
            //Console.WriteLine("Enter limit of Fibonacci number: ");
            //int a = 0, b = 1, limit = Convert.ToInt32(Console.ReadLine()), c;
            //Console.WriteLine($"Fibonacci number from 0 to {limit}");
            //Console.Write(a + " ");
            //while(b <= limit)
            //{
            //    Console.Write(b+" ");
            //    c = a + b;
            //    a=b; b=c;
            //}
            //Console.WriteLine();

            //Console.WriteLine("Ex5");
            //Console.WriteLine("enter start: ");
            //int A = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter finish: ");
            //int B = Convert.ToInt32(Console.ReadLine());
            //for(int i = A;  i <= B; i++)
            //{
            //    for(int j = 0; j < i; j++) { Console.Write(i); }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Ex6: ");
            Console.WriteLine("Enter length: ");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter filler: ");
            string fill = Console.ReadLine();
            Console.WriteLine("Enter axis of the line(x or y): ");
            string ax = Console.ReadLine();
            if (ax == "x")
            {
                for (int j = 0; j < len; j++) { Console.Write(fill); }
            }
            else if (ax == "y")
            {
                for (int j = 0; j < len; j++) { Console.WriteLine(fill); }
            }
            else { Console.WriteLine("Error!"); }
        }
    }
}
