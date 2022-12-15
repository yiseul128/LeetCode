using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Next_Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            // length < 3
            if (nums.Length == 1)
            {
                return;
            }
            if (nums.Length == 2)
            {
                int tmp = nums[0];
                nums[0] = nums[1];
                nums[1] = tmp;
                return;
            }

            // start from right => find nums[i] < nums[i+1]
            int leftIdx = -1;
            int left = -1;
            int rightIdx = -1;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i - 1] < nums[i])
                {
                    leftIdx = i - 1;
                    left = nums[leftIdx];

                    // find right and switch
                    for (int j = nums.Length - 1; j > leftIdx; j--)
                    {
                        if (nums[j] > left)
                        {
                            nums[leftIdx] = nums[j];
                            nums[j] = left;
                            rightIdx = j;
                            break;
                        }
                    }
                    break;
                }
            }

            // sort the rest on the right side 
            leftIdx++;

            // invert order 
            int endIdx = nums.Length - 1;
            for (int i = 0; i < (endIdx - leftIdx + 1) / 2; i++)
            {
                int tmp = nums[i + leftIdx];
                nums[i + leftIdx] = nums[endIdx - i];
                nums[endIdx - i] = tmp;
            }
        }
    }
}
