using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1189.Maximum_Number_of_Balloons
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            charCount.Add('b', 0);
            charCount.Add('a', 0);
            charCount.Add('l', 0);
            charCount.Add('o', 0);
            charCount.Add('n', 0);

            foreach (char c in text)
            {
                // Console.WriteLine(c);
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
            }

            // b=>1, a=>1, l=>2, o=>2, n=>1

            int answer = Int32.MaxValue;

            charCount['l'] /= 2;
            charCount['o'] /= 2;
            foreach (var el in charCount)
            {
                answer = answer < el.Value ? answer : el.Value;
            }

            return answer;

        }
    }
}
