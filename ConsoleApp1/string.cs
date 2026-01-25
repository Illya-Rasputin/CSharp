using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex5");
            string text = "i like programming on sharp";
            string[] words = text.Split(new char[] { ' ', '.', '-', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            char letter = words[1][0];
            Console.WriteLine(letter);

            Console.WriteLine("Ex6");
            foreach(var word in words)
            { Console.Write(word + "*"); }

            Console.WriteLine();
            Console.WriteLine("Ex7");
            StringBuilder sb = new StringBuilder();
            string word2;
            Console.Write("Enter the word(place fullstop to stop the sentence): ");
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
