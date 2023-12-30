using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] strs = {"flower", "flow", "flight"};
            Console.WriteLine(s.LongestCommonPrefix(strs)); //fl
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 1)
            {
                return strs[0];
            }

            int minLength = strs[0].Length;

            //get min length of strs elements
            for (int i = 1; i < strs.Length; i++)
            {
                minLength = minLength > strs[i].Length ? strs[i].Length : minLength;
            }

            string prefix = "";
            for (int i = 0; i < minLength; i++)
            {

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != strs[j - 1][i])
                    {
                        return prefix;
                    }
                }

                prefix += strs[0][i].ToString();
            }

            return prefix;
        }
    }
}
