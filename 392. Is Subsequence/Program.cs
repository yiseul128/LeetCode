public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }

        int sIdx = 0;
        int tIdx = 0;

        while (tIdx < t.Length)
        {
            if (s[sIdx] == t[tIdx])
            {
                sIdx++;
            }
            tIdx++;

            if (sIdx == s.Length)
            {
                return true;
            }
        }

        return false;
    }
}