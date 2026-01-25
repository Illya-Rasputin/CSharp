using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex7");
            string mess = "I like C# programming!";
            string[] words = mess.Split(new char[] { ' ', '.', '-', '?', '!' },
               StringSplitOptions.RemoveEmptyEntries);
            char fletter = words[1][0];
            Console.WriteLine(fletter);
            Console.WriteLine("Ex6");
            foreach(var word in words) { Console.Write("*" + word + "*"); }
            Console.WriteLine("Ex7");
            StringBuilder sb = new StringBuilder();
            string word2;

            Console.Write("Enter the word (place fullstop to stop the sentence): ");
            do
            {
                word2 = Console.ReadLine();
                sb.Append(word2 + ", ");
            }
            while (!word2.Contains("."));
            sb.Length -= 2;
            Console.WriteLine(sb);
        }
    }
}
