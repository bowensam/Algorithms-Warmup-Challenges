using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    /* Diagonal Difference
     * https://www.hackerrank.com/challenges/diagonal-difference/problem
     * 
     * Problem
     *  - Given a square matrix of size N x N, calculate the absolute difference between the sums of its diagonals.
     *  
     * Input Format
     *  - The first line contains a single integer, N. The next N lines denote the matrix's rows, with each line containing N space-separated integers describing the columns. 
     *  
     * Constraints
     *  - -100 <= Elements in the Matrix <= 100
     *  
     * Output Format
     *  - Print the absolute difference between the two sums of the matrix's diagonals as a single integer.
     * 
     * Sample Input
     *  3
     *  11 2 4
     *  4 5 6
     *  10 8 -12
     *  
     * Sample Output
     *  15
     *  
     * Clarification
     *  - The Primary Diagonal in the sample input above would be 11, 5, -12 (Sum = 11+5-12 = 4)
     *  - The Secondary Diagonal in the sample input above would be 10, 5, 4 (Sum = 4+5+10 = 19)
     *  - The absolute difference of the diagonal sums is thus: |4-19| = 15
     */

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][]; //This is an array of array, not a 2D array
            Program p = new Program();

            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse); //dump the current line of string (represents a row in the matrix) into the current row in the int array and parse it to an int type
            }

            Console.WriteLine(Math.Abs(p.PrimaryDiagonalSum(a) - p.SecondaryDiagonalSum(a)));
        }

        private int PrimaryDiagonalSum(int[][] matrix)
        {
            int primarySum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == j)
                        primarySum += matrix[i][j];
                }
            }
            return primarySum;
        }

        private int SecondaryDiagonalSum(int[][] matrix)
        {
            int secondarySum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i + j == matrix.Length - 1)
                        secondarySum += matrix[i][j];
                }
            }
            return secondarySum;
        }
    }
}
