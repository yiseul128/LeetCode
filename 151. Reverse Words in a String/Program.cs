public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');

        string answer = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            words[i] = words[i].Replace(" ", "").Replace("\t", "");

            if (words[i].Length > 0)
            {
                answer += " " + words[i];
            }
        }

        return answer.Substring(1);
    }
}