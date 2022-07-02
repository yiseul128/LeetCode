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
            Console.WriteLine(solution.CoinChange(c, a)); //2
        }
    }
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            const int INT_MAX = 100000;

            //Array.Sort(coins);

            if (amount == 0)
            {
                return 0;
            }

            int rn = coins.Length + 1; //row for coins
            int cn = amount + 1; //col for amounts

            int[] dp = new int[cn];

            //init
            for (int c = 1; c < cn; c++)
            {
                dp[c] = INT_MAX;
            }

            for (int r = 1; r < rn; r++)
            {
                for (int c = 1; c < cn; c++)
                {

                    if (c >= coins[r - 1])
                    {
                        int used = 1 + dp[c - coins[r - 1]];
                        int not = dp[c];

                        dp[c] = used < not ? used : not;
                    }

                }
            }

            if (dp[cn - 1] == INT_MAX)
            {
                return -1;
            }
            return dp[cn - 1];
        }

    }
}
