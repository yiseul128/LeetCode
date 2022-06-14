using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73.Set_Matrix_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            //Console.WriteLine(matrix[0].Length); //col
            //Console.WriteLine(matrix.Length); //row
            //Console.WriteLine(matrix[0][1]); //r, c

            int[] zeroRows = new int[matrix.Length * matrix[0].Length];
            int[] zeroCols = new int[matrix.Length * matrix[0].Length];
            int count = 0;

            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[0].Length; c++)
                {
                    //if zero
                    if (matrix[r][c] == 0)
                    {
                        zeroRows[count] = r;
                        zeroCols[count] = c;
                        count++;

                        //Console.WriteLine(r + ", " + c);

                    }
                }
            }

            count--;
            //set zeros
            while (count >= 0)
            {
                //Console.WriteLine(zeroRows[count] + ", " + zeroCols[count]);

                for (int inR = 0; inR < matrix.Length; inR++)
                {
                    matrix[inR][zeroCols[count]] = 0;
                }

                for (int inC = 0; inC < matrix[0].Length; inC++)
                {
                    matrix[zeroRows[count]][inC] = 0;
                }
                count--;
            }
        }
    }
}
