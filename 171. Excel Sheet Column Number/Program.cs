using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171.Excel_Sheet_Column_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int TitleToNumber(string columnTitle)
        {

            int answer = 0;
            int pow = columnTitle.Length - 1;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                switch (columnTitle[i])
                {
                    case 'A':
                        answer += 1 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'B':
                        answer += 2 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'C':
                        answer += 3 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'D':
                        answer += 4 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'E':
                        answer += 5 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'F':
                        answer += 6 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'G':
                        answer += 7 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'H':
                        answer += 8 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'I':
                        answer += 9 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'J':
                        answer += 10 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'K':
                        answer += 11 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'L':
                        answer += 12 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'M':
                        answer += 13 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'N':
                        answer += 14 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'O':
                        answer += 15 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'P':
                        answer += 16 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'Q':
                        answer += 17 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'R':
                        answer += 18 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'S':
                        answer += 19 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'T':
                        answer += 20 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'U':
                        answer += 21 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'V':
                        answer += 22 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'W':
                        answer += 23 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'X':
                        answer += 24 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'Y':
                        answer += 25 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    case 'Z':
                        answer += 26 * Convert.ToInt32(Math.Pow(26, pow));
                        break;
                    default:
                        break;
                }

                pow--;
            }

            return answer;
        }
    }
}
