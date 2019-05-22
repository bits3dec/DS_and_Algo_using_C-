using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class HeapUtility
    {
        //T:O(n)
        public static void BuildHeap(BinaryHeap h, int[] arr, int n)
        {
            if (n > h.count)
                return;

            for (int i = 0; i < n; ++i)
                h.arr[i] = arr[i];

            //start with first non leaf node since all the leaf nodes will always satisfy heap property
            for (int i = (n - 2) / 2; i >= 0; --i)
                Heapify(h, i);
        }

        //T:O(log n)
        public static void Heapify(BinaryHeap heap, int i)
        {
            int max = i;
            int l = heap.GetLeftChildIndex(i);
            int r = heap.GetRightChildIndex(i);

            if (l != -1 && heap.arr[l] > heap.arr[max])
                max = l;
            if (r != -1 && heap.arr[r] > heap.arr[max])
                max = r;

            if(max != i)
            {
                //swap parent and child
                int temp = heap.arr[i];
                heap.arr[i] = heap.arr[max];
                heap.arr[max] = temp;

                Heapify(heap, max);
            }
        }

       
    }
}
