using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _139.Word_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            List<string> data = new List<string>();

            data.Add( "aaaaaaaaaa");
            data.Add("aa");
            data.Add("a");
            Console.WriteLine(s.WordBreak("aab", data));
        }
    }

    public class Solution
    {
        List<string> memo;
        public bool WordBreak(string s, IList<string> wordDict)
        {
            memo = new List<string>();
            return recur(s, wordDict);
        }

        public bool recur(string s, IList<string> wordDict)
        {
            if (memo.Contains(s))
            {
                return false;
            }

            for(int i=0; i<wordDict.Count; i++)
            {
                if (s == wordDict[i]) //base
                {
                    return true;
                }

                if(s.Length >= wordDict[i].Length)
                {
                    if(s.Substring(0, wordDict[i].Length) == wordDict[i])
                    {
                        if (recur(s.Substring(wordDict[i].Length), wordDict))
                        {
                            return true;
                        }
                    }
                }

                if (i == wordDict.Count - 1)
                {
                    if (!memo.Contains(s))
                    {
                        memo.Add(s);
                    }
                    return false;
                }
            }

            return false;
        }
    }
}
