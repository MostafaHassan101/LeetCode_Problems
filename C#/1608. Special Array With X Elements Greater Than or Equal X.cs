// 1608. Special Array With X Elements Greater Than or Equal X

public class Solution {
    public int SpecialArray(int[] nums) {
        int n = nums.Length;
        for (int x = 0; x <= n; x++) {
            int count = 0;
            for (int i = 0; i < n; i++) {
                if (nums[i] >= x) {
                    count++;
                }
            }
            if (count == x) {
                return x;
            }
        }
        return -1;
    }
}