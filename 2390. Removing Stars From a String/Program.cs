public class Solution
{
    public string RemoveStars(string s)
    {
        Stack<char> processedStack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                processedStack.Pop();
            }
            else
            {
                processedStack.Push(s[i]);
            }
        }

        char[] charArr = new char[processedStack.Count];
        int idx = charArr.Length - 1;
        while (processedStack.Count > 0)
        {
            charArr[idx--] = processedStack.Pop();
        }
        return new string(charArr);
    }
}