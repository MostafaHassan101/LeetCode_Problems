// 80. Remove Duplicates from Sorted Array II

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length < 3) return nums.Length;
        int i = 0;
        for (int j = 2; j < nums.Length; j++) {
            if (nums[j] != nums[i]) {
                nums[i + 2] = nums[j];
                i++;
            }
        }
        return i + 2;
    }
}