public class Solution
{
    public int MinFallingPathSum(int[][] matrix)
    {
        int[,] memo = new int[matrix.Length, matrix[0].Length];
        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[0].Length; c++)
            {
                memo[r, c] = Int32.MaxValue;
            }
        }

        int min = Int32.MaxValue;
        for (int c = 0; c < matrix[0].Length; c++)
        {
            int newMin = RecurMinFallingPathSum(matrix, 0, c, 0, memo);
            min = min < newMin ? min : newMin;
        }
        return min;
    }

    public int RecurMinFallingPathSum(int[][] matrix, int row, int col, int sum, int[,] memo)
    {
        if (row == matrix.Length)
        {
            return sum;
        }

        sum += matrix[row][col];
        if (memo[row, col] != Int32.MaxValue)
        {
            return sum + memo[row, col];
        }

        int min = Int32.MaxValue;
        int newMin = RecurMinFallingPathSum(matrix, row + 1, col, sum, memo);
        min = min < newMin ? min : newMin;
        if (col > 0)
        {
            newMin = RecurMinFallingPathSum(matrix, row + 1, col - 1, sum, memo);
            min = min < newMin ? min : newMin;
        }
        if (col < matrix[0].Length - 1)
        {
            newMin = RecurMinFallingPathSum(matrix, row + 1, col + 1, sum, memo);
            min = min < newMin ? min : newMin;
        }

        memo[row, col] = min - sum;
        return min;
    }
}