using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.String_to_Integer__atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            Console.WriteLine(s.MyAtoi("   -42")); //-42
            Console.WriteLine(s.MyAtoi("4193 with words")); //4193
        }
    }

    public class Solution
    {
        public int MyAtoi(string s)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //trim white space
            s = s.Trim();

            int index = 0;
            bool sign = true;

            if (s.Length == 0)
            {
                return 0;
            }

            //trim 0
            for (int i = index; i < s.Length; i++)
            {
                if (digits[0] == s[i])
                {
                    index++;
                }
                else
                {
                    break;
                }
            }

            //get sign
            if (s[0] == '+' || s[0] == '-')
            {
                if (s[0] == '-')
                {
                    sign = false;
                }

                index++;
            }

            //after sign no number
            if (index == s.Length)
            {
                return 0;
            }

            //another sign (invalid)
            if (s[index] == '+' || s[index] == '-')
            {
                return 0;
            }
            //after sign not a number (invalid)
            else
            {
                bool isDigit = false;
                for (int j = 0; j < digits.Length; j++)
                {
                    if (digits[j] == s[index])
                    {
                        isDigit = true;
                        break;
                    }
                }
                if (!isDigit)
                {
                    return 0;
                }
            }

            //trim 0 after sign
            for (int i = index; i < s.Length; i++)
            {
                if (digits[0] == s[i])
                {
                    index++;
                }
                else
                {
                    break;
                }
            }

            int start = index;
            int end = s.Length;

            //find end
            for (int i = index; i < s.Length; i++)
            {
                bool isDigit = false;

                for (int j = 0; j < digits.Length; j++)
                {
                    if (digits[j] == s[i])
                    {
                        isDigit = true;
                        break;
                    }
                }

                if (!isDigit)
                {
                    end = i;
                    break;
                }
            }

            string number = s.Substring(start, end - start);

            if (number.Length == 0)
            {
                return 0;
            }

            //check over boundary
            if (number.Length > 10)
            {
                if (sign)
                {
                    return 2147483647;
                }
                else
                {
                    return -2147483648;
                }
            }

            long result = Int64.Parse(number);

            if (!sign)
            {
                result *= -1;
            }

            //check over boundary
            if (result < -2147483648)
            {
                result = -2147483648;
            }
            else if (result > 2147483647)
            {
                result = 2147483647;
            }

            return Convert.ToInt32(result);
        }
    }
}
