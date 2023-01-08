using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._3Sum_Closest
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {

        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int closest;
            closest = Int32.MaxValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];

                    // found target
                    if (sum == target)
                    {
                        return sum;
                    }

                    // compare
                    if (Math.Abs(closest - target) > Math.Abs(sum - target))
                    {
                        closest = sum;
                    }


                    if (sum < target)
                    {
                        // make sum bigger
                        j++;
                    }
                    else
                    {
                        // make sum smaller
                        k--;
                    }
                }
            }

            return closest;
        }
    }
}
