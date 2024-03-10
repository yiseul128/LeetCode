public class Solution
{
    public IList<string> GetLongestSubsequence(string[] words, int[] groups)
    {
        IList<string> answer = new List<string>();

        int prevBinary = -1;
        for (int i = 0; i < words.Length; i++)
        {
            if (prevBinary != groups[i])
            {
                answer.Add(words[i]);
                prevBinary = groups[i];
            }
        }

        return answer;
    }
}
}