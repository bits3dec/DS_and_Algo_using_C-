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
            int[] arr1 = { 8, 15, 3, 7 };
            int n = arr1.Length;
            Console.WriteLine("" + OptimalGameStrategy.MaximumValue(arr1));

            int[] arr2 = { 2, 2, 2, 2 };
            Console.WriteLine("" + OptimalGameStrategy.MaximumValue(arr2));

            int[] arr3 = { 20, 30, 2, 2, 2, 10 };
            Console.WriteLine("" + OptimalGameStrategy.MaximumValue(arr3));

            Console.ReadKey();
        }
    }
}
