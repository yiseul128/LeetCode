public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        char[] merged = new char[word1.Length + word2.Length];

        int n = word1.Length > word2.Length ? word1.Length : word2.Length;
        int idx = 0;
        for (int i = 0; i < n; i++)
        {
            if (word1.Length > i)
            {
                merged[idx++] = word1[i];
            }

            if (word2.Length > i)
            {
                merged[idx++] = word2[i];
            }
        }

        return new string(merged);
    }
}