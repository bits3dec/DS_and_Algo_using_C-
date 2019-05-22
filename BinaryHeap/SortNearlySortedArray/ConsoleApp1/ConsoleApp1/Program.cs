using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 9, 8, 7, 4, 70, 60, 50 };
            int k = 4;

            BinaryHeapUtility.Sort(arr, k);

            Console.ReadKey();
        }
    }
}
