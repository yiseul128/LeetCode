using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1143.Longest_Common_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        int answer;
        public int LongestCommonSubsequence(string text1, string text2)
        {

            //str1 > str2
            if (text1.Length > text2.Length)
            {
                int[,] foundIdx = new int[text1.Length, text2.Length];
                FindSubsequence(text1, text2, 0, 0, 0, foundIdx);
            }
            else
            {
                int[,] foundIdx = new int[text2.Length, text1.Length];
                FindSubsequence(text2, text1, 0, 0, 0, foundIdx);
            }

            return answer;
        }
        public int FindSubsequence(string str1, string str2, int str1idx, int str2idx, int count, int[,] foundIdx)
        {
            if (str1.Length - 1 < str1idx || str2.Length - 1 < str2idx)
            {
                return count;
            }

            // find match
            int newStr1idx = -1;
            int currCount = count;

            // no memo yet
            if (foundIdx[str1idx, str2idx] == 0)
            {
                for (int i = str1idx; i < str1.Length; i++)
                {
                    if (str2[str2idx] == str1[i])
                    {
                        newStr1idx = i;
                        break;
                    }
                }

                int skipped = FindSubsequence(str1, str2, str1idx, str2idx + 1, count, foundIdx);
                currCount = currCount > skipped ? currCount : skipped;

                // found
                if (newStr1idx != -1)
                {
                    int used = FindSubsequence(str1, str2, newStr1idx + 1, str2idx + 1, count + 1, foundIdx);
                    currCount = currCount > used ? currCount : used;
                }
                foundIdx[str1idx, str2idx] = currCount - count;
            }
            // already memo
            else
            {
                // Console.WriteLine(currCount + "=> "+str1idx + ", " + str2idx+ ": "+foundIdx[str1idx, str2idx]);
                currCount += foundIdx[str1idx, str2idx];
            }

            answer = answer > currCount ? answer : currCount;
            return currCount;
        }
    }
}
