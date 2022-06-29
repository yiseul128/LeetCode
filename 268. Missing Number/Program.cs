using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _268.Missing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(solution.MissingNumber(nums)); //8
        }
    }
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            bool[] found = new bool[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                found[nums[i]] = true;
            }

            for (int i = 0; i < found.Length; i++)
            {
                if (!found[i])
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
