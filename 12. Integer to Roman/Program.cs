using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Integer_to_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string IntToRoman(int num)
        {
            string answer = "";

            string strNum = num.ToString();
            int digitsN = strNum.Length;
            char[] s = new char[4]; //char arr with digits in reversed order
            int index = 0;
            for (int i = digitsN - 1; i >= 0; i--)
            {
                s[index] = strNum[i];
                index++;
            }

            index = digitsN - 1;

            while (index != -1)
            {
                if (index == 3)
                {
                    //1000
                    switch (s[index])
                    {
                        case '3':
                            answer += "MMM";
                            break;
                        case '2':
                            answer += "MM";
                            break;
                        case '1':
                            answer += "M";
                            break;
                        default:
                            break;
                    }
                }
                else if (index == 2)
                {
                    //100
                    switch (s[index])
                    {
                        case '9':
                            answer += "CM";
                            break;
                        case '8':
                            answer += "DCCC";
                            break;
                        case '7':
                            answer += "DCC";
                            break;
                        case '6':
                            answer += "DC";
                            break;
                        case '5':
                            answer += "D";
                            break;
                        case '4':
                            answer += "CD";
                            break;
                        case '3':
                            answer += "CCC";
                            break;
                        case '2':
                            answer += "CC";
                            break;
                        case '1':
                            answer += "C";
                            break;
                        default:
                            break;
                    }

                }
                else if (index == 1)
                {
                    //10
                    switch (s[index])
                    {
                        case '9':
                            answer += "XC";
                            break;
                        case '8':
                            answer += "LXXX";
                            break;
                        case '7':
                            answer += "LXX";
                            break;
                        case '6':
                            answer += "LX";
                            break;
                        case '5':
                            answer += "L";
                            break;
                        case '4':
                            answer += "XL";
                            break;
                        case '3':
                            answer += "XXX";
                            break;
                        case '2':
                            answer += "XX";
                            break;
                        case '1':
                            answer += "X";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    //1
                    switch (s[index])
                    {
                        case '9':
                            answer += "IX";
                            break;
                        case '8':
                            answer += "VIII";
                            break;
                        case '7':
                            answer += "VII";
                            break;
                        case '6':
                            answer += "VI";
                            break;
                        case '5':
                            answer += "V";
                            break;
                        case '4':
                            answer += "IV";
                            break;
                        case '3':
                            answer += "III";
                            break;
                        case '2':
                            answer += "II";
                            break;
                        case '1':
                            answer += "I";
                            break;
                        default:
                            break;
                    }
                }

                index--;

            }

            return answer;

        }
    }
}
