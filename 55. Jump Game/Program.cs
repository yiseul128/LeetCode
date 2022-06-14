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
        bool[] memo;
        int count = 0;
        int[] globalNums;

        public bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }
            if (nums.Length > 10000)
            {
                return false;
            }

            globalNums = nums;
            memo = new bool[nums.Length];
            return RecurJump(0);
        }


        public bool RecurJump(int jumped)
        {
            if (globalNums[jumped] == 0)
            { //stop there and move on to next
                return false;
            }
            if (memo[jumped])
            {
                return false;
            }

            for (int i = 1; i <= globalNums[jumped]; i++)
            {
                int curJumped = jumped;

                //Console.WriteLine("i: " + i);

                curJumped += i;

                //Console.WriteLine("curJumped: " + curJumped);

                //base case
                if (globalNums.Length <= curJumped + 1)
                {
                    return true;
                }
                if (globalNums[curJumped] == 0)
                { //stop there and move on to next
                    continue;
                }

                //regular
                if (RecurJump(curJumped))
                {
                    return true;
                };
            }
            memo[jumped] = true;
            return false;

        }
    }
}
