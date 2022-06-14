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
            string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            s = s.Trim();
            //Console.WriteLine(s);

            int index = 0;
            bool sign = true;

            if (s.Length == 0)
            {
                return 0;
            }

            //trim 0
            for (int i = index; i < s.Length; i++)
            {
                if ("0" == s[i].ToString())
                {
                    index++;
                    //Console.WriteLine(index);
                }
                else
                {
                    break;
                }
            }

            if (s[0].ToString() == "+" || s[0].ToString() == "-")
            {
                if (s[0].ToString() == "-")
                {
                    sign = false;
                }

                index++;
            }

            if (index == s.Length)
            {
                return 0;
            }

            if (s[index].ToString() == "+" || s[index].ToString() == "-")
            {
                return 0;
            }

            else
            {
                bool isDigit = false;
                for (int j = 0; j < digits.Length; j++)
                {
                    if (digits[j] == s[index].ToString())
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

            //trim 0
            for (int i = index; i < s.Length; i++)
            {
                if ("0" == s[i].ToString())
                {
                    index++;
                    //Console.WriteLine(index);
                }
                else
                {
                    break;
                }
            }

            int start = index;
            int end = s.Length;


            for (int i = index; i < s.Length; i++)
            {
                bool isDigit = false;

                //Console.WriteLine("s: " + s[i].ToString());
                for (int j = 0; j < digits.Length; j++)
                {
                    if (digits[j] == s[i].ToString())
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

            if (number.Length == 0)
            {
                return 0;
            }
            long result = Int64.Parse(number);

            if (!sign)
            {
                result *= -1;
            }

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
