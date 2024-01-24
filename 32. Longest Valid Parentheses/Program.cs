Solution s = new Solution();
Console.WriteLine(s.LongestValidParentheses("(()()"));
public class Solution
{
    public int LongestValidParentheses(string s)
    {
        const char OPENING = '(';
        const char CLOSING = ')';

        int longest = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            int currIdx = i;
            if (s.Length - currIdx < longest)
            {
                break;
            }
            if (s[currIdx] == CLOSING)
            {
                continue;
            }

            // check longest
            Stack<char> parentheses = new Stack<char>();
            while (currIdx < s.Length)
            {
                if (s[currIdx] == OPENING)
                {
                    parentheses.Push(OPENING);
                }
                else
                {
                    if (parentheses.Count > 0)
                    {
                        parentheses.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                currIdx++;

                if (parentheses.Count == 0)
                {
                    int newLongest = currIdx - i;
                    longest = longest > newLongest ? longest : newLongest;
                }
            }
        }

        return longest;
    }
}