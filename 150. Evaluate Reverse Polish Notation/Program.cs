using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150.Evaluate_Reverse_Polish_Notation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            List<string> tkns = new List<string>();
            int opIdx = -1;
            for (int i = 0; i < tokens.Length; i++)
            {
                tkns.Add(tokens[i]);
                if (opIdx == -1)
                {
                    if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                    {
                        opIdx = i;
                    }
                }
            }

            while (tkns.Count != 1)
            {
                // n-n-o
                string op = tkns.ElementAt(opIdx);

                // Console.WriteLine("1: " + Convert.ToInt32(tkns.ElementAt(opIdx-2)));
                // Console.WriteLine("2: " + Convert.ToInt32(tkns.ElementAt(opIdx-1)));

                if (op == "+")
                {
                    tkns.Insert(opIdx - 2, (Convert.ToInt32(tkns.ElementAt(opIdx - 2)) + Convert.ToInt32(tkns.ElementAt(opIdx - 1))).ToString());
                }
                else if (op == "-")
                {
                    tkns.Insert(opIdx - 2, (Convert.ToInt32(tkns.ElementAt(opIdx - 2)) - Convert.ToInt32(tkns.ElementAt(opIdx - 1))).ToString());
                }
                else if (op == "*")
                {
                    tkns.Insert(opIdx - 2, (Convert.ToInt32(tkns.ElementAt(opIdx - 2)) * Convert.ToInt32(tkns.ElementAt(opIdx - 1))).ToString());
                }
                else if (op == "/")
                {
                    tkns.Insert(opIdx - 2, (Convert.ToInt32(tkns.ElementAt(opIdx - 2)) / Convert.ToInt32(tkns.ElementAt(opIdx - 1))).ToString());
                }

                tkns.RemoveAt(opIdx - 1);
                tkns.RemoveAt(opIdx - 1);
                tkns.RemoveAt(opIdx - 1);

                // Console.WriteLine("tkns.Count: " + tkns.Count);
                // Console.WriteLine("opIdx: " + opIdx);

                if (tkns.Count == 1)
                {
                    break;
                }

                for (int i = opIdx - 1; i < tkns.Count; i++)
                {
                    if (tkns.ElementAt(i) == "+" || tkns.ElementAt(i) == "-" || tkns.ElementAt(i) == "*" || tkns.ElementAt(i) == "/")
                    {
                        opIdx = i;
                        break;
                    }
                }
                // Console.WriteLine("new opIdx: " + opIdx);
            }

            return Convert.ToInt32(tkns.ElementAt(0));
        }
    }
}
