using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public interface IOutput
    {
        void Show();
        void Show(string message);
    }
    

    public interface IMath
    {
        int Max();
        int Min(); 
        float Ave();
        bool Search(int value);
    }

    public interface ISort
    {
        void SordAsc();
        void SordDesc();
        void SortByParam(bool isAsc);
    }

    class Array : IOutput, IMath, ISort
    {
        private int[] arr;

        public Array(int[] array)
        {
            arr = array;
        }


        public void Show()
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        public void Show(string info)
        {
            Console.WriteLine(info);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public int Max()
        {
            return arr.Max();
        }
        public int Min()
        {
            return arr.Min();
        }
        public float Ave()
        {
            return (float)arr.Average();
        }
        public bool Search(int value)
        {
            return arr.Contains(value);
        }
        public void SordAsc()
        {
            System.Array.Sort(arr);
        }

        
        public void SordDesc()
        {
            System.Array.Sort(arr);
            System.Array.Reverse(arr);
        }

        
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SordAsc();
            else
                SordDesc();
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 2, 4, 5 };

            Array array = new Array(numbers); 
            array.Show();
            array.Show("Massives elements:");

            Console.WriteLine("Maximum: " + array.Max());
            Console.WriteLine("Minimal: " + array.Min());
            Console.WriteLine("Average: " + array.Ave());
            int searchValue = 6;
            Console.WriteLine($"Does massive contain {searchValue}? " + (array.Search(searchValue) ? "Yes" : "No"));

            array.SordAsc();
            Console.WriteLine("Sorted Ascending:");
            array.Show();

            array.SordDesc();
            Console.WriteLine("Sorted Descending:");
            array.Show();

            bool IsAsc = true;
            array.SortByParam(IsAsc);
            Console.WriteLine("Sorted by parameter (Ascending):");
            array.Show();

            IsAsc = false;
            array.SortByParam(IsAsc);
            Console.WriteLine("Sorted by parameter (Descending):");
            array.Show();
        }
    }
}
