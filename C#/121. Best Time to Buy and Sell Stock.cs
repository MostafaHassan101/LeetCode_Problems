
// 121. Best Time to Buy and Sell Stock
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length < 2) return 0;
        int maxProfit = 0, minStock = prices[0];

        for(int i = 1; i < prices.Length; i++)
        {
            int currentPrice = prices[i];
            if(currentPrice > minStock)
            {
                int currentProfit = currentPrice - minStock;
                maxProfit = Math.Max(maxProfit, currentProfit);
            }
            else
                minStock = currentPrice;
        }
        return maxProfit;
    }
}