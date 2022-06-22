using System;

namespace _153._Find_Minimum_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = { 4, 5, 6, 7, 2 }; //2
            Console.WriteLine(s.FindMin(nums));
        }
    }

    public class Solution
    {
        public int FindMin(int[] nums)
        {

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    return nums[i];
                }
            }

            return nums[0];
        }
    }
}
