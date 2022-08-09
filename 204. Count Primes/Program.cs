using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204.Count_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int CountPrimes(int n)
        {
            HashSet<int> nums = new HashSet<int>();
            for (int i = 2; i < n; i++)
            {
                nums.Add(i);
            }

            for (int i = 2; i <= n / 2; i++)
            {
                if (nums.Contains(i))
                {
                    for (int d = i * 2; d < n; d += i)
                    {
                        nums.Remove(d);
                    }
                }
            }

            return nums.Count();
        }
    }
}
