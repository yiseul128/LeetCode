public class Solution
{
    public int NumSplits(string s)
    {
        Dictionary<char, int> s1 = new Dictionary<char, int>();
        s1.Add(s[0], 1);

        Dictionary<char, int> s2 = new Dictionary<char, int>();
        for (int i = 1; i < s.Length; i++)
        {
            if (s2.ContainsKey(s[i]))
            {
                s2[s[i]]++;
            }
            else
            {
                s2.Add(s[i], 1);
            }
        }

        int answer = 0;

        for (int i = 1; i < s.Length; i++)
        {
            if (s1.Count == s2.Count)
            {
                answer++;
            }

            // remove from s2
            if (s2[s[i]] > 1)
            {
                s2[s[i]]--;
            }
            else
            {
                s2.Remove(s[i]);
            }

            // add to s1
            if (s1.ContainsKey(s[i]))
            {
                s1[s[i]]++;
            }
            else
            {
                s1.Add(s[i], 1);
            }
        }

        return answer;
    }
}