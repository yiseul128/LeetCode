using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _416.Partition_Equal_Subset_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool CanPartition(int[] nums)
        {
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            if (total % 2 == 1)
            {
                return false;
            }

            total /= 2;
            bool[] sums = new bool[total + 1];
            sums[0] = true;
            foreach (int n in nums)
            {
                for (int i = total; i >= n; i--)
                {
                    sums[i] = sums[i] || sums[i - n];
                }
            }

            return sums[total];
        }
    }
}
