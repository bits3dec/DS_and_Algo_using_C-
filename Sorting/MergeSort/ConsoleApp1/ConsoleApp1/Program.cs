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
            int[] arr = { 23, 11, 345, 34, 100 };
            Console.WriteLine("Before sorting-");
            PrintArray(arr);

            SortingUtility.MergeSort(arr);
            Console.WriteLine("\nAfter Sorting-");
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
