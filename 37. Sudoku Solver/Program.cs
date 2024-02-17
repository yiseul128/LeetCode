public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        recurSolve(board, 0, 0);
    }

    public bool recurSolve(char[][] board, int row, int col)
    {
        // find next cell
        if (col > 8)
        {
            if (row == 8)
            {
                // solved
                return true;
            }

            col = 0;
            row++;
        }

        while (board[row][col] != '.')
        {
            if (col == 8)
            {
                if (row == 8)
                {
                    //solved
                    return true;
                }
                col = 0;
                row++;
            }
            else
            {
                col++;
            }
        }

        for (int val = 1; val < 10; val++)
        {
            board[row][col] = Convert.ToChar(Convert.ToString(val));
            if (validatePlacement(board, row, col))
            {
                //next
                if (recurSolve(board, row, col + 1))
                {
                    return true;
                }
            }
        }

        // revert to empty cell
        board[row][col] = '.';
        return false;
    }

    public bool validatePlacement(char[][] board, int row, int col)
    {
        bool[] used = new bool[10];

        // row
        for (int c = 0; c < 9; c++)
        {
            if (board[row][c] != '.')
            {
                if (used[int.Parse(board[row][c].ToString())])
                {
                    return false;
                }

                used[int.Parse(board[row][c].ToString())] = true;
            }
        }

        used = new bool[10];
        // col
        for (int r = 0; r < 9; r++)
        {
            if (board[r][col] != '.')
            {
                if (used[int.Parse(board[r][col].ToString())])
                {
                    return false;
                }

                used[int.Parse(board[r][col].ToString())] = true;
            }
        }

        // box
        used = new bool[10];
        col = (col / 3) * 3;
        row = (row / 3) * 3;
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                if (board[row + r][col + c] != '.')
                {
                    if (used[int.Parse(board[row + r][col + c].ToString())])
                    {
                        return false;
                    }

                    used[int.Parse(board[row + r][col + c].ToString())] = true;
                }
            }
        }

        return true;
    }
}