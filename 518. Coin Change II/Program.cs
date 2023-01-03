using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _518.Coin_Change_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {

        public int Change(int amount, int[] coins)
        {
            int n = coins.Length;
            int[,] counts = new int[n + 1, amount + 1]; // coin idx, amount

            // Console.WriteLine(counts.Length);
            for (int i = 0; i <= n; i++)
            {
                counts[i, 0] = 1;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int currAmount = 1; currAmount <= amount; currAmount++)
                {
                    int lastCount = counts[i - 1, currAmount];

                    if (currAmount >= coins[i - 1])
                    {
                        counts[i, currAmount] = lastCount + counts[i, currAmount - coins[i - 1]];
                    }
                    else
                    {
                        counts[i, currAmount] = lastCount;
                    }
                }
            }

            return counts[n, amount];
        }

    }
}
