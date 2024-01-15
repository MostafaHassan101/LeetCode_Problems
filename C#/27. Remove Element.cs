// 27. Remove Element

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int len = nums.Length, i = 0, cnt = 0;
        while(len != 0)
        {
            if(nums[i] != val)
            {
                nums[cnt] = nums[i];
                cnt ++;
            }
            len--;
            i++;
        }
        return cnt;
    }
}