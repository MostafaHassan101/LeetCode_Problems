// 2149. Rearrange Array Elements by Sign
public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] res = new int[nums.Length];
        int i = 0, j = 1;
        foreach (var num in nums)
        {
            if (num > 0)
            {
                res[i] = num;
                i += 2;
            }
            else
            {
                res[j] = num;
                j += 2;
            }
        }
        return res;
    }
}