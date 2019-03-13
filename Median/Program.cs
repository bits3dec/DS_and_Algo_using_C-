using System;

namespace Median
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {2, 4, 6, 10};
            int[] array2 = {3, 9};

            double median = MedianUtil.FindMedian(array1, array2);
            System.Console.WriteLine("The median of the two sorted arrays of different sizes is: " + median);
        }
    }
}
