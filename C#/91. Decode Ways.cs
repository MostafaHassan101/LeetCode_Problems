// 91. Decode Ways
public class Solution {
    public int NumDecodings(string s) {
        if(s == null || s.Length == 0) return 0;
        int n = s.Length;
        int[] dp = new int[n+1];
        dp[0] = 1;
        dp[1] = s[0] == '0' ? 0 : 1;
        for(int i = 2; i <= n; i++){
            int first = Convert.ToInt32(s.Substring(i-1,1));
            int second = Convert.ToInt32(s.Substring(i-2,2));
            if(first >= 1 && first <= 9){
                dp[i] += dp[i-1];
            }
            if(second >= 10 && second <= 26){
                dp[i] += dp[i-2];
            }
        }
        return dp[n];
    }
}