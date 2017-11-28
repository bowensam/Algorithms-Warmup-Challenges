using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    /* Simple Array Sum
     * https://www.hackerrank.com/challenges/simple-array-sum/problem
     * 
     * Problem
     *  - Given an array of N integers, can you find the sum of its elements?
     *
     * Input Format
     *  - The first line contains an integer, N, denoting the size of the array.
     *  - The second line contains N space-separated integers representing the array's elements. 
     *  
     * Output Format
     *  - Print the sum of the array's elements as a single integer.
     *  
     * Sample Input
     *  6
     *  1 2 3 4 10 11
     *  
     * Sample Output
     *  31
     */

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
        }

        static int simpleArraySum(int n, int[] ar)
        {
            // Complete this function
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
                sum += ar[i];

            return sum;
        }
    }
}
