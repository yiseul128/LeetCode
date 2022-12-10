using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Search_Insert_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int middle = (start + end) / 2;

            if (nums[start] >= target)
            {
                return 0;
            }
            if (nums[end] < target)
            {
                return end + 1;
            }

            while (start < end)
            {
                middle = (start + end) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }
                else if (nums[middle] < target)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
            return nums[end] >= target ? end : end + 1;
        }
    }
}
