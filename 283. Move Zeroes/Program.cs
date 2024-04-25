using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283.Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int nonZeroIdx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIdx] = nums[i];
                    if (i != nonZeroIdx)
                    {
                        nums[i] = 0;
                    }
                    nonZeroIdx++;
                }
            }

            /*
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    int j = i + 1;
                    for (; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            int temp = nums[j];
                            nums[j] = nums[i];
                            nums[i] = temp;
                            break;
                        }
                    }
                    if (j == nums.Length - 1)
                    {
                        return; //non zero not found;
                    }

                }
            }
            */
        }
    }
}
