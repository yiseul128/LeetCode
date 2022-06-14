using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.IsValid("()[]{}"));
            Console.WriteLine(s.IsValid("})"));
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            char[] parentheses = { '(', ')', '{', '}', '[', ']' };
            char[] stack = new char[s.Length];
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {

                //closing
                if (s[i] == parentheses[1] || s[i] == parentheses[3] || s[i] == parentheses[5])
                {
                    if (count == 0)
                    {  //closing first
                        return false;
                    }
                    else
                    {
                        if (s[i] == parentheses[1])
                        {
                            if (stack[count - 1] == parentheses[0])
                            { //match prev open
                                stack[count--] = ' ';
                            }
                            else
                            { //not match prev open
                                return false;
                            }
                        }
                        else if (s[i] == parentheses[3])
                        {
                            if (stack[count - 1] == parentheses[2])
                            {
                                stack[count--] = ' ';
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (stack[count - 1] == parentheses[4])
                            {
                                stack[count--] = ' ';
                            }
                            else
                            {
                                return false;
                            }

                        }
                    }
                }
                //opening
                else
                {
                    stack[count++] = s[i];
                }

                /*
                for(int j = 0; j<stack.Length; j++){
                    Console.WriteLine(stack[j]);
                }
                Console.WriteLine(count);
                */


            }

            if (count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
