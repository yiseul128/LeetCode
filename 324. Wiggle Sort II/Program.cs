using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _324.Wiggle_Sort_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public void WiggleSort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return;
            }

            int[] places = new int[5001];

            for (int i = 0; i < nums.Length; i++)
            {
                places[nums[i]]++;
            }

            int idx = nums.Length;
            // Console.WriteLine(idx%2);
            if (idx % 2 == 0)
            {
                idx -= 2;
            }
            else
            {
                idx -= 1;
            }

            bool adding = false;
            int count = 0;
            for (int i = 0; i < places.Length; i++)
            {
                // Console.WriteLine("lim: " + places.Length +", i: " + i);
                for (int j = 0; j < places[i]; j++)
                {
                    // Console.WriteLine("i: " + i + ", j: " + j+ ", idx: " +idx);
                    nums[idx] = i;
                    count++;

                    // turn direction
                    if (idx == 0)
                    {
                        // adding = true;
                        idx = nums.Length;
                        if (idx % 2 == 0)
                        {
                            idx -= 1;
                        }
                        else
                        {
                            idx -= 2;
                        }
                        continue;
                    }

                    if (adding)
                    {
                        idx += 2;
                    }
                    else
                    {
                        idx -= 2;
                    }

                    if (count == nums.Length)
                    {
                        // Console.WriteLine("done");
                        return;
                    }
                }
            }
        }
    }
}
