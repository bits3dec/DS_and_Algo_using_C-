using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //MaxHeap
    public class BinaryHeap
    {
        public int count;
        public int[] arr;
        public int capacity;

        public BinaryHeap(int capacity)
        {
            this.capacity = capacity;
            arr = new int[capacity];
        }

        public int GetParentIndex(int i)
        {
            if (i <= 0)
                return -1;

            return (i - 1) / 2;
        }

        public int GetLeftChildIndex(int i)
        {
            int l = 2 * i + 1;

            if (l < count)
                return l;

            return -1;
        }

        public int GetRightChildIndex(int i)
        {
            int r = 2 * i + 2;

            if (r < count)
                return r;

            return -1;
        }

        //T:O(1)
        public int GetMaximum()
        {
            if (count == 0)
                return -1;

            return arr[0];
        }

        //Percolate down (Top-down approach) T:O(log n)
        public void Heapify(int i)
        {
            int max = i;
            int l = GetLeftChildIndex(i);
            int r = GetRightChildIndex(i);

            if (l != -1 && arr[l] > arr[max])
                max = l;
            if (r != -1 && arr[r] > max)
                max = r;

            if(max != i)
            {
                //swap parent and child(top-down)
                Swap(ref arr[i], ref arr[max]);

                Heapify(max);
            }
        }

        //T:O(log n)
        public int DeleteMax()
        {
            if (count == 0)
                return -1;

            int max = arr[0];

            arr[0] = arr[count - 1];
            --count;
            Heapify(0);

            return max;
        }

        //T:O(log n)
        public void InsertKey(int data)
        {
            if (count == capacity)
                return;

            ++count;
            int i = count - 1;
            arr[i] = data;

            //Percolate up(Bottom-up approach)
            while(i > 0 && arr[i] > arr[GetParentIndex(i)])
            {
                //swap child and parent(bottom-up)
                Swap(ref arr[i], ref arr[GetParentIndex(i)]);

                i = GetParentIndex(i);
            }
        }

        //Decrease the key at index "i". The new value is assumed to be smaller in DecreaseKey
        public void DecreaseKey(int i, int newValue)
        {
            if (i < 0 || i >= count)
                return;

            arr[i] = newValue;
            Heapify(i);
        }

        //Delete the key at index "i"
        public void DeleteAt(int i)
        {
            if (i < 0 || i >= count)
                return;

            arr[i] = int.MaxValue;

            while(i > 0 && arr[i] > arr[GetParentIndex(i)])
            {
                Swap(ref arr[i], ref arr[GetParentIndex(i)]);
                i = GetParentIndex(i);
            }

            DeleteMax();
        }

        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
