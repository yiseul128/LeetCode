using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121.Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] prices = {7, 1, 5, 3, 6, 4};
            Console.WriteLine(s.MaxProfit(prices)); //5
        }
    }

    /* sol 1 */
    //public class Solution
    //{
    //    public int MaxProfit(int[] prices)
    //    { 
    //        int max = 0, min = 0;

    //        for (int i = 1; i < prices.Length; i++)
    //        {
    //            max = max > prices[i] - prices[min] ? max : prices[i] - prices[min];
    //            min = prices[min] < prices[i] ? min : i;
    //        }

    //        return max;

    //    }
    //}

    /* sol 2 */
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int[] maxMemo = new int[prices.Length];

            maxMemo[prices.Length - 1] = prices[prices.Length - 1];

            int maxProfit = 0;
            for (int idx = prices.Length - 2; idx >= 0; idx--)
            {
                maxMemo[idx] = maxMemo[idx + 1] > prices[idx] ? maxMemo[idx + 1] : prices[idx];
                int newMaxProfit = maxMemo[idx] - prices[idx];
                maxProfit = newMaxProfit > maxProfit ? newMaxProfit : maxProfit;
            }

            return maxProfit;
        }
    }
}
