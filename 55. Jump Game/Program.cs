using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.Jump_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] nums = { 2, 3, 1, 1, 4 };
            Console.WriteLine(s.CanJump(nums)); //true

            int[] nums2 = { 3, 2, 1, 0, 4 };
            Console.WriteLine(s.CanJump(nums2)); //false
        }
    }

    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            bool[] memo = new bool[nums.Length];
            return RecurCanJump(nums, 0, memo);
        }

        public bool RecurCanJump(int[] nums, int idx, bool[] memo)
        {
            if (idx >= nums.Length - 1)
            {
                return true;
            }

            if (memo[idx])
            {
                return false;
            }

            for (int i = nums[idx]; i > 0; i--)
            {
                if (RecurCanJump(nums, idx + i, memo))
                {
                    return true;
                }
            }

            memo[idx] = true;
            return false;
        }
    }
}
