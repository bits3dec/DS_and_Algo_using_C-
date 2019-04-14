using System;
using System.Collections.Generic;

namespace _3Sum
{
    public class Solution 
    {
        public IList<IList<int>> ThreeSum(int[] nums) 
        {
            Array.Sort(nums);
            var res = new List<IList<int>>();
            int n = nums.Length;
        
            for(int i = 0; i < n-2; ++i)
            {
                if(i == 0 || nums[i] != nums[i-1])
                {
                    int low = i+1;
                    int high = n-1;
                    int sum = 0 - nums[i];
                
                    while(low < high)
                    {
                        int twoSum = nums[low] + nums[high];
                        if(twoSum == sum)
                        {
                            res.Add(new List<int>(){nums[low], nums[high]});
                        
                            while(nums[low] == nums[low+1]) low++;
                            while(nums[high] == nums[high-1]) high--;
                        }
                        else if(twoSum < sum)
                            low++;
                        else
                            high--;
                    }
                }
            }
        
        return res;
        }
    }
}
