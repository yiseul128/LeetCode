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

                int reversed = 0;

                int n = x.ToString().Length;

                for (int i = n - 1; i > 0; i--)
                {
                    reversed += Convert.ToInt32(Math.Pow(10, n - i - 1)) * (x / Convert.ToInt32(Math.Pow(10, i)));
                    //Console.WriteLine("rev: " + reversed);
                    x = x % Convert.ToInt32(Math.Pow(10, i));
                    //Console.WriteLine("x: " + x);
                }

                if (n == 10)
                {
                    if (x > 2)
                    {
                        return 0;
                    }
                    if (x == 2)
                    {
                        if (neg && reversed >= 147483648)
                        {
                            return 0;
                        }
                        if (!neg && reversed >= 147483647)
                        {
                            return 0;
                        }
                    }

                }
                //Console.WriteLine("last: " + Convert.ToInt32(Math.Pow(10, n-1)) * x);

                reversed += Convert.ToInt32(Math.Pow(10, n - 1)) * x;
                //Console.WriteLine("rev: " + reversed);

                if (reversed > Math.Pow(2, 31) - 1)
                {
                    return 0;
                }

                if (neg)
                {
                    reversed *= -1;

                    if (reversed < -1 * Math.Pow(2, 31))
                    {
                        return 0;
                    }
                }



                return reversed;
            }
        }
    }
}
