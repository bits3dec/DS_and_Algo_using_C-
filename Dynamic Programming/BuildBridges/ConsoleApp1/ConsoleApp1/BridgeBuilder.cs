using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BridgeBuilder
    {
        public int MaxBridge(CityPair[] cityPairs)
        {
            int n = cityPairs.Length;

            //Sort the city pairs based on the southern city
            SortBasedOnSouth(cityPairs);

            //Apply LIS on the Norther city to get the maximum bridge possile
            //LIS[j] denotes the longest subsequence starting from arr[0] with the last element as arr[j]
            int[] LIS = new int[n];

            for (int i = 0; i < n; ++i)
                LIS[i] = 1;

            for(int j = 1; j < n; ++j)
            {
                for(int i = 0; i < j; ++i)
                {
                    if (cityPairs[i].x_North <= cityPairs[j].x_North && 1 + LIS[i] > LIS[j])
                        LIS[j] = 1 + LIS[i];
                }
            }

            int maxBridge = FindMax(LIS);

            return maxBridge;
        }

        //Sort the city pairs based on the souther point. If the souther points are same then sort based on the northern points
        private void SortBasedOnSouth(CityPair[] cityPairs)
        {
            //Array.Sort(cityPairs, new Comparison<CityPair>
            //                        ((a, b) => 
            //                             a.x_South.CompareTo(b.x_South)
            //                        ));

            Array.Sort(cityPairs, 0, cityPairs.Length, new MyCityPairComparer());
        }

        private int FindMax(int[] arr)
        {
            int max = Int32.MinValue;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }
    }
}
