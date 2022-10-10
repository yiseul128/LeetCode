using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1884.Egg_Drop_With_2_Eggs_and_N_Floors
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int TwoEggDrop(int n)
        {
            // (x*(x+1))/2 = n
            // x^2 + x - 2*n = 0

            return (int)Math.Ceiling((((-1) + Math.Sqrt(1 + 8 * n))) / 2);

        }
    }
}
