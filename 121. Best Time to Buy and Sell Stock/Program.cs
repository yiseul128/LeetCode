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
    public class Solution
    {
        public int MaxProfit(int[] prices)
        { 
            int max = 0, min = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                max = max > prices[i] - prices[min] ? max : prices[i] - prices[min];
                min = prices[min] < prices[i] ? min : i;
            }

            return max;

        }
    }
}
