using System;
using System.Collections.Generic;

public class MaximumHistogramArea
{
    public static int GetMaxArea(int[] hist)
    {
        Stack<int> stack = new Stack<int>();

        int maxArea = Int32.MinValue;

        int n = hist.Length;

        int i = 0;
        for(i = 0; i < n; )
        {
            if(stack.Count == 0 || hist[stack.Peek()] < hist[i])
            {
                stack.Push(i++);
            }
            else
            {
                int area = 0;
                int top = stack.Pop();
                if (stack.Count == 0)
                    area = hist[top] * i;
                else
                    area = hist[top] * (i - stack.Peek() - 1);

                if (area > maxArea)
                    maxArea = area;
            }
        }
        while(stack.Count > 0)
        {
            int area = 0;
            int top = stack.Pop();
            if (stack.Count == 0)
                area = hist[top] * i;
            else
                area = hist[top] * (i - stack.Peek() - 1);

            if (area > maxArea)
                maxArea = area;
        }

        return maxArea;
    }
}
