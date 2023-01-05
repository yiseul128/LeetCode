using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _315.Count_of_Smaller_Numbers_After_Self
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        int[] counts;
        public IList<int> CountSmaller(int[] nums)
        {
            IList<int> answer = new List<int>();
            counts = new int[nums.Length];

            numWithIdx[] numsWithIdx = new numWithIdx[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numsWithIdx[i] = new numWithIdx(nums[i], i);
                // Console.WriteLine(numsWithIdx[i].val + ", " + numsWithIdx[i].idx);
            }

            MergeSort(numsWithIdx);

            for (int i = 0; i < counts.Length; i++)
            {
                // Console.WriteLine(numsWithIdx[i].val);
                answer.Add(counts[i]);
            }

            return answer;
        }

        public void Merge(numWithIdx[] arr1, numWithIdx[] arr2, numWithIdx[] result)
        {
            int idx1 = 0;
            int idx2 = 0;
            int count = 0;

            while (idx1 + idx2 < result.Length)
            {
                if (idx2 == arr2.Length)
                {
                    counts[arr1[idx1].idx] += count;
                    result[idx1 + idx2] = arr1[idx1++];
                }
                else if (idx1 == arr1.Length)
                {
                    result[idx1 + idx2] = arr2[idx2++];
                }
                else if (arr1[idx1].val > arr2[idx2].val)
                {
                    count++;
                    result[idx1 + idx2] = arr2[idx2++];
                }
                else
                {
                    counts[arr1[idx1].idx] += count;
                    result[idx1 + idx2] = arr1[idx1++];
                }
            }

        }

        public void MergeSort(numWithIdx[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return;
            }

            int mid = len / 2;
            // Console.WriteLine(len +", "+mid +", " +(len-mid));
            numWithIdx[] arr1 = new numWithIdx[mid];
            Array.Copy(arr, 0, arr1, 0, mid);
            numWithIdx[] arr2 = new numWithIdx[len - mid];
            Array.Copy(arr, mid, arr2, 0, len - mid);

            MergeSort(arr1);
            MergeSort(arr2);

            Merge(arr1, arr2, arr);
        }
    }

    public class numWithIdx
    {
        public int val;
        public int idx;

        public numWithIdx(int val, int idx)
        {
            this.val = val;
            this.idx = idx;
        }
    }
}
