using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128.Longest_Consecutive_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {

            if (nums.Length == 0)
            {
                return 0;
            }

            SortedSet<int> numbers = new SortedSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                numbers.Add(nums[i]);
            }

            int longest = 0;
            int count = 0;
            int curr = numbers.First();

            while (numbers.Count != 0)
            {
                if (numbers.Remove(curr))
                {
                    count++;
                    curr++;
                }
                else
                {
                    longest = longest > count ? longest : count;
                    count = 0;
                    curr = numbers.First();
                }
            }
            longest = longest > count ? longest : count;
            return longest;
        }
    }
}
