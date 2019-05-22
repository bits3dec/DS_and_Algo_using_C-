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
            int[] arr = { 90, 15, 10, 7, 12, 2, 7, 3 };

            bool res = BinaryHeapUtility.CheckBinaryHeap(arr, 0, arr.Length);//MaxHeap

            if(res == true)
                Console.WriteLine("It is a binary heap i.e. Max Heap");
            else
                Console.WriteLine("It is not a binary heap");

            Console.ReadKey();
        }
    }
}
