using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Generate_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        IList<string> wellFormed = new List<string>();

        public IList<string> GenerateParenthesis(int n)
        {
            string[] parentheses = new string[n * 2];
            BuildParentheses(parentheses, 0, "", n * 2, "(");

            return wellFormed;
        }

        public void BuildParentheses(string[] parentheses, int idx, string current, int n, string parenthesis)
        {
            if (current.Length == n)
            {
                if (idx == 0 && parenthesis == ")")
                {
                    Console.WriteLine(current);
                    wellFormed.Add(current);
                }
                return;
            }

            parentheses[idx] = parenthesis;
            current += parenthesis;

            if (idx != 0)
            {
                if (parenthesis == ")" && parentheses[idx - 1] != parenthesis)
                {
                    // pop match
                    idx--;
                }
                else if (parenthesis == "(" && parentheses[idx - 1] != parenthesis)
                {
                    // wrong sequence
                    return;
                }
                else
                {
                    // stack up
                    idx++;
                }
            }
            else
            {
                // stack up
                idx++;
            }

            // recur
            BuildParentheses(parentheses, idx, current, n, ")");
            BuildParentheses(parentheses, idx, current, n, "(");
        }
    }
}
