public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        // build dictionary with count per char
        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        for (int i = 0; i < word1.Length; i++)
        {
            if (dict1.ContainsKey(word1[i]))
            {
                dict1[word1[i]]++;
            }
            else
            {
                dict1.Add(word1[i], 1);
            }
        }

        Dictionary<char, int> dict2 = new Dictionary<char, int>();
        for (int i = 0; i < word2.Length; i++)
        {
            if (dict2.ContainsKey(word2[i]))
            {
                dict2[word2[i]]++;
            }
            else
            {
                dict2.Add(word2[i], 1);
            }
        }

        // compare letters and counts
        if (dict1.Count != dict2.Count)
        {
            return false;
        }

        Dictionary<int, int> counts1 = new Dictionary<int, int>();
        foreach (var item in dict1)
        {
            if (!dict2.ContainsKey(item.Key))
            {
                return false;
            }

            if (counts1.ContainsKey(item.Value))
            {
                counts1[item.Value]++;
            }
            else
            {
                counts1.Add(item.Value, 1);
            }
        }

        Dictionary<int, int> counts2 = new Dictionary<int, int>();
        foreach (var item in dict2)
        {
            if (!dict1.ContainsKey(item.Key))
            {
                return false;
            }

            if (counts2.ContainsKey(item.Value))
            {
                counts2[item.Value]++;
            }
            else
            {
                counts2.Add(item.Value, 1);
            }
        }

        if (counts1.Count != counts2.Count)
        {
            return false;
        }

        foreach (var item in counts1)
        {
            if (!counts2.ContainsKey(item.Key) || counts2[item.Key] != item.Value)
            {
                return false;
            }
        }

        return true;
    }
}