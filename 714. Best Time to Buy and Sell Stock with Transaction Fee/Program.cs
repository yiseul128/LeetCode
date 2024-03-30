public class Solution
{
    public int MaxProfit(int[] prices, int fee)
    {
        // buy => sell
        // buy => rest (might repeat resting)
        int[] bought = new int[prices.Length];
        bought[0] = -prices[0];

        // sell => buy
        // sell => rest (might repeat resting)
        int[] sold = new int[prices.Length];

        for (int i = 1; i < prices.Length; i++)
        {
            // rest || buy
            bought[i] = Math.Max(bought[i - 1], sold[i - 1] - prices[i]);

            // rest || sell 
            sold[i] = Math.Max(sold[i - 1], bought[i - 1] + prices[i] - fee);
        }

        return sold[prices.Length - 1];
    }
}