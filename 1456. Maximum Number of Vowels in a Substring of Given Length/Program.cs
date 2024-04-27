public class Solution
{
    public int MaxVowels(string s, int k)
    {
        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        int count = 0;
        for (int i = 0; i < k; i++)
        {
            if (vowels.Contains(s[i]))
            {
                count++;
            }
        }

        int max = count;
        int end = k;
        while (end < s.Length)
        {
            if (vowels.Contains(s[end - k]))
            {
                count--;
            }

            if (vowels.Contains(s[end]))
            {
                count++;
            }

            end++;
            max = max > count ? max : count;
        }

        return max;
    }
}