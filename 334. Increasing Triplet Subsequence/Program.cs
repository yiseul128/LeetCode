using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _334.Increasing_Triplet_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3)
            {
                return false;
            }

            int n1 = Int32.MaxValue;
            int n2 = Int32.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (n1 >= nums[i])
                {
                    n1 = nums[i];
                }
                else if (n2 >= nums[i])
                {
                    n2 = nums[i];
                }
                else
                {
                    // curr num is bigger than both n1 and n2
                    return true;
                }

            }

            return false;
        }
    }
}
