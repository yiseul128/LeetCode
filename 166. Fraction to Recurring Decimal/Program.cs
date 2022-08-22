using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _166.Fraction_to_Recurring_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string FractionToDecimal(int numerator, int denominator)
        {

            // terminating
            string answer = "";
            long num = numerator;
            long den = denominator;

            //negative
            if ((den < 0 && num > 0) || (den > 0 && num < 0))
            {
                answer = "-";
            }

            num = Math.Abs(num);
            den = Math.Abs(den);

            long intPart = num / den;
            answer += intPart.ToString();
            if (intPart * den == num)
            {
                return answer;
            }

            answer += ".";
            List<long> nums = new List<long>();
            List<long> digits = new List<long>();

            long remainder = num % den;

            int intPartN = answer.Length;

            //decimal part
            int prev = 0;
            while (true)
            {
                remainder *= 10;
                //Console.WriteLine(remainder + ", " + den);
                long digit = remainder / den;
                remainder = remainder % den;

                if (nums.Contains(remainder))
                {
                    int i = nums.IndexOf(remainder, prev);
                    Console.WriteLine(remainder + ", " + i);
                    if (digits.ElementAt(i) == digit)
                    {
                        return answer.Substring(0, intPartN + i) + "(" + answer.Substring(intPartN + i) + ")";
                    }
                    prev = i + 1;
                }
                answer += digit.ToString();
                nums.Add(remainder);
                digits.Add(digit);

                if (remainder == 0)
                {
                    break;
                }
            }

            return answer;
        }
    }
}
