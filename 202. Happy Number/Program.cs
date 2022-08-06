using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202.Happy_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        HashSet<int> nums = new HashSet<int>();

        public bool IsHappy(int n)
        {
            int l = n.ToString().Length;
            int result = 0;
            for (int i = l - 1; i >= 0; i--)
            {
                int digit = n / Convert.ToInt32(Math.Pow(10, i));
                Console.WriteLine(digit);
                result += digit * digit;
                n %= Convert.ToInt32(Math.Pow(10, i));

            }

            if (nums.Contains(result))
            {
                return false;
            }

            if (result == 1)
            {
                return true;
            }

            nums.Add(result);
            return IsHappy(result);

        }
    }
}
