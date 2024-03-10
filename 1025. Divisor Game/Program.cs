public class Solution
{
    public bool DivisorGame(int n)
    {
        // n=1 => lose :(
        // n=2 => x=1 => win :)

        // if n%2==0 => can select n-1 as x
        // if n%2!=0 => can only make choose odd num as => passing even num to opponent
        return n % 2 == 0;
    }
}