using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Maximum_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            Console.WriteLine(solution.MaxSubArray(nums)); //6
        }
    }
    public class Solution
    {
        //looked at Kadane’s Algorithm
        public int MaxSubArray(int[] nums)
        {

            int max = nums[0];
            int curSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                curSum += nums[i];

                //Console.WriteLine(curSum + ", " + max);
                if (curSum > max)
                {
                    max = curSum;
                }
                if (curSum < 0)
                {
                    curSum = 0;
                }
            }

            return max;
        }
    }
}
