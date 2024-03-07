public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        List<IList<string>> answer = new List<IList<string>>();
        RecurPartition(s, answer, new List<string>(), 0, 1);
        return answer;
    }

    public void RecurPartition(string s, IList<IList<string>> answer, IList<string> partition, int idx, int length)
    {
        if (idx + length > s.Length)
        {
            return;
        }

        string substr = s.Substring(idx, length);
        int halfLen = length / 2;
        bool isValid = true;
        for (int i = 0; i < halfLen; i++)
        {
            if (substr[i] != substr[length - 1 - i])
            {
                isValid = false;
                break;
            }
        }

        // recur
        RecurPartition(s, answer, new List<string>(partition), idx, length + 1);
        if (isValid)
        {
            partition.Add(substr);

            // add to answer
            if (idx + length == s.Length)
            {
                answer.Add(partition);
            }

            // recur
            RecurPartition(s, answer, new List<string>(partition), idx + length, 1);
        }
    }
}