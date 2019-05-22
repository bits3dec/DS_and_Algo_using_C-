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
            int[] arr = { 3, 1, 1, 2, 2, 1 };
            int n = arr.Length;
            Partition obj = new Partition();

            if (obj.CheckPartitionExists(arr) == true)
                Console.Write($"The array can be divided into two subsets of equal sum.");
            else
                Console.Write($"The array cannot be divided into two subsets of equal sum.");

            Console.ReadKey();
        }
    }
}
