using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MaximumRectangularSubMatrixWith1s
    {
        public static int GetMaxSubmatrixSize(int[,] M)
        {
            int rows = M.GetLength(0);
            int cols = M.GetLength(1);

            int[] T = new int[cols];

            for (int j = 0; j < cols; ++j)
                T[j] = M[0, j];

            int maxArea = GetMaxHistogramArea(T);

            for(int i = 1; i < rows; ++i)
            {
                for(int j = 0; j < cols; ++j)
                {
                    if (M[i, j] == 1)
                        T[j] = T[j] + 1;
                    else
                        T[j] = 0;
                }

                int area = GetMaxHistogramArea(T);

                if (area > maxArea)
                    maxArea = area;
            }

            return maxArea;
        }

        private static int GetMaxHistogramArea(int[] hist)
        {
            Stack<int> stack = new Stack<int>();

            int maxArea = Int32.MinValue;
            int n = hist.Length;

            int i = 0;
            while(i < n)
            {
                if (stack.Any() == false || hist[stack.Peek()] < hist[i])
                {
                    stack.Push(i);
                    ++i;
                }
                else
                {
                    int top = stack.Pop();
                    int area = 0;

                    if (stack.Any() == false)
                        area = hist[top] * i;
                    else
                        area = hist[top] * (i - stack.Peek() - 1);

                    if (area > maxArea)
                        maxArea = area;
                }
            }

            while(stack.Any() == true)
            {
                int top = stack.Pop();
                int area = 0;

                if (stack.Any() == false)
                    area = hist[top] * i;
                else
                    area = hist[top] * (i - stack.Peek() - 1);

                if (area > maxArea)
                    maxArea = area;
            }

            return maxArea;
        }
    }
}
