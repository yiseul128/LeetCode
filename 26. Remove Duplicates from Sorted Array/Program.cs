using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int count = 1;
            int prev = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (prev != nums[i])
                {
                    nums[count] = nums[i];
                    count++;
                    prev = nums[i];
                }
            }

            return count;
        }
    }
}
