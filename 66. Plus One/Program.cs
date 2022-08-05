using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;

            digits[i] += 1;

            while (digits[i] == 10 && i != 0)
            {
                digits[i - 1] += 1;
                digits[i] = 0;
                i--;
            }

            if (digits[0] == 10)
            {
                digits[0] = 0;
                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                for (int j = 0; j < digits.Length; j++)
                {
                    newDigits[j + 1] = digits[j];
                }
                return newDigits;
            }

            return digits;
        }
    }
}
