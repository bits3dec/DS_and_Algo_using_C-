using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinaryHeapUtility
    {
        public static bool CheckBinaryHeap(int[] arr, int i, int n)
        {
            if (i > ((n - 2) / 2)) //for all leaf nodes the heap property always satisfies
                return true;

            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if(l < n && r < n) //Check for both left and right child since both exist
            {
                if (arr[i] > arr[l] && arr[i] > arr[r] &&
                                CheckBinaryHeap(arr, l, n) && CheckBinaryHeap(arr, r, n))
                    return true;
            }
            else //check for only left child since only left child exists
            {
                if (arr[i] > arr[l] && CheckBinaryHeap(arr, l, n)) 
                    return true;
            }

            return false;
        }
    }
}
