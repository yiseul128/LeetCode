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
        int maxAmount = 0;

        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            if (nums.Length == 2)
            {
                return nums[0] > nums[1] ? nums[0] : nums[1];
            }

            int[] maxFromIdx = new int[nums.Length];
            for (int i = 0; i < maxFromIdx.Length; i++)
            {
                maxFromIdx[i] = -1;
            }

            ExploreHouses(nums, 0, 0, maxFromIdx);
            ExploreHouses(nums, 0, 1, maxFromIdx);

            return maxAmount;
        }

        public int ExploreHouses(int[] nums, int total, int currIdx, int[] maxFromIdx)
        {
            // Console.WriteLine(currIdx + ": " + total);
            if (currIdx > nums.Length - 1)
            {
                maxAmount = maxAmount > total ? maxAmount : total;
                return total;
            }

            int currMax = total;
            int newMax = 0;
            if (currIdx + 2 < nums.Length && maxFromIdx[currIdx + 2] != -1)
            {
                newMax = total + maxFromIdx[currIdx + 2] + nums[currIdx];
                maxAmount = maxAmount > newMax ? maxAmount : newMax;
            }
            else
            {
                newMax = ExploreHouses(nums, total + nums[currIdx], currIdx + 2, maxFromIdx);
            }
            currMax = currMax > newMax ? currMax : newMax;

            if (currIdx < nums.Length - 2)
            {
                if (currIdx + 3 < nums.Length && maxFromIdx[currIdx + 3] != -1)
                {
                    newMax = total + maxFromIdx[currIdx + 3] + nums[currIdx];
                    maxAmount = maxAmount > newMax ? maxAmount : newMax;
                }
                else
                {
                    newMax = ExploreHouses(nums, total + nums[currIdx], currIdx + 3, maxFromIdx);
                }
            }
            currMax = currMax > newMax ? currMax : newMax;

            maxFromIdx[currIdx] = currMax - total;

            return currMax;
        }
    }
}
