class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(s.MaxProfit(prices)); //5
    }
}

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int[] memoMax = new int[prices.Length];
        int[] memoGap = new int[prices.Length];
        return RecurMaxProfit(prices, 0, 0, -1, memoMax, memoGap);
    }

    public int RecurMaxProfit(int[] prices, int idx, int sum, int boughtIdx, int[] memoMax, int[] memoGap)
    {
        if (idx >= prices.Length)
        {
            return sum;
        }

        //buy
        int max = sum;
        if (boughtIdx == -1)
        {
            if (memoMax[idx] > 0)
            {
                return sum + memoMax[idx];
            }

            for (int i = idx; i < prices.Length; i++)
            {
                int newMax = RecurMaxProfit(prices, i + 1, sum - prices[i], i, memoMax, memoGap);
                max = max > newMax ? max : newMax;
            }

            if (memoMax[idx] == 0)
            {
                memoMax[idx] = max - sum;
            }
        }
        //sell
        else
        {
            // no next bigger price to sell at
            if (memoGap[boughtIdx] == -1)
            {
                return max;
            }

            int idxWithGap = -1;
            for (int i = idx; i < prices.Length; i++)
            {
                int gap = prices[i] - prices[boughtIdx];
                if (gap > 0)
                {
                    int newMax = RecurMaxProfit(prices, i + 1, sum + prices[i], -1, memoMax, memoGap);
                    idxWithGap = i;
                    max = max > newMax ? max : newMax;
                }
            }

            if (idxWithGap == -1)
            {
                memoGap[boughtIdx] = -1;
            }
            else
            {
                memoGap[boughtIdx] = idxWithGap;
            }

        }

        return max;
    }
}