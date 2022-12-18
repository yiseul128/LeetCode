using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _438.Find_All_Anagrams_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {

            IList<int> answer = new List<int>();

            if (p.Length > s.Length)
            {
                return answer;
            }

            Dictionary<char, int> targetChars = new Dictionary<char, int>();
            Dictionary<char, int> currentChars = new Dictionary<char, int>();

            // build target chars
            for (int i = 0; i < p.Length; i++)
            {
                if (targetChars.ContainsKey(p[i]))
                {
                    targetChars[p[i]]++;
                }
                else
                {
                    targetChars.Add(p[i], 1);
                }
            }

            // initial build for currentChars
            int currStart = 0;
            for (int i = currStart; i < p.Length; i++)
            {
                if (currentChars.ContainsKey(s[i]))
                {
                    currentChars[s[i]]++;
                }
                else
                {
                    currentChars.Add(s[i], 1);
                }
            }

            // check
            bool wasAnagram = true;
            foreach (KeyValuePair<char, int> entry in targetChars)
            {
                if (currentChars.ContainsKey(entry.Key))
                {
                    if (currentChars[entry.Key] < entry.Value)
                    {
                        wasAnagram = false;
                        break;
                    }
                }
                else
                {
                    wasAnagram = false;
                    break;
                }
            }
            if (wasAnagram)
            {
                answer.Add(currStart);
            }
            currStart++;

            // go through s
            while (currStart + p.Length <= s.Length)
            {
                // remove last start
                currentChars[s[currStart - 1]]--;
                // add curr end
                if (currentChars.ContainsKey(s[currStart + p.Length - 1]))
                {
                    currentChars[s[currStart + p.Length - 1]]++;
                }
                else
                {
                    currentChars.Add(s[currStart + p.Length - 1], 1);
                }

                if (wasAnagram)
                {
                    if (targetChars.ContainsKey(s[currStart - 1]))
                    {
                        if (currentChars[s[currStart - 1]] >= targetChars[s[currStart - 1]])
                        {
                            answer.Add(currStart);
                        }
                        else
                        {
                            wasAnagram = false;
                        }
                    }
                    else
                    {
                        answer.Add(currStart);
                    }
                }
                else
                {
                    // check entire
                    wasAnagram = true;
                    foreach (KeyValuePair<char, int> entry in targetChars)
                    {
                        if (currentChars.ContainsKey(entry.Key))
                        {
                            if (currentChars[entry.Key] < entry.Value)
                            {
                                wasAnagram = false;
                                break;
                            }
                        }
                        else
                        {
                            wasAnagram = false;
                            break;
                        }
                    }
                    if (wasAnagram)
                    {
                        answer.Add(currStart);
                    }
                }

                currStart++;

            }

            return answer;
        }
    }
}
