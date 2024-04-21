public class Solution
{
    public string ReverseVowels(string s)
    {
        int[] vowelIdxs = new int[s.Length];
        int vowelCount = 0;
        char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                vowelIdxs[vowelCount] = i;
                vowelCount++;
            }
        }

        char[] answer = s.ToCharArray();
        int left = 0;
        int right = vowelCount - 1;
        while (left < right)
        {
            answer[vowelIdxs[right]] = s[vowelIdxs[left]];
            answer[vowelIdxs[left]] = s[vowelIdxs[right]];
            left++;
            right--;
        }

        return new string(answer);
    }
}