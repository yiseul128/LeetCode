using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _172.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            //number of 0 = number of 10 = number of 5 when factored

            int fives = 0;

            int multiplied = 5;
            while (multiplied <= n)
            {
                int c = 0;
                int cur = multiplied;

                while (true)
                {
                    if (cur % 5 == 0)
                    {
                        cur /= 5;
                        c++;
                    }
                    else
                    {
                        break;
                    }
                }

                fives += c;
                //Console.WriteLine(fives);
                multiplied += 5;
            }

            return fives;
        }
    }
}
