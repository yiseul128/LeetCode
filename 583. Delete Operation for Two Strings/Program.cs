public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int[,] memo = new int[word1.Length, word2.Length];
        for (int i = 0; i < word1.Length; i++)
        {
            for (int j = 0; j < word2.Length; j++)
            {
                memo[i, j] = Int32.MaxValue;
            }
        }
        return RecurMinDist(word1, word2, 0, 0, 0, memo);
    }

    public int RecurMinDist(string word1, string word2, int idx1, int idx2, int count, int[,] memo)
    {
        // Console.WriteLine($"{idx1} {idx2}");
        if (idx1 == word1.Length && idx2 == word2.Length)
        {
            return count;
        }
        if (idx1 == word1.Length)
        {
            return count + word2.Length - idx2;
        }
        if (idx2 == word2.Length)
        {
            return count + word1.Length - idx1;
        }

        if (memo[idx1, idx2] != Int32.MaxValue)
        {
            return count + memo[idx1, idx2];
        }

        int ogIdx1 = idx1;
        int ogIdx2 = idx2;
        int minDist = count + word1.Length - idx1 + word2.Length - idx2;
        int newDist;
        if (word1[idx1] == word2[idx2])
        {
            // skip matching chars
            while (word1[idx1] == word2[idx2])
            {
                idx1++;
                idx2++;

                if (idx1 == word1.Length)
                {
                    return count + word2.Length - idx2;
                }
                if (idx2 == word2.Length)
                {
                    return count + word1.Length - idx1;
                }
            }
            minDist = count + word1.Length - idx1 + word2.Length - idx2;

            // delete from word1
            int nextIdx1 = -1;
            for (int i = idx1; i < word1.Length; i++)
            {
                if (word1[i] == word2[idx2])
                {
                    nextIdx1 = i;
                    break;
                }
            }
            if (nextIdx1 != -1)
            {
                newDist = RecurMinDist(word1, word2, nextIdx1, idx2, count + (nextIdx1 - idx1), memo);
                minDist = minDist < newDist ? minDist : newDist;
            }

            // delete from word2
            int nextIdx2 = -1;
            for (int i = idx2; i < word2.Length; i++)
            {
                if (word1[idx1] == word2[i])
                {
                    nextIdx2 = i;
                    break;
                }
            }
            if (nextIdx2 != -1)
            {
                newDist = RecurMinDist(word1, word2, idx1, nextIdx2, count + (nextIdx2 - idx2), memo);
                minDist = minDist < newDist ? minDist : newDist;
            }
        }
        
        // delete from word1
        newDist = RecurMinDist(word1, word2, idx1 + 1, idx2, count + 1, memo);
        //Console.WriteLine(newDist);
        minDist = minDist < newDist ? minDist : newDist;

        // delete from word2
        newDist = RecurMinDist(word1, word2, idx1, idx2 + 1, count + 1, memo);
        //Console.WriteLine(newDist);
        minDist = minDist < newDist ? minDist : newDist;

        memo[ogIdx1, ogIdx2] = minDist - count;
        return minDist;
    }
}