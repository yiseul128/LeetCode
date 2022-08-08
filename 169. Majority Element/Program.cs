using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169.Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (freq.ContainsKey(nums[i]))
                {
                    freq[nums[i]]++;
                }
                else
                {
                    freq[nums[i]] = 1;
                }

                if (freq[nums[i]] > nums.Length / 2)
                {
                    return nums[i];
                }
            }

            return 0;
        }
    }
}
