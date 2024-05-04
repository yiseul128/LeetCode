using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _394.Decode_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string DecodeString(string s)
        {
            Stack<int> intStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();

            string curr = "";
            int k = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    k = k * 10 + int.Parse(s[i].ToString());
                }
                else if (s[i] == '[')
                {
                    // push to stack
                    intStack.Push(k);
                    strStack.Push(curr);

                    // reset
                    curr = "";
                    k = 0;
                }
                else if (s[i] == ']')
                {
                    // generate 
                    string newStr = "";
                    for (k = intStack.Pop(); k > 0; k--)
                    {
                        newStr += curr;
                    }
                    // curr = prev + new
                    curr = strStack.Pop() + newStr;
                }
                else
                {
                    curr += s[i].ToString();
                }
            }

            return curr;
        }

        /* recursive sln */
        //string num = "0123456789";
        //int end = -1;

        //public string DecodeString(string s)
        //{
        //    return Decode(s, 0);
        //}

        //public string Decode(string str, int start)
        //{
        //    string decoded = "";

        //    int numStart = -1;
        //    while (start < str.Length)
        //    {
        //        if (str[start] == '[')
        //        {
        //            decoded += String.Concat(Enumerable.Repeat(Decode(str, start + 1), Convert.ToInt32(str.Substring(numStart, start - numStart))));
        //            start = end;
        //            numStart = -1;
        //        }
        //        else if (str[start] == ']')
        //        {
        //            end = start;
        //            return decoded;
        //        }
        //        else if (num.Contains(str[start]))
        //        {
        //            if (numStart == -1)
        //            {
        //                numStart = start;
        //            }
        //        }
        //        else
        //        {
        //            decoded += str[start].ToString();
        //        }
        //        start++;
        //    }

        //    return decoded;
        //}
    }
}
