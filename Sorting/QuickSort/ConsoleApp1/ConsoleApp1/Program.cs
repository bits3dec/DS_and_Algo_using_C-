using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 132, 11, 3, 89 };
            Console.WriteLine("Before sorting-");
            PrintArray(arr);

            SortingUtility.Sort(arr);
            Console.WriteLine("\nAfter sorting-");
            PrintArray(arr);

            Console.ReadKey();
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
        }
    }
}
