public class Solution
{
    public int LengthOfLastWord(string s)
    {
        char space = ' ';

        int end = s.Length - 1;
        while (s[end] == space)
        {
            end--;
        }

        int count = 0;
        while (end >= 0 && s[end] != space)
        {
            end--;
            count++;
        }

        return count;
    }
}