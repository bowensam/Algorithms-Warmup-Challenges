using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveMeFirst
{
    /* Solve Me First
     * https://www.hackerrank.com/challenges/solve-me-first/problem
     * 
     * Problem
     *  - Review the code provided in the editor below, then complete the solveMeFirst function
     *  so that it returns the sum of two integers read from stdin. Take some time to understand
     *  this code so you're prepared to write it yourself in future challenges.
     *
     * Input Format
     *  - Code that reads input from stdin is provided for you in the editor. There are lines of
     *  input, and each line contains a single integer. 
     *  
     * Output Format
     *  - Code that prints the sum calculated and returned by solveMeFirst is provided for you 
     *  in the editor. 
     */

    class Program
    {
        static void Main(string[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
        static int solveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below 
            return a + b;
        }
    }
}
