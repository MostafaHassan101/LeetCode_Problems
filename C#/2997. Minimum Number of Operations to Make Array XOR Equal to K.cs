// 2997. Minimum Number of Operations to Make Array XOR Equal to K
public class Solution {
    public int MinOperations(int[] nums, int k) {
        int ans = 0;
        foreach (var x in nums) {
            ans = ans ^ x;
        }
        ans = ans ^ k;
        int res = 0;
        while (ans > 0) {
            if ((ans & 1) == 1)
                res++;
            ans = ans >> 1;
        }
        return res;
    }
}