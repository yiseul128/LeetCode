public class Solution
{
    public int TotalNQueens(int n)
    {
        bool[][] board = new bool[n][];
        for (int i = 0; i < n; i++)
        {
            board[i] = new bool[n];
        }

        return RecurSolve(board, 0, 0); ;
    }

    public int RecurSolve(bool[][] board, int row, int answer)
    {
        if (row == board.Length)
        {
            // add to answer
            return 1;
        }

        for (int col = 0; col < board.Length; col++)
        {
            if (ValidatePlacement(board, row, col))
            {
                // put Q
                board[row][col] = true;

                // recurr
                answer += RecurSolve(board, row + 1, 0);

                // remove Q
                board[row][col] = false;
            }
        }

        return answer;
    }

    public bool ValidatePlacement(bool[][] board, int row, int col)
    {

        for (int i = 0; i < board.Length; i++)
        {
            // vertical
            if (board[i][col])
            {
                return false;
            }

            // diagonal 
            // down right 
            if (row + i < board.Length && col + i < board.Length && board[row + i][col + i])
            {
                return false;
            }
            // down left
            if (row + i < board.Length && col - i >= 0 && board[row + i][col - i])
            {
                return false;
            }
            // up right
            if (row - i >= 0 && col + i < board.Length && board[row - i][col + i])
            {
                return false;
            }
            // up left
            if (row - i >= 0 && col - i >= 0 && board[row - i][col - i])
            {
                return false;
            }
        }

        return true;
    }
}