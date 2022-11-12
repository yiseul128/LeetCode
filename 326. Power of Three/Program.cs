using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _326.Power_of_Three
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            while (n != 1)
            {
                if (n % 3 == 0)
                {
                    n /= 3;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
