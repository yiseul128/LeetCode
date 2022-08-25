using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136.Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.Contains(nums[i]))
                {
                    numbers.Remove(nums[i]);
                }
                else
                {
                    numbers.Add(nums[i]);
                }
            }

            foreach (int i in numbers)
            {
                return i;
            }

            return -1;
        }
    }
}
