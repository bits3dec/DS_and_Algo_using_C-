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
            BinaryHeap heap = new BinaryHeap(7);
            heap.InsertKey(17);
            heap.InsertKey(15);
            heap.InsertKey(6);
            heap.InsertKey(1);
            heap.InsertKey(4);
            heap.InsertKey(2);
            heap.InsertKey(5);
            Print(heap.arr);
            Console.WriteLine("The maximum element is: "+ heap.GetMaximum());
            int index = 2;
            int newValue = 3;
            Console.WriteLine($"Decreasing element at {index} with key: {newValue}");
            heap.DecreaseKey(index, newValue);
            Print(heap.arr);

            Console.WriteLine("Heap Sort: ");
            int[] arr = { 3, 4, 16, 10, 2 };
            HeapSort.Sort(arr);
            Print(arr);

            Console.ReadKey();
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
