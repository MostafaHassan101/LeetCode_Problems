// 645. Set Mismatch
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] res = new int[2];
        int[] count = new int[nums.Length + 1];
        foreach (int num in nums) {
            count[num]++;
        }
        for (int i = 1; i < count.Length; i++) {
            if (count[i] == 2) {
                res[0] = i;
            }
            if (count[i] == 0) {
                res[1] = i;
            }
        }
        return res;
    }
}