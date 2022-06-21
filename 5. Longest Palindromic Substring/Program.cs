using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.LongestPalindrome("bacabab"));
        }
    }

    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            string longest = s[0].ToString();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; (i - j >= 0) && (s.Length > j + i); j++)
                {
                    //center
                    if(s[i-j] == s[i + j])
                    {
                        longest = longest.Length > j* 2 + 1 ? longest: s.Substring(i - j, j * 2 + 1);
                    }
                    else
                    {
                        break;
                    }
                }

                for (int j = 1; (i - j >= 0) && (s.Length > j + i - 1); j++)
                {
                    //no center
                    if(s[i-j] == s[i+j-1])
                    {
                        longest = longest.Length > j * 2 ? longest : s.Substring(i - j, j * 2);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return longest;
        }
    }
}
