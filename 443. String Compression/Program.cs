public class Solution
{
    public int Compress(char[] chars)
    {
        int count = 1;
        char currChar = chars[0];
        int idx = 0;

        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i - 1] == chars[i])
            {
                count++;
            }
            else
            {
                chars[idx++] = currChar;

                if (count != 1)
                {
                    string strCount = count.ToString();
                    for (int j = 0; j < strCount.Length; j++)
                    {
                        chars[idx++] = strCount[j];
                    }
                }

                count = 1;
                currChar = chars[i];
            }
        }

        chars[idx++] = currChar;

        if (count != 1)
        {
            string strCount = count.ToString();
            for (int j = 0; j < strCount.Length; j++)
            {
                chars[idx++] = strCount[j];
            }
        }

        return idx;
    }
}