public class Solution
{
    public int MaxRepeating(string sequence, string word)
    {
        if (sequence.Length < word.Length)
        {
            return 0;
        }

        int answer = 0;
        for (int i = 0; i < word.Length; i++)
        {
            int newMax = CountMax(sequence, word, i, 0);
            answer = answer > newMax ? answer : newMax;
        }

        return answer;
    }

    public int CountMax(string sequence, string word, int idx, int count)
    {
        if (sequence.Length < word.Length + idx)
        {
            return count;
        }

        int max = count;
        // continue
        if (sequence.Substring(idx, word.Length) == word)
        {
            int newMax = CountMax(sequence, word, idx + word.Length, count + 1);
            max = max > newMax ? max : newMax;
        }
        // count starting from next idx
        else
        {
            int newMax = CountMax(sequence, word, idx + word.Length, 0);
            max = max > newMax ? max : newMax;
        }

        return max;
    }
}