using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    /* Compare The Triplets
     * https://www.hackerrank.com/challenges/compare-the-triplets/problem
     * 
     * Problem
     *  - Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, 
     *  awarding points on a scale from 1 to 100 for three categories: problem clarity, originality,
     *  and difficulty.
     *  
     *  - We define the rating for Alice's challenge to be the triplet A = (a0, a1, a2), and the rating
     *  for Bob's challenge to be the triplet B = (b0, b1, b2).
     *  
     *  - Your task is to find their comparison points by comparing a0 with b0, a1 with b1, and a2 with b2.
     *      If a > b, then Alice is awarded 1 point.
     *      If a < b, then Bob is awarded 1 point.
     *      If a = b, then neither person receives a point.
     *  
     *  - Comparison points is the total points a person earned.
     *  - Given A and B, can you compare the two challenges and print their respective comparison points?
     *
     * Input Format
     *  - The first line contains 3 space-separated integers, a0, a1, and a2, describing the respective values in triplet A.
     *  - The second line contains 3 space-separated integers, b0, b1, and b2, describing the respective values in triplet B.
     *  
     * Constraints
     *  - 1 <= a <= 100
     *  - 1 <= b <= 100
     * 
     * Output Format
     *  - Print two space-separated integers denoting the respective comparison points earned by Alice and Bob.
     *  
     * Sample Input
     *  5 6 7
     *  3 6 10
     *  
     * Sample Output
     *  1 1
     */

    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = Solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
        }

        static int[] Solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            // Complete this function
            int[] score = new int[2];

            if (a0 > b0)
                score[0] += 1;
            else if (a0 < b0)
                score[1] += 1;

            if (a1 > b1)
                score[0] += 1;
            else if (a1 < b1)
                score[1] += 1;

            if (a2 > b2)
                score[0] += 1;
            else if (a2 < b2)
                score[1] += 1;

            return score;
        }
    }
}
