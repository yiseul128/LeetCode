using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88.Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] answer = new int[m + n];

            int i1 = 0;
            int i2 = 0;
            int c = 0;

            while (true)
            {
                if (c == nums1.Length)
                {
                    break;
                }

                if (i1 == m)
                {
                    for (; i2 < n; i2++)
                    {
                        answer[c++] = nums2[i2];
                        //Console.WriteLine(nums2[i2]);
                    }
                    break;
                }
                if (i2 == n)
                {
                    for (; i1 < m; i1++)
                    {
                        answer[c++] = nums1[i1];
                        //Console.WriteLine(nums1[i1]);
                    }
                    break;
                }

                //regular
                if (nums1[i1] < nums2[i2])
                {
                    answer[c] = nums1[i1];
                    i1++;
                }
                else
                {
                    answer[c] = nums2[i2];
                    i2++;
                }
                c++;

            }

            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = answer[i];
            }
        }
    }
}
