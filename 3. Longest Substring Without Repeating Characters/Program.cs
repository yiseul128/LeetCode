using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            Console.WriteLine(s.LengthOfLongestSubstring("bbbbba")); //2
            Console.WriteLine(s.LengthOfLongestSubstring("pwwkew")); //3
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Trim().Length == 0)
            {
                if (s.Length == 0)
                {
                    return 0;
                }
                return 1;
            }

            string prevSub = "" + s[0];
            string uniqueSub = "" + s[0];
            int maxLength = 1;

            for (int i = 1; i < s.Length; i++)
            {
                bool repeat = false;
                int repeatFound = 0;
                for (int j = 0; j < uniqueSub.Length; j++)
                {
                    if (uniqueSub[j] == s[i])
                    {
                        repeat = true;
                        repeatFound = j;
                        break;
                    }
                }
                if (!repeat)
                {
                    uniqueSub += s[i];
                }
                else
                {
                    prevSub = uniqueSub;
                    // cut from first found s[i] and get a new substr with s[i]
                    uniqueSub = uniqueSub.Substring(repeatFound + 1) + s[i];
                }

                if (prevSub.Length < uniqueSub.Length)
                {
                    maxLength = (maxLength < uniqueSub.Length) ? uniqueSub.Length : maxLength;
                }
                else
                {
                    maxLength = (maxLength < prevSub.Length) ? prevSub.Length : maxLength;
                }
            }

            return maxLength;
        }
    }
}
