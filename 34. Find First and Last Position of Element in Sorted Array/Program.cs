using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] answer = new int[2];
            answer[0] = -1;
            answer[1] = -1;
            RecurSearchRange(nums, target, 0, nums.Length - 1, answer);
            return answer;
        }

        public void RecurSearchRange(int[] nums, int target, int left, int right, int[] answer)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    // recurr
                    int first = answer[0];
                    int last = answer[1];

                    // first
                    if (first == -1 || mid < first)
                    {
                        answer[0] = mid;
                        if (left < mid)
                        {
                            RecurSearchRange(nums, target, 0, mid - 1, answer);
                        }
                    }

                    // last
                    if (last == -1 || mid > last)
                    {
                        answer[1] = mid;
                        if (right > mid)
                        {
                            RecurSearchRange(nums, target, mid + 1, nums.Length - 1, answer);
                        }
                    }
                    return;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }
    }
}
