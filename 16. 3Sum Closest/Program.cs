using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._3Sum_Closest
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {

        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int closest;
            closest = Int32.MaxValue;

            // i<k<j
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 2; j < nums.Length; j++)
                {
                    int sumOfTwo = nums[i] + nums[j];
                    int requiredK = target - sumOfTwo;

                    // binary search
                    int l = i + 1;
                    int r = j - 1;
                    while (l <= r)
                    {
                        int m = Convert.ToInt32(Math.Floor((double)(l + r) / 2));
                        // update closest
                        int newSum = sumOfTwo + nums[m];
                        closest = Math.Abs(target - closest) < Math.Abs(target - newSum) ? closest : newSum;

                        if (nums[m] < requiredK)
                        {
                            l = m + 1;
                        }
                        else if (nums[m] > requiredK)
                        {
                            r = m - 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return closest;
        }
    }
}
