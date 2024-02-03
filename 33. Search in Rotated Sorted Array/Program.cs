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

            // find starting idx
            int numLen = nums.Length;
            int startIdx = 0;
            for (int i = 1; i < numLen; i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    startIdx = i;
                    break;
                }
            }

            // binary search
            int left = 0;
            int right = numLen - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int adjustedMid = (mid + startIdx) % numLen;
                if (nums[adjustedMid] == target)
                {
                    return adjustedMid;
                }
                else if (nums[adjustedMid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
