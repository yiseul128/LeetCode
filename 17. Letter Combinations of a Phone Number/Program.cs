using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Letter_Combinations_of_a_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<int, string> buttons = new Dictionary<int, string>();
            buttons.Add(2, "abc");
            buttons.Add(3, "def");
            buttons.Add(4, "ghi");
            buttons.Add(5, "jkl");
            buttons.Add(6, "mno");
            buttons.Add(7, "pqrs");
            buttons.Add(8, "tuv");
            buttons.Add(9, "wxyz");

            List<string> answer = new List<string>();

            if (digits.Length == 0)
            {
                return answer;
            }

            int number = Int32.Parse(digits);
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int dec = (int)Math.Pow(10, i);
                int digit = number / dec;
                //Console.WriteLine(digit);     

                string letters = buttons[digit];
                string[] prev = answer.ToArray();
                if (prev.Length == 0)
                {
                    for (int j = 0; j < letters.Length; j++)
                    {
                        answer.Add(letters[j].ToString());
                    }
                }
                else
                {
                    answer.Clear();
                    for (int j = 0; j < letters.Length; j++)
                    {
                        for (int k = 0; k < prev.Length; k++)
                        {
                            answer.Add(prev[k] + letters[j].ToString());
                        }
                    }
                }

                number %= dec;
                //Console.WriteLine(number);
            }

            return answer;
        }
    }
}
