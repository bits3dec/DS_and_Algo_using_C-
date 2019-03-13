using System;

namespace Median
{
    internal static class MedianUtil
    {
        public static double FindMedian(int[] arr1, int[] arr2)
        {
            if(arr1.Length > arr2.Length)
                return FindMedian(arr2, arr1);
                
            //arr1 is smaller than arr2
            int x = arr1.Length;
            int y = arr2.Length;

            int low = 0;
            int high = x;
            //do Binary search in smaller array arr1. Arr1 -> partition_X and arr2 -> partition_Y
            while(low <= high)
            {
                int partition_X = (low + high)/2;
                int partition_Y = (x + y + 1)/2 - partition_X;

                //if after partitioning the left half is empty then assume the leftMax as -INF;
                //if after partitioning the right half is empty then assume the rightMin as +INF;
                int leftMax_X = partition_X == 0 ? Int32.MinValue : arr1[partition_X - 1];
                int rightMin_X = partition_X == x ? Int32.MaxValue : arr1[partition_X];

                int leftMax_Y = partition_Y == 0 ? Int32.MinValue : arr2[partition_Y - 1];
                int rightMin_Y = partition_Y == y ? Int32.MaxValue : arr2[partition_Y];

                if(leftMax_X <= rightMin_Y && leftMax_Y <= rightMin_X)
                {
                    //found the correct partitioning for median
                    if((x + y) % 2 == 0)
                        return (double) (Math.Max(leftMax_X, leftMax_Y) + Math.Min(rightMin_X, rightMin_Y)) / 2;
                    else
                        return (double) Math.Max(leftMax_X, leftMax_Y);
                }

                if(leftMax_X > rightMin_Y)
                {
                    //we are doing partition too far on the right side of X. Move towards left
                    high = partition_X - 1;
                }

                if(leftMax_Y > rightMin_X)
                {
                    //we are doing partition too less on the right side of X. Move towards right 
                    low = partition_X + 1;
                }
            }
            return -1;
        }
    }

}