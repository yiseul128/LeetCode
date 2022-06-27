using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152.Maximum_Product_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 2, 3, -2, 4 }; 
            Console.WriteLine(solution.MaxProduct(nums)); //6
        }
    }
    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            int max = nums[0];
            int curPro = 1;

            bool firstNeg = false;
            int untilFirst = 1;
            for (int i = 0; i < nums.Length; i++)
            {

                curPro *= nums[i];

                if (curPro < 0)
                {
                    if (firstNeg)
                    {
                        max = max > curPro / untilFirst ? max : curPro / untilFirst;
                    }
                }
                if (!firstNeg)
                {
                    untilFirst *= nums[i];
                    if (nums[i] < 0)
                    {
                        firstNeg = true;
                    }
                }

                //Console.WriteLine(curPro + ", " + max);
                if (curPro > max)
                {
                    max = curPro;
                }
                if (curPro == 0)
                {
                    curPro = 1;
                    firstNeg = false;
                    untilFirst = 1;
                }
            }

            return max;
        }
    }

}
