using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.First_Missing_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] nums = { 4, 1, 2, 3 };
            Console.WriteLine(s.FirstMissingPositive(nums)); // 5

            int[] nums2 = { 3, 4, -1, 1 };
            Console.WriteLine(s.FirstMissingPositive(nums2)); // 2
        }
    }

    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            // remove 1>x || nums.Length<x => 0
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 1 || nums[i] > nums.Length)
                {
                    nums[i] = 0;
                }
            }

            // move nums to corresponding idx
            int prev = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // deal with prev
                // might be n^2 due to this while loop, although not likely to happen in cases
                while (prev != 0)
                {
                    int temp = 0;
                    if (nums[prev - 1] != prev)
                    {
                        temp = nums[prev - 1];
                    }
                    nums[prev - 1] = prev;
                    prev = temp;
                }

                // deal with curr
                if (nums[i] != 0 && nums[i] != i + 1)
                {
                    int currNum = nums[i];
                    prev = nums[currNum - 1];
                    nums[currNum - 1] = currNum;
                    nums[i] = 0;
                }
            }

            // check 1st missing pos
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    return i + 1;
                }
            }

            return nums.Length + 1;
        }
    }
}
