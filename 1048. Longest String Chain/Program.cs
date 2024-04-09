public class Solution
{
    public int LongestStrChain(string[] words)
    {
        SortedDictionary<int, List<string>> sortedByLen = new SortedDictionary<int, List<string>>();
        for (int i = 0; i < words.Length; i++)
        {
            if (!sortedByLen.ContainsKey(words[i].Length))
            {
                sortedByLen.Add(words[i].Length, new List<string>());
            }
            sortedByLen[words[i].Length].Add(words[i]);
        }

        int count = 0;
        foreach (var item in sortedByLen)
        {
            foreach (string s in item.Value)
            {
                words[count] = s;
                count++;
            }
        }

        int[] memo = new int[words.Length];
        int answer = 0;
        for (int i = 0; i < words.Length; i++)
        {
            int newLongest = RecurLongestStrChain(words, i + 1, 1, words[i], memo);
            answer = answer > newLongest ? answer : newLongest;
        }
        return answer;
    }

    public int RecurLongestStrChain(string[] words, int idx, int count, string prev, int[] memo)
    {
        if (words.Length == idx)
        {
            return count;
        }

        if (memo[idx] > 0)
        {
            return count + memo[idx];
        }

        int longest = count;

        // regular case
        for (int i = idx; i < words.Length; i++)
        {
            if (words[i].Length == prev.Length + 1)
            {
                // recur
                if (CheckChainable(prev, words[i]))
                {
                    //Console.WriteLine($"{prev} {words[i]}");
                    int newLongest = RecurLongestStrChain(words, i + 1, count + 1, words[i], memo);
                    longest = longest > newLongest ? longest : newLongest;
                }
            }
            else if (words[i].Length > prev.Length + 1)
            {
                break;
            }
        }

        memo[idx] = longest - count;
        return longest;
    }

    public bool CheckChainable(string a, string b)
    {
        // assume b.Length = a.Length+1
        bool isAdded = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (isAdded)
            {
                if (b[i + 1] != a[i])
                {
                    return false;
                }
            }
            else
            {
                if (a[i] != b[i])
                {
                    if (a[i] == b[i + 1])
                    {
                        isAdded = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}