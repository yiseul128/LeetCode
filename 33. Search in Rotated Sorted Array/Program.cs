using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Search_in_Rotated_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;

            Solution solution = new Solution();
            Console.WriteLine(solution.Search(nums, target)); //4
        }
    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {

            if (nums[0] == target)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return -1;
            }

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] == target)
                {
                    return i;
                }

                if (nums[i - 1] > nums[i])
                {
                    if (nums[i - 1] < target || nums[i] > target)
                    {
                        return -1; //no target afterward
                    }
                }

            }

            return -1;
        }
    }
}
