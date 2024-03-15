public class Solution
{
    public int CountSubstrings(string s)
    {
        int answer = 0;
        int n = s.Length;
        for (int mid = 0; mid < n; mid++)
        {
            // odd len
            for (int start = mid, end = mid; start >= 0 && end < n && s[start] == s[end]; start--, end++)
            {
                answer++;
            }

            // even len
            for (int start = mid - 1, end = mid; start >= 0 && end < n && s[start] == s[end]; start--, end++)
            {
                answer++;
            }
        }

        return answer;
    }
}