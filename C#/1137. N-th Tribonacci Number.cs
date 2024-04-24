// 1137. N-th Tribonacci Number
public class Solution {
    public int Tribonacci(int n) {
        if(n == 0) return 0;
        if(n == 1 || n == 2) return 1;
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 1;
        for(int i = 3; i <= n; i++){
            dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
        }
        return dp[n];
    }
}

// other solution

public class Solution {
    public int Tribonacci(int n) {
        if(n == 0) return 0;
        if(n == 1 || n == 2) return 1;
        int a = 0, b = 1, c = 1;
        for(int i = 3; i <= n; i++){
            int sum = a + b + c;
            a = b;
            b = c;
            c = sum;
        }
        return c;
    }
}

// other solution by recursion

public class Solution {
    private Dictionary<int, int> memo = new Dictionary<int, int>();
    
    public int Tribonacci(int n) {
        if(n == 0) return 0;
        if(n == 1 || n == 2) return 1;
        
        if(memo.ContainsKey(n)) return memo[n];
        
        int result = Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
        memo[n] = result;
        return result;
    }
}
