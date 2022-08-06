using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _189.Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            int count = 0;
            int index = 0;
            int val = nums[0];
            int nextVal = 0;

            bool[] visited = new bool[nums.Length];

            while (count != nums.Length)
            {
                if (visited[index])
                {
                    index = (index + 1) % nums.Length;
                    val = nums[index];
                    continue;
                }
                count++;

                visited[index] = true;

                index = (index + k) % nums.Length;
                nextVal = nums[index];
                nums[index] = val;
                val = nextVal;

            }
        }
    }
}
