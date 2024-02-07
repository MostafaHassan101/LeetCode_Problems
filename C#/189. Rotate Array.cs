// 189. Rotate Array
public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
}

public void Reverse(int[] nums, int start, int end) {
    while (start < end) {
        int temp = nums[start];
        nums[start] = nums[end];
        nums[end] = temp;
        start++;
        end--;
    }
}

// other solution

public class Solution {
    public void Rotate(int[] nums, int k) {
        var partition = k % nums.Length;
        Array.Reverse(nums, 0,nums.Length - partition);
        Array.Reverse(nums, nums.Length - partition, partition);
        Array.Reverse(nums, 0,nums.Length);
    }
}

