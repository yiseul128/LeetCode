using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _350.Intersection_of_Two_Arrays_II
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> n1 = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (n1.ContainsKey(nums1[i]))
                {
                    n1[nums1[i]]++;
                }
                else
                {
                    n1.Add(nums1[i], 1);
                }
            }

            List<int> intersection = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (n1.ContainsKey(nums2[i]))
                {
                    intersection.Add(nums2[i]);
                    if (n1[nums2[i]] == 1)
                    {
                        n1.Remove(nums2[i]);
                    }
                    else
                    {
                        n1[nums2[i]]--;
                    }
                }
            }

            return intersection.ToArray();
        }
    }
}
