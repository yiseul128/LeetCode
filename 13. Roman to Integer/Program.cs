using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int l = s.Length - 1;
            int c = l;
            int answer = 0;

            while (c != -1)
            {
                switch (s[c])
                {
                    case 'I':
                        if (c != l && (s[c + 1] == 'V' || s[c + 1] == 'X'))
                        {
                            answer -= 1;
                            break;
                        }
                        answer += 1;
                        break;
                    case 'V':
                        answer += 5;
                        break;
                    case 'X':
                        if (c != l && (s[c + 1] == 'L' || s[c + 1] == 'C'))
                        {
                            answer -= 10;
                            break;
                        }
                        answer += 10;
                        break;
                    case 'L':
                        answer += 50;
                        break;
                    case 'C':
                        if (c != l && (s[c + 1] == 'D' || s[c + 1] == 'M'))
                        {
                            answer -= 100;
                            break;
                        }
                        answer += 100;
                        break;
                    case 'D':
                        answer += 500;
                        break;
                    case 'M':
                        answer += 1000;
                        break;
                    default:
                        break;
                }
                c--;
            }

            return answer;
        }
    }
}
