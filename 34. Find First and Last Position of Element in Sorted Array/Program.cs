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

            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                {
                    if (answer[0] == -1)
                    {
                        answer[0] = i;
                        answer[1] = i;
                    }
                    else
                    {
                        answer[1] = i;
                    }
                }
            }

            return answer;
        }
    }
}
