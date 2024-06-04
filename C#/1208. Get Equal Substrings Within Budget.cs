//1208. Get Equal Substrings Within Budget

public class Solution {
    public int EqualSubstring(string s, string t, int maxCost) {
        int n = s.Length;
        int[] cost = new int[n];
        for(int i = 0; i < n; i++){
            cost[i] = Math.Abs(s[i] - t[i]);
        }
        int start = 0;
        int end = 0;
        int sum = 0;
        int max = 0;
        while(end < n){
            sum += cost[end];
            while(sum > maxCost){
                sum -= cost[start];
                start++;
            }
            max = Math.Max(max, end - start + 1);
            end++;
        }
        return max;
    }
}