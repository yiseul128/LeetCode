using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Reverse(-123)); //-321
            Console.WriteLine(s.Reverse(120)); //21

        }

        public class Solution
        {
            public int Reverse(int x)
            {
                if (x <= -2147483648 || x >= 2147483647)
                {
                    return 0;
                }

                bool neg = false;
                if (x < 0)
                {
                    neg = true;
                    x = -1 * x;
                }

                string reversedStr = "";
                int n = x.ToString().Length;
                int powered10 = (int)Math.Pow(10, n - 1);
                for (int i = 0; i < n; i++)
                {
                    reversedStr = (x / powered10).ToString() + reversedStr;
                    x %= powered10;
                    powered10 /= 10;
                }

                long reversed = long.Parse(reversedStr);
                if (neg)
                {
                    reversed *= -1;

                    if (reversed < -1 * Math.Pow(2, 31))
                    {
                        return 0;
                    }
                }
                else if (reversed > Math.Pow(2, 31) - 1)
                {
                    return 0;
                }

                return (int)reversed;
            }
        }
    }
}
