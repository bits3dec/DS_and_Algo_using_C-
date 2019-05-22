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
            int[] arr = { 1, 23, 12, 9, 30, 2, 50 };
            int k = 3;

            int res = HeapUtility.KthLargestElement(arr, k);
            Console.WriteLine($"The kth largest element is: {res}");

            Console.ReadKey();
        }
    }
}
