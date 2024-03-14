public class Solution
{
    public int CountVowelStrings(int n)
    {
        // currIdx => 1-5 representing each vowel
        return RecurCount(n, 5);
    }

    public int RecurCount(int n, int currIdx)
    {
        // length met!
        if (n == 0)
        {
            return 1;
        }

        int count = 0;
        for (int i = currIdx; i > 0; i--)
        {
            count += RecurCount(n - 1, i);
        }

        return count;
    }
}