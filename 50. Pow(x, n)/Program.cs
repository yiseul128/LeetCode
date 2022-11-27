using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Pow_x__n_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return 1.0 / RecurPow(x, Convert.ToInt64(n) * -1);
            }
            else
            {
                return RecurPow(x, Convert.ToInt64(n));
            }
        }

        public double RecurPow(double x, long n)
        {
            // Console.WriteLine(n);
            if (n == 1)
            {
                return x;
            }

            double half = RecurPow(x * x, n / 2);
            if (n % 2 == 0)
            {
                return half;
            }
            else
            {
                return half * x;
            }
        }
    }
}
