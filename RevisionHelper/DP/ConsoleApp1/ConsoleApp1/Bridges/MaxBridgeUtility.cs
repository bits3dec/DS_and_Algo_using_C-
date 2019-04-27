using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bridges
{
    public class MaxBridgeUtility
    {
        public static void MaxBridge(CityPair[] cityPairs)
        {
            int n = cityPairs.Length;

            //Sort the city pairs based on the southern points
            //If the southern points are same then sort based on northern points
            Array.Sort(cityPairs, 0, n, new MyCityComparer());

            //Apply LIS on the norther points of the city to get the maximum bridges possible
            //LIS[j] denotes the maximum bridges possible with cityPairs[j] at top such that no two bridge cross each other
            int[] LIS = new int[n];

            for (int i = 0; i < n; ++i)
                LIS[i] = 1;

            for(int j = 1; j < n; ++j)
            {
                for(int i = 0; i < j; ++i)
                {
                    if (cityPairs[i].x_North <= cityPairs[j].x_North
                       && LIS[i] + 1 > LIS[j])
                        LIS[j] = LIS[i] + 1;
                }
            }

            int res = FindMax(LIS);

            Console.WriteLine($"The maximum bridges that can be built is: {res}");
        }

        private static int FindMax(int[] arr)
        {
            int max = Int32.MinValue;

            for (int i = 0; i < arr.Length; ++i)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }
    }
}
