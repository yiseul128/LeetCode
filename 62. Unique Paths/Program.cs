using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Unique_Paths
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            int smaller = m - 1 < n - 1 ? m - 1 : n - 1;
            int bigger = m - 1 > n - 1 ? m - 1 : n - 1;

            long denominator = 1;
            for (int i = 2; i <= smaller; i++)
            {
                denominator *= Convert.ToInt64(i);
            }

            long numerator = 1;
            bool divided = false;
            for (int i = bigger + 1; i <= smaller + bigger; i++)
            {
                numerator *= Convert.ToInt64(i);

                if (!divided && numerator % denominator == 0)
                {
                    numerator /= denominator;
                    divided = true;
                }
            }

            return Convert.ToInt32(numerator);

        }
    }
}
