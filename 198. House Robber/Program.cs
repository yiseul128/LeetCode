using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _198.House_Robber
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int[] memo = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length + 1; i++)
            {
                memo[i] = Int32.MinValue;
            }
            Rob(nums, memo, 0, 0);
            Rob(nums, memo, 1, 0);
            return memo[nums.Length];
        }

        public void Rob(int[] nums, int[] memo, int idx, int sum)
        {
            // end
            if (idx >= nums.Length)
            {
                memo[nums.Length] = memo[nums.Length] > sum ? memo[nums.Length] : sum;
                return;
            }

            // already visited with bigger sum
            if (memo[idx] >= sum)
            {
                return;
            }

            memo[idx] = memo[idx] > sum ? memo[idx] : sum;
            sum += nums[idx];
            // skip 1 house
            Rob(nums, memo, idx + 2, sum);
            // skip 2 houses
            Rob(nums, memo, idx + 3, sum);
        }
    }
}
