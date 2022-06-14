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

            int[] nums = { 7, 8, 9, 11, 12 };
            Console.WriteLine(s.FirstMissingPositive(nums)); // 1

            int[] nums2 = { 3, 4, -1, 1 };
            Console.WriteLine(s.FirstMissingPositive(nums2)); // 2
        }
    }

    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            bool[] found = new bool[nums.Length + 2]; //too much memory?

            for (int i = 0; i < nums.Length; i++)
            {
                if (0 < nums[i] && nums[i] < nums.Length + 2)
                {
                    found[nums[i]] = true;
                }
            }

            //         Console.WriteLine("[");
            //         for(int i = 1; i<found.Length; i++){
            //              Console.WriteLine(found[i] + ", ");
            //         }
            //         Console.WriteLine("]");

            int missing = -1;
            for (int i = 1; i < found.Length; i++)
            {
                if (!found[i])
                {
                    missing = i;
                    break;
                }
            }

            return missing;
        }
    }
}
