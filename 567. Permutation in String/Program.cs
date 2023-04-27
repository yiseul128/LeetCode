public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> toCheck = new Dictionary<char, int>();
        Queue<char> perm = new Queue<char>();

        for (int i = 0; i < s1.Length; i++)
        {
            if (toCheck.ContainsKey(s1[i]))
            {
                toCheck[s1[i]]++;
            }
            else
            {
                toCheck.Add(s1[i], 1);
            }
        }

        for (int i = 0; i < s2.Length; i++)
        {
            // perm continue
            if (toCheck.ContainsKey(s2[i]))
            {
                if (toCheck[s2[i]] == 1)
                {
                    toCheck.Remove(s2[i]);
                }
                else
                {
                    toCheck[s2[i]]--;
                }
                perm.Enqueue(s2[i]);
            }
            // perm stop
            else
            {
                while (perm.Count != 0)
                {
                    char lastChar = perm.Dequeue();

                    // start checking perm from this point
                    if (lastChar == s2[i])
                    {
                        perm.Enqueue(lastChar);
                        break;
                    }
                    // move starting idx of perm in s2 to right
                    else
                    {
                        if (toCheck.ContainsKey(lastChar))
                        {
                            toCheck[lastChar]++;
                        }
                        else
                        {
                            toCheck.Add(lastChar, 1);
                        }
                    }
                }
            }

            if (toCheck.Count == 0)
            {
                return true;
            }
        }

        return false;

    }
}