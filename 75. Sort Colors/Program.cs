using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75.Sort_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            //check by debugging
        }

        public class Solution
        {
            public void SortColors(int[] nums)
            {
                int[] count = new int[3];

                // count
                for (int i = 0; i < nums.Length; i++)
                {
                    count[nums[i]]++;
                }

                // assign
                int c0 = count[0];
                int c1 = count[0] + count[1];
                int c2 = count[0] + count[1] + count[2];
                for (int i = 0; i < c0; i++)
                {
                    nums[i] = 0;
                }
                for (int i = c0; i < c1; i++)
                {
                    nums[i] = 1;
                }
                for (int i = c1; i < c2; i++)
                {
                    nums[i] = 2;
                }

            }
        }
    }
}
