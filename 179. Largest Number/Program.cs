using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _179.Largest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class NumComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == y)
            {
                return 0;
            }
            ulong xy = Convert.ToUInt64(x + y);
            ulong yx = Convert.ToUInt64(y + x);

            if (xy > yx)
            {
                return -1;
            }
            return 1;
        }
    }
    public class Solution
    {

        public string LargestNumber(int[] nums)
        {

            List<string> numList = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                string num = nums[i].ToString();

                numList.Add(num);
            }

            string answer = "";

            numList.Sort(new NumComparer());
            foreach (string s in numList)
            {
                answer += s;
                //Console.WriteLine(s);
            }

            if (answer[0] == '0')
            {
                return "0";
            }

            return answer;
        }
    }
}
