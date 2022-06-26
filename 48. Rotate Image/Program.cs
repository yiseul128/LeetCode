using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Rotate_Image
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {

            int n = matrix[0].Length - 1;
            //Console.WriteLine(n);
            int half = n / 2;
            //Console.WriteLine(half);

            int c = 0;
            while (c <= half)
            {

                for (int r = c; r < n - c; r++)
                {

                    //Console.WriteLine($"{matrix[c][n-r]}, {matrix[n-r][n-c]}, {matrix[n-c][r]}, {matrix[r][c]}"); //rt rb lb lt
                    int temp = matrix[n - r][n - c]; // rb
                    matrix[n - r][n - c] = matrix[c][n - r]; // rb=rt
                    int temp2 = matrix[n - c][r]; //lb
                    matrix[n - c][r] = temp; //lb=rb
                    temp = matrix[r][c]; //lt
                    matrix[r][c] = temp2; //lt=lb
                    matrix[c][n - r] = temp; //rt=lt
                    //Console.WriteLine($"{matrix[c][n-r]}, {matrix[n-r][n-c]}, {matrix[n-c][r]}, {matrix[r][c]}"); //rt rb lb lt

                }

                c++;
            }

        }
    }
}
