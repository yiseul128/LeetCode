using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _287.Find_the_Duplicate_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            bool[] found = new bool[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (found[nums[i]])
                {
                    return nums[i];
                }
                found[nums[i]] = true;
            }

            return 0;
        }
    }
}
