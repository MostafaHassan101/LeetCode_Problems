// 1239. Maximum Length of a Concatenated String with Unique Characters
public class Solution {
    public int MaxLength(IList<string> arr) {
        var dp = new List<int>();
        dp.Add(0);
        int res = 0;
        foreach (var s in arr) {
            int a = 0, dup = 0;
            foreach (var c in s) {
                dup |= a & (1 << (c - 'a'));
                a |= 1 << (c - 'a');
            }
            if (dup > 0) continue;
            for (int i = dp.Count - 1; i >= 0; --i) {
                if ((dp[i] & a) > 0) continue;
                dp.Add(dp[i] | a);
                res = Math.Max(res, BitCount(dp[i] | a));
            }
        }
        return res;
    }
    private int BitCount(int n) {
        int res = 0;
        while (n > 0) {
            n &= n - 1;
            ++res;
        }
        return res;
    }
}