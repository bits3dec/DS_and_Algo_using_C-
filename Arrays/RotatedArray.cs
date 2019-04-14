public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        if(nums == null)
            return -1;
        
        int n = nums.Length;
        if(n == 0)
            return -1;
        
        int l = 0;
        int r = n-1;
        
        while(l < n-1 && r > 0)
        {
            int m = (l+r)/2;
            
            if(nums[l] == target)
                return l;
            if(nums[m] == target)
                return m;
            if(nums[r] == target)
                return r;
            
            if(nums[l] > target && target < nums[m])
            {
                r = m-1;
                continue;
            }
            if(nums[m] > target && target < nums[r])
            {
                l = m+1;
                continue;
            }
            if(nums[m] > nums[r])
            {
                l = m+1;
                continue;
            }
            if(nums[m] < nums[l])
            {
                r = m-1;
                continue;
            }
        }
        return -1;
    }
}