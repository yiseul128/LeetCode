using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _238.Product_of_Array_Except_Self
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            int multiplied = 1;
            int zero = 0;
            int zeroIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zero++;
                    zeroIndex = i;

                    //more than 1 zero
                    if (zero > 1)
                    {
                        return result;
                    }
                    continue;
                }
                multiplied *= nums[i];
            }

            //1 zero
            if (zero == 1)
            {
                result[zeroIndex] = multiplied;
                return result;
            }

            //regular
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = multiplied / nums[i];
            }

            return result;
        }
    }
}
