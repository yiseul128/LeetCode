using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Median_of_Two_Sorted_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int l = nums1.Length + nums2.Length;

            int i1 = 0;
            int i2 = 0;
            int c = 0;
            if (l % 2 == 0)
            {
                // use 2
                int answer = 0;
                bool first = false;
                while (true)
                {
                    //one finished
                    if (nums1.Length < i1 + 1)
                    {
                        i2 += (l / 2) - c;
                        if (first)
                        {
                            return ((double)(answer + nums2[i2])) / 2;
                        }
                        else
                        {
                            return ((double)(nums2[i2 - 1] + nums2[i2])) / 2;
                        }
                    }
                    if (nums2.Length < i2 + 1)
                    {
                        i1 += (l / 2) - c;
                        if (first)
                        {
                            return ((double)(answer + nums1[i1])) / 2;
                        }
                        else
                        {
                            return ((double)(nums1[i1 - 1] + nums1[i1])) / 2;
                        }
                    }

                    //regular
                    if (nums1[i1] < nums2[i2])
                    {
                        if (c == l / 2 - 1)
                        {
                            // Console.WriteLine("-1");
                            answer += nums1[i1];
                            first = true;
                        }
                        if (c == l / 2)
                        {
                            return ((double)(answer + nums1[i1])) / 2;
                        }
                        i1++;
                    }
                    else
                    {
                        if (c == l / 2 - 1)
                        {
                            // Console.WriteLine("-1");
                            answer += nums2[i2];
                            first = true;
                        }
                        if (c == l / 2)
                        {
                            return ((double)(answer + nums2[i2])) / 2;
                        }
                        i2++;
                    }
                    c++;
                }
            }
            else
            {
                // use 1
                while (true)
                {
                    //one finished
                    if (nums1.Length < i1 + 1)
                    {
                        i2 += (l / 2) - c;
                        return (double)nums2[i2];
                    }
                    if (nums2.Length < i2 + 1)
                    {
                        i1 += (l / 2) - c;
                        return (double)nums1[i1];
                    }

                    //regular
                    if (nums1[i1] < nums2[i2])
                    {
                        if (c == l / 2)
                        {
                            return nums1[i1];
                        }
                        i1++;
                    }
                    else
                    {
                        if (c == l / 2)
                        {
                            return nums2[i2];
                        }
                        i2++;
                    }
                    c++;
                }
            }
            return 0;
        }
    }
}
