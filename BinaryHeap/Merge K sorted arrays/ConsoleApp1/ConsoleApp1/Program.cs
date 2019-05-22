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
            int k = 3;
            int[][] arr = new int[3][] {new int[] { 2, 6, 12 },
                                       new int[] { 1, 9 },
                                       new int[] { 23, 34, 90, 2000 } };

            MergeUtility.MergeKSortedArrays(arr, k);

            Console.ReadKey();
        }
    }
}
