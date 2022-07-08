using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79.Word_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            char[][] arr = new char[][]
            {
                new char[] { 'A','B','C','E' },
                new char[] { 'S','F','E','S' },
                new char[] { 'A', 'D', 'E', 'E'}
            };

            Console.WriteLine(s.Exist(arr, "ABCESEEEFS"));

        }
    }
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            /*
            [["C","A","A"],["A","A","A"],["B","C","D"]]
            "AAB"

            [["A","B","C","E"],["S","F","E","S"],["A","D","E","E"]]
            "ABCESEEEFS"
            */

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[0].Length; col++)
                {
                    if (board[row][col] == word[0])
                    {
                        bool[] leftVisited = new bool[word.Length];
                        bool[] rightVisited = new bool[word.Length];
                        bool[] upVisited = new bool[word.Length];
                        bool[] downVisited = new bool[word.Length];

                        bool[,] used = new bool[board.Length, board[0].Length];
                        used[row, col] = true;

                        int index = 1;
                        int r = row;
                        int c = col;
                        int[] prevR = new int[word.Length];
                        int[] prevC = new int[word.Length];
                        prevR[0] = r;
                        prevC[0] = c;

                        while (true)
                        {
                            //word found
                            if (index == word.Length)
                            {
                                return true;
                            }

                            Console.WriteLine(word[index]);


                            //down
                            if (r != board.Length - 1 && !downVisited[index] && !used[r + 1, c] && word[index] == board[r + 1][c])
                            {
                                used[r + 1, c] = true;
                                r++;
                                prevR[index] = r;
                                prevC[index] = c;

                                index++;
                                //Console.WriteLine(r + ", " + c);
                                continue;
                            }
                            //up
                            if (r != 0 && !upVisited[index] && !used[r - 1, c] && word[index] == board[r - 1][c])
                            {
                                used[r - 1, c] = true;
                                r--;
                                prevR[index] = r;
                                prevC[index] = c;

                                index++;
                                //Console.WriteLine(r + ", " + c);
                                continue;
                            }
                            //right
                            if (c != board[0].Length - 1 && !rightVisited[index] && !used[r, c + 1] && word[index] == board[r][c + 1])
                            {
                                used[r, c + 1] = true;
                                c++;
                                prevR[index] = r;
                                prevC[index] = c;

                                index++;
                                //Console.WriteLine(r + ", " + c);
                                continue;
                            }
                            //left
                            if (c != 0 && !leftVisited[index] && !used[r, c - 1] && word[index] == board[r][c - 1])
                            {
                                used[r, c - 1] = true;
                                c--;
                                prevR[index] = r;
                                prevC[index] = c;

                                index++;
                                //Console.WriteLine(r + ", " + c);
                                continue;
                            }

                            if (c == col && r == row)
                            {
                                break;
                            }

                            //backtrack
                            used[r, c] = false;

                            index--;

                            if(c == prevC[index - 1])
                            {
                                if(r == prevR[index - 1] + 1)
                                {
                                    downVisited[index] = true; 
                                }
                                else
                                {
                                    upVisited[index] = true;
                                }
                            }
                            else
                            {
                                if(c == prevC[index - 1]+1)
                                {
                                    rightVisited[index] = true;
                                }
                                else
                                {
                                    leftVisited[index] = true;
                                }
                            }
                            rightVisited[index+1] = false;
                            leftVisited[index+1] = false;
                            upVisited[index+1] = false;
                            downVisited[index+1] = false;


                            r = prevR[index-1];
                            c = prevC[index-1];
                                                       
                        }
                    }
                }
            }

            return false;
        }
    }
}
