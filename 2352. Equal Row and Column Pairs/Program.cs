public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        int answer = 0;

        string[] strRows = new string[grid.Length];
        for (int r = 0; r < grid.Length; r++)
        {
            string strRow = "";
            for (int c = 0; c < grid[0].Length; c++)
            {
                strRow += grid[r][c].ToString() + ",";
            }
            strRows[r] = strRow;
        }

        string[] strCols = new string[grid[0].Length];
        for (int c = 0; c < grid[0].Length; c++)
        {
            string strCol = "";
            for (int r = 0; r < grid.Length; r++)
            {
                strCol += grid[r][c].ToString() + ",";
            }
            strCols[c] = strCol;
        }

        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[0].Length; c++)
            {
                if (strCols[c] == strRows[r])
                {
                    answer++;
                }
            }
        }

        return answer;
    }
}