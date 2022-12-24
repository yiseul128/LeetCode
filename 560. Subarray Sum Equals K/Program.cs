using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _560.Subarray_Sum_Equals_K
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        int answer = 0;

        public void FindSubarrays(int[] nums, int start, int target)
        {
            if (start == nums.Length)
            {
                return;
            }

            int sum = 0;
            for (int i = start; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == target)
                {
                    answer++;
                }
            }

            FindSubarrays(nums, start + 1, target);
        }

        public int SubarraySum(int[] nums, int k)
        {
            FindSubarrays(nums, 0, k);
            return answer;
        }
    }
}
