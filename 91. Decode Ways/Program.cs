public class Solution
{
    int[] counts;

    public int NumDecodings(string s)
    {
        counts = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            counts[i] = -1;
        }
        return RecurDecode(s, 0);
    }

    public int RecurDecode(String s, int idx)
    {
        // base case
        if (s.Length == 0)
        {
            return 1;
        }
        if (s[0] == '0')
        {
            counts[idx] = 0;
            return 0;
        }
        if (counts[idx] > 0)
        {
            return counts[idx];
        }

        int n = 0;

        // cut 1 digit
        n += RecurDecode(s.Substring(1), idx + 1);

        // cut 2 digits
        if (s.Length > 1 && Int32.Parse(s.Substring(0, 2)) < 27)
        {
            n += RecurDecode(s.Substring(2), idx + 2);
        }

        counts[idx] = n;
        return n;
    }
}