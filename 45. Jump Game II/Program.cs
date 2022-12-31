using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Jump_Game_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {

        public int Jump(int[] nums)
        {
            int[] minFrom = new int[nums.Length];
            for (int i = 0; i < minFrom.Length; i++)
            {
                minFrom[i] = Int32.MaxValue;
            }
            return FindMin(nums, 0, 0, minFrom);
        }

        public int FindMin(int[] nums, int jumpCount, int idx, int[] minFrom)
        {
            // reach target
            if (idx == nums.Length - 1)
            {
                return jumpCount;
            }

            int currMin = Int32.MaxValue;
            for (int i = 1; i <= nums[idx]; i++)
            {
                // go over target
                if (idx + i > nums.Length - 1)
                {
                    continue;
                }

                int newMin = Int32.MaxValue;
                if (minFrom[idx + i] == Int32.MaxValue)
                {
                    newMin = FindMin(nums, jumpCount + 1, idx + i, minFrom);
                }
                else
                {
                    newMin = jumpCount + 1 + minFrom[idx + i];
                }
                // Console.WriteLine(newMin);

                currMin = currMin < newMin ? currMin : newMin;
            }

            minFrom[idx] = minFrom[idx] < currMin - jumpCount ? minFrom[idx] : currMin - jumpCount;
            return currMin;
        }
    }
}
