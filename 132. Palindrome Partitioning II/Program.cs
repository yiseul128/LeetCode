Solution s = new Solution();
//string input = "apjesgpsxoeiokmqmfgvjslcjukbqxpsobyhjpbgdfruqdkeiszrlmtwgfxyfostpqczidfljwfbbrflkgdvtytbgqalguewnhvvmcgxboycffopmtmhtfizxkmeftcucxpobxmelmjtuzigsxnncxpaibgpuijwhankxbplpyejxmrrjgeoevqozwdtgospohznkoyzocjlracchjqnggbfeebmuvbicbvmpuleywrpzwsihivnrwtxcukwplgtobhgxukwrdlszfaiqxwjvrgxnsveedxseeyeykarqnjrtlaliyudpacctzizcftjlunlgnfwcqqxcqikocqffsjyurzwysfjmswvhbrmshjuzsgpwyubtfbnwajuvrfhlccvfwhxfqthkcwhatktymgxostjlztwdxritygbrbibdgkezvzajizxasjnrcjwzdfvdnwwqeyumkamhzoqhnqjfzwzbixclcxqrtniznemxeahfozp";
string input = "apjesgpsxoeiokmqmfgvjslcjukbqxpsobyhjpbgdfruqdkeiszrl";
Console.WriteLine(s.MinCut(input));

public class Solution
{
    public int MinCut(string s)
    {
        int n = s.Length;
        int[] memo = new int[n + 1];

        // initialize with cuts for s(0,i) as i-1, assuming each char in substr should be cut 
        // (e.g. len=1 => 0 cut, len 3=>2 cut)
        for (int i = 0; i < memo.Length; i++)
        {
            memo[i] = i - 1;
        }

        // iterate through 0-n-1 as mid
        for (int mid = 0; mid < n; mid++)
        {
            // len => odd
            for (int start = mid, end = mid; start >= 0 && end < n && s[start] == s[end]; start--, end++)
            {
                // min cut for substr ending at idx end => either exisitng memo min || memo min for substr starting at start + 1
                memo[end + 1] = Math.Min(memo[end + 1], memo[start] + 1);
            }

            // len => even
            for (int start = mid - 1, end = mid; start >= 0 && end < n && s[start] == s[end]; start--, end++)
            {
                memo[end + 1] = Math.Min(memo[end + 1], memo[start] + 1);
            }
        }

        return memo[n];
    }
}