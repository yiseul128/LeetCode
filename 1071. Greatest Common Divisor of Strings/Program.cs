public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 == str2 + str1)
        {
            int len = str1.Length < str2.Length ? str1.Length : str2.Length;

            // find GCD
            for (int i = len; i > 0; i--)
            {
                if (str1.Length % i == 0 && str2.Length % i == 0)
                {
                    return str1.Substring(0, i);
                }
            }
        }
        return "";

        /*
        int n = str1.Length < str2.Length ? str1.Length : str2.Length;

        for (int i = n; i > 0; i--)
        {
            if (str1.Length % i == 0 && str2.Length % i == 0)
            {
                bool isDivisorFor1 = true;
                string divisor = str1.Substring(0, i);
                for (int j = i; j < str1.Length; j += i)
                {
                    if (str1.Substring(j, i) != divisor)
                    {
                        isDivisorFor1 = false;
                        break;
                    }
                }

                bool isDivisorFor2 = true;
                if (isDivisorFor1)
                {
                    for (int j = 0; j < str2.Length; j += i)
                    {
                        if (str2.Substring(j, i) != divisor)
                        {
                            isDivisorFor2 = false;
                            break;
                        }
                    }
                }

                if (isDivisorFor2 && isDivisorFor1)
                {
                    return divisor;
                }
            }
            .
        }

        return "";
        */
    }
}