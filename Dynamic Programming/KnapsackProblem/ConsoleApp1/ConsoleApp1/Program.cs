using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 50;
            int n = 4;
            int[] wt = { 10, 40, 20, 30 };
            int[] val = { 60, 40, 100, 120 };

            int res_WithouDP = knapSackProblem(c, n, val, wt);
            int res_DP = knapSackProblem_DP(c, n, val, wt);
            double res_Greedy = knapSackProblem_Greedy(c, n, val, wt);

            Console.Write($"Without_DP: {res_WithouDP}\n");
            Console.Write($"With_DP: {res_DP}\n");
            Console.Write($"Greedy(Fractional KnapSack): {res_Greedy}\n");

            Console.ReadKey();
        }

        //Recursive approach but having overlapping subproblems T: O(2^n)
        private static int knapSackProblem(int c, int n, int[] v, int[] wt)
        {
            if (n == 0 || c == 0)
                return 0;

            if(wt[n-1] <= c)
                return Math.Max((v[n - 1] + knapSackProblem(c - wt[n - 1], n - 1, v, wt)),
                                (knapSackProblem(c, n - 1, v, wt)));

            return knapSackProblem(c, n - 1, v, wt);
        }

        //Bottom-up Approach using DP. T: O(nc) S:O(nc)
        private static int knapSackProblem_DP(int c, int n, int[] v, int[] wt)
        {
            //Build a table to store calculated values
            int[,] T = new int[n + 1, c + 1];

            for(int i = 0; i < n+1; ++i)
            {
                for(int w = 0; w < c+1; ++w)
                {
                    if (i == 0 || w == 0)
                        T[i, w] = 0;
                    else
                    {
                        if (wt[i - 1] <= w)
                            T[i, w] = Math.Max(v[i-1] + T[i -1, w - wt[i - 1]],
                                            T[i-1, w]);
                        else
                            T[i, w] = T[i - 1, w];
                    }
                }
            }

            return T[n, c];
        }

        //Fractional KnapSack Problem (items can be splitted) T:O(nLogn)
        private static double knapSackProblem_Greedy(int c, int n, int[] v, int[] wt)
        {
            Item[] arr = new Item[n];

            for (int i = 0; i < n; ++i)
                arr[i] = new Item(v[i], wt[i]);

            Array.Sort(arr, new Comparison<Item>((i1, i2) => (i2.ratio).CompareTo(i1.ratio)));

            int current_Weight = 0;
            double final_Value = 0.0;
            for(int i = 0; i < n; ++i)
            {
                if(current_Weight + arr[i].weight <= c)
                {
                    current_Weight += arr[i].weight;
                    final_Value += arr[i].value;
                }
                else
                {
                    int remaining = c - current_Weight;
                    final_Value += (arr[i].value) *  ((double)remaining / arr[i].weight);
                    break;
                }
            }

            return final_Value;
        }
        public struct Item
        {
            public int value;
            public int weight;
            public double ratio;

            public Item(int value, int weight)
            {
                this.value = value;
                this.weight = weight;
                ratio = value / weight;
            }
        }
    }
}
