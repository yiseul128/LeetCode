public class Solution
{
    public int MaxProfit(int[] prices)
    {
        // rest => rest
        // rest => buy
        int[] cooled = new int[prices.Length];

        // buy => rest
        // buy => sell
        int[] bought = new int[prices.Length];
        bought[0] = -prices[0];

        // sell => rest
        int[] sold = new int[prices.Length];

        for (int i = 1; i < prices.Length; i++)
        {
            // resting once more || resting after selling
            cooled[i] = Math.Max(cooled[i - 1], sold[i - 1]);

            // buying after resting || resting after buying
            bought[i] = Math.Max(cooled[i - 1] - prices[i], bought[i - 1]);

            // selling 
            sold[i] = bought[i - 1] + prices[i];
        }

        return Math.Max(cooled[prices.Length - 1], sold[prices.Length - 1]);
    }
}