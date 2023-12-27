// 1578. Minimum Time to Make Rope Colorful

public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int MinCost = 0;
        int len = colors.Length;
        for(int i = 1; i < len; i++){
            if(colors[i - 1 ] == colors[i]){
                int min = Math.Min(neededTime[i], neededTime[i-1]);
                    MinCost += min;

                if(min == neededTime[i])
                    neededTime[i] = neededTime[i-1];
            }
        }
        return MinCost;
    }
}

// other solution
public class Solution
{
    public int MinCost(string s, int[] cost)
    {
        int res = 0;
        int max = 0;
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i > 0 && s[i] != s[i - 1])
            {
                res += sum - max;
                sum = max = 0;
            }
            sum += cost[i];
            max = Math.Max(max, cost[i]);
        }
        res += sum - max;
        return res;
    }
}