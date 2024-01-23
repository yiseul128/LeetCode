Solution s = new Solution();
string[] words = { "foo", "bar" };
Console.WriteLine(s.FindSubstring("barfoothefoobarman", words));

public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> answer = new List<int>();

        int wordLength = words[0].Length;
        int substrLength = words.Length * wordLength;
        int startIdx = 0;
        int currIdx = 0;
        List<string> wordsList = words.ToList();

        while (startIdx + substrLength <= s.Length)
        {
            Queue<string> wordsQueue = new Queue<string>(wordsList);

            // check
            while (wordsQueue.Count > 0)
            {
                bool next = false; // should move to next word => true
                int leftWordsCount = wordsQueue.Count;
                for (int i = 0; i < leftWordsCount; i++)
                {
                    string currWord = wordsQueue.Dequeue();
                    // found
                    if (s.Substring(currIdx, wordLength) == currWord)
                    {
                        currIdx += wordLength;
                        next = true;
                        break;
                    }
                    else
                    {
                        wordsQueue.Enqueue(currWord);
                    }
                }
                // not found
                if (!next)
                {
                    break;
                }
            }

            if (wordsQueue.Count == 0)
            {
                answer.Add(startIdx);
            }

            startIdx++;
            currIdx = startIdx;
        }
        return answer;
    }
}