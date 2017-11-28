using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    /* A Very Big Sum
     * https://www.hackerrank.com/challenges/a-very-big-sum
     * 
     * Problem
     *  - You are given an array of integers of size . You need to print the sum of the elements in the array,
     *  keeping in mind that some of those integers may be quite large. 
     *  
     * Input Format
     *  - The first line of the input consists of an integer . The next line contains space-separated integers
     *  contained in the array. 
     *  
     * Constraints
     *  - 1 <= N <= 10
     *  - 1 <= A[i] <= 10^10
     *  
     * Sample Input
     *  5
     *  1000000001 1000000002 1000000003 1000000004 1000000005
     *  
     * Sample Output
     *  5000000015
     */

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = AVeryBigSum(n, ar);
            Console.WriteLine(result);
        }

        static long AVeryBigSum(int n, long[] ar)
        {
            // Complete this function
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
                sum += ar[i];

            return sum;
        }
    }
}
