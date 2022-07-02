using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _322.Coin_Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] c = { 3, 2, 9 };
            int a = 12;
            Console.WriteLine(solution.CoinChange(c, a));
        }
    }

    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            const int INT_MAX = 2147483646;

            Array.Sort(coins);

            if (amount == 0)
            {
                return 0;
            }

            int rn = coins.Length + 1; //row for coins
            int cn = amount + 1; //col for amounts

            int[,] dp = new int[rn, cn];

            //init
            for (int r = 0; r < rn; r++)
            {
                for (int c = 0; c < cn; c++)
                {
                    dp[r, c] = INT_MAX;
                }
            }

            //for amount = 0 
            for (int i = 0; i < rn; i++)
            {
                dp[i, 0] = 0;
            }

            for (int r = 1; r < rn; r++)
            {
                for (int c = 1; c < cn; c++)
                {

                    //that coin is less than amount
                    if (c < coins[r - 1])
                    {
                        dp[r, c] = dp[r - 1, c]; //use the result one row above
                    }
                    //
                    else
                    {
                        int used = 1 + dp[r, c - coins[r - 1]]; // 1 + same coins with amount - this coin
                        int not = dp[r - 1, c];

                        dp[r, c] = used < not ? used : not;
                    }
                }
            }

            if (dp[rn - 1, cn - 1] == INT_MAX)
            {
                return -1;
            }
            return dp[rn - 1, cn - 1];
        }

    }
}
