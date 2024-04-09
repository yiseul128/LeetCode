public class Solution
{
    public int FindLongestChain(int[][] pairs)
    {
        SortedDictionary<int, int> sortedPairs = new SortedDictionary<int, int>();
        for (int i = 0; i < pairs.Length; i++)
        {
            //Console.WriteLine($"{pairs[i][0]} {pairs[i][1]}");
            if (sortedPairs.ContainsKey(pairs[i][0]))
            {
                sortedPairs[pairs[i][0]] = sortedPairs[pairs[i][0]] < pairs[i][1] ? sortedPairs[pairs[i][0]] : pairs[i][1];
            }
            else
            {
                sortedPairs.Add(pairs[i][0], pairs[i][1]);
            }
        }

        int count = 0;
        foreach (var item in sortedPairs)
        {
            pairs[count][0] = item.Key;
            pairs[count][1] = item.Value;

            // Console.WriteLine($"{pairs[count][0]} {pairs[count][1]}");

            count++;
        }

        int[] memo = new int[count];
        int answer = 1;
        for (int i = 0; i < count; i++)
        {
            int newLongest = RecurFindChain(pairs, 0, 0, count, Int32.MinValue, memo);
            answer = answer > newLongest ? answer : newLongest;
        }

        return answer;
    }

    public int RecurFindChain(int[][] pairs, int chainLength, int idx, int count, int lastInt, int[] memo)
    {
        if (idx == count)
        {
            return chainLength;
        }

        if (memo[idx] > 0)
        {
            return chainLength + memo[idx];
        }

        int longest = chainLength;
        for (int i = idx; i < count; i++)
        {
            if (pairs[i][0] > lastInt)
            {
                //recur 
                int newLength = RecurFindChain(pairs, chainLength + 1, i + 1, count, pairs[i][1], memo);
                longest = longest > newLength ? longest : newLength;
            }
        }

        memo[idx] = longest - chainLength;
        return longest;
    }
}