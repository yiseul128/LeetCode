using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162.Find_Peak_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = { 1, 2, 1, 3, 5, 6, 4 };
            Console.WriteLine(s.FindPeakElement(nums)); //1

        }
    }

    public class Solution
    {
        public int FindPeakElement(int[] nums)
        {
            //only one element
            if (nums.Length == 1)
            {
                return 0;
            }

            //first or last is peak
            if (nums[0] > nums[1])
            {
                return 0;
            }
            if (nums[nums.Length - 1] > nums[nums.Length - 2])
            {
                return nums.Length - 1;
            }

            //regular
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
