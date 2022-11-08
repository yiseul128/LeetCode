using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.Sqrt_x_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int MySqrt(int x)
        {

            if (x < 2)
            {
                return x;
            }

            int low = 0;
            int high = x / 2;
            long lx = Convert.ToInt64(x);
            while (low < high)
            {
                int mid = low + (high - low) / 2 + 1;
                long midSq = Convert.ToInt64(mid) * mid;

                //Console.WriteLine("mid: " + mid);
                if (midSq == lx)
                {
                    return mid;
                }
                else if (midSq > x)
                {
                    //Console.WriteLine("big");
                    if (Convert.ToInt64(mid - 1) * (mid - 1) <= lx)
                    {
                        return mid - 1;
                    }
                    high = mid - 1;
                }
                else
                {
                    //Console.WriteLine("small");
                    if (Convert.ToInt64(mid + 1) * (mid + 1) > lx)
                    {
                        return mid;
                    }
                    low = mid + 1;
                }
            }

            return 0;
        }
    }
}
