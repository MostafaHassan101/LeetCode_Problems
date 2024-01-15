// 26. Remove Duplicates from Sorted Array

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length, res = 0;
        if(n == 1) return 1;
        for(int i = 0; i < n-1; i++)
        {
            if(nums[i] != nums[i+1])
            {
                res++;
                nums[res] = nums[i+1];
            }
        }
        return res+1;
    }
}