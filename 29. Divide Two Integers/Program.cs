Solution s = new Solution();
Console.WriteLine(s.Divide(-2147483648, -1));

public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        // check sign
        bool isPositive = (dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0) ? true : false;

        // to long
        long longDividend = (long)dividend;
        long longDivisor = (long)divisor;
        longDividend = Math.Abs(longDividend);
        longDivisor = Math.Abs(longDivisor);

        if (longDividend == longDivisor)
        {
            return isPositive ? 1 : -1;
        }

        // loop
        long answer = 0;
        while (longDividend >= longDivisor)
        {
            long multipliedBy = 1;
            long sum = longDivisor;
            while ((sum + sum) <= longDividend)
            {
                sum += sum;
                multipliedBy += multipliedBy;
            }
            longDividend -= sum;
            answer += multipliedBy;
        }

        if (answer > Int32.MaxValue)
        {
            return isPositive ? Int32.MaxValue : Int32.MinValue;
        }

        return isPositive ? Convert.ToInt32(answer) : -Convert.ToInt32(answer);
    }
}