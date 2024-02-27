// 45. Jump Game II
public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        int maxPos = 0;
        int end = 0;
        int steps = 0;
        for (int i = 0; i < n - 1; i++) {
            maxPos = Math.Max(maxPos, i + nums[i]);
            if (i == end) {
                end = maxPos;
                steps++;
            }
        }
        return steps;
    }
}

// other solutions
public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        for (int i = 0; i < n; i++) {
            dp[i] = int.MaxValue;
        }
        dp[0] = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 1; j <= nums[i]; j++) {
                if (i + j < n) {
                    dp[i + j] = Math.Min(dp[i + j], dp[i] + 1);
                }
            }
        }
        return dp[n - 1];
    }
}
